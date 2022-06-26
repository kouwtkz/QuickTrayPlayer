using System;
using System.IO;
using System.IO.Pipes;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PipeObject
{
    public class PipeClass
    {
        public string PipeName { get; private set; }
        public bool CreatedNew { get; private set; } = false;
        private Semaphore smp = null;
        public CancellationTokenSource Cancellation { get; private set; } = null;
        private NamedPipeServerStream pipeServer = null;
        public PipeClass(string name)
        {
            PipeName = name;
            smp = new Semaphore(0, 1, PipeName, out bool created);
            CreatedNew = created;
            if (!created)
            {
                smp.Dispose();
                smp = null;
            }
        }
        ~PipeClass()
        {
            smp?.Dispose();
            Cancellation?.Cancel();
        }
        public Task PipeHost(Action<string> Method)
        {
            Cancellation?.Cancel();
            Cancellation = new CancellationTokenSource();
            return Task.Run(async () =>
            {
                while (true)
                {
                    try
                    {
                        while (true)
                        {
                            pipeServer = new NamedPipeServerStream(PipeName, PipeDirection.InOut, 1);
                            await pipeServer.WaitForConnectionAsync(Cancellation.Token);
                            StreamString ss = new StreamString(pipeServer);
                            while (true)
                            {
                                var read = ss.ReadString();
                                var write = ss.WriteString("Server read OK.");
                                Method(read);
                                if (read == "end") break;
                            }
                        }
                    }
                    catch (OverflowException ofex)
                    {
                        Console.WriteLine(ofex.Message);
                    }
                    finally
                    {
                        pipeServer?.Close();
                    }
                    if (Cancellation.IsCancellationRequested)
                    {
                        break;
                    }
                }
            });
        }
        public bool PipeSend(string message)
        {
            NamedPipeClientStream pipeClient = null;
            bool ret = false;
            try
            {
                pipeClient = new NamedPipeClientStream(".", PipeName, PipeDirection.InOut, PipeOptions.None, TokenImpersonationLevel.Impersonation);
                pipeClient.Connect();
                var ss = new StreamString(pipeClient);
                ss.WriteString(message);
                var read = ss.ReadString();
                Console.WriteLine("Server Response = " + read);
                ret = true;
            }
            catch (OverflowException ofex)
            {
                Console.WriteLine(ofex.Message);
            }
            catch (IOException ioe)
            {
                // 送信失敗
                Console.WriteLine(ioe.Message);
            }
            finally
            {
                pipeClient?.Close();
            }
            return ret;
        }
    }
    public class StreamString
    {
        private Stream ioStream;
        private UnicodeEncoding streamEncoding;

        public StreamString(Stream ioStream)
        {
            this.ioStream = ioStream;
            streamEncoding = new UnicodeEncoding();
        }

        public string ReadString()
        {
            int len = 0;

            len = ioStream.ReadByte() * 256;
            len += ioStream.ReadByte();
            byte[] inBuffer = new byte[len];
            ioStream.Read(inBuffer, 0, len);

            return streamEncoding.GetString(inBuffer);
        }

        public int WriteString(string outString)
        {
            byte[] outBuffer = streamEncoding.GetBytes(outString);
            int len = outBuffer.Length;
            if (len > UInt16.MaxValue)
            {
                len = (int)UInt16.MaxValue;
            }
            ioStream.WriteByte((byte)(len / 256));
            ioStream.WriteByte((byte)(len & 255));
            ioStream.Write(outBuffer, 0, len);
            ioStream.Flush();

            return outBuffer.Length + 2;
        }
    }
}