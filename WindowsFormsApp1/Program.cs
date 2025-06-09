using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Program
    {
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard());
            // 1.Show Splash
            //Splash splash = new Splash();
            // splash.Show();
            // Application.DoEvents();
            // System.Threading.Thread.Sleep(2000);
            // splash.Close();

            // 2.Show Login
            //Login login = new Login();
            // if (login.ShowDialog() == DialogResult.OK)
            // {
            //     Application.Run(new Splash()); // Replace Splash with MainForm() if needed
            // }
            // else
            // {
            //     Application.Exit();
            // }
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
