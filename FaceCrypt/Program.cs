using System;
using System.Windows.Forms;

namespace FaceCrypt
{
    internal static class Program
    {
        internal static Welcome welcome;

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            welcome = new Welcome();
            Application.Run(welcome);
        }
    }
}