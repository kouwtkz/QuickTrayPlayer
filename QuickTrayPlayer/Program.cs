using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickTrayPlayer
{
    using Properties;
    using PipeObject;
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            bool duplication = Settings.Default.Duplication;
            PipeClass pipeObj = new PipeClass("QuickTrayPlayer");
            if (duplication || pipeObj.CreatedNew)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Form1 form1 = new Form1();
                form1.args = args;
                form1.Hide();
                if (pipeObj.CreatedNew)
                {
                    pipeObj.PipeHost(form1.OpenPlayInvoke);
                }
                Application.Run(form1);
            }
            else
            {
                if (args.Length > 0) pipeObj.PipeSend(args[0]);
            }
        }
    }
}
