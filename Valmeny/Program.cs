using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Valmeny
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string [] args)
        {
            if (!WindowsIdentity.GetCurrent().Name.StartsWith("GAIA\\gaisys"))
            {
                ProcessStartInfo proc = new ProcessStartInfo();
                proc.WorkingDirectory = Environment.CurrentDirectory;
                proc.FileName = "runas.exe";
                proc.Arguments = $"/user:gaia\\gaisys{WindowsIdentity.GetCurrent().Name.Substring(5)} \"\\\\dfs\\gem$\\Lit\\IT-Service\\Fabriken Solna\\Pavels Program\\Valmeny.exe {WindowsIdentity.GetCurrent().Name.Substring(5)}\"";
                Process.Start(proc);
                Environment.Exit(0);
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1(args));
            }
        }
    }
}
