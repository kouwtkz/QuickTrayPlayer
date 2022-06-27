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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool duplication = Settings.Default.Duplication;
            PipeClass pipeObj = new PipeClass("QuickTrayPlayer");
            string path = "";
            if (args.Length > 0)
            {
                path = args[0];
            } else
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    
                    openFileDialog.Filter = Resources.FileExtsFilter;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        path = openFileDialog.FileName;
                    }
                }
            }
            if (duplication || pipeObj.CreatedNew)
            {
                Form1 form1 = new Form1();
                form1.SetPlayer(path);
                if (pipeObj.CreatedNew)
                {
                    pipeObj.PipeHost(form1.OpenPlayInvoke);
                }
                Application.Run(form1);
            }
            else
            {
                if (path != "") pipeObj.PipeSend(path);
            }
        }
    }
}
