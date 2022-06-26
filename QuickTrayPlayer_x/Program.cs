namespace QuickTrayPlayer
{
    using PipeObject;
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            bool duplication = Settings1.Default.Duplication;
            PipeClass pipeObj = new("miniPlayer");
            if (duplication || pipeObj.CreatedNew)
            {
                ApplicationConfiguration.Initialize();
                Form1 form1 = new Form1();
                form1.SetArgs(args);
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