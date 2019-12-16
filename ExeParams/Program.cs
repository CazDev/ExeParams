using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeParams
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //Start process with arguments.
            if (args.Length > 0)
            {
                string arg = "";
                for (int i = 0; i < args.Length; i++) // Loop through array
                {
                    arg += args[i] + " ";
                }
                System.Diagnostics.Process.Start(arg);

                Environment.Exit(0);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ExeParams());
        }
    }
}
