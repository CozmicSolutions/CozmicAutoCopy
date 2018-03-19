using System;
using System.Windows.Forms;

namespace CozmicAutoCopyControlPanel
{
    internal static class Program
    {
        #region Private Methods

        /// <summary>
        ///      The main entry point for the application. 
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string[] args = Environment.GetCommandLineArgs();

            if (args.Length > 1)
                Application.Run(new AutoCopyProgress());
            else
            {
                Application.Run(new AutoCopyControlPanel());
            }
        }

        #endregion Private Methods
    }
}