using System;
using System.Windows.Forms;

namespace Studio2RotaControl
{
    internal static class Program
    {
        #region Methods

        public static Form FrmStart;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(FrmStart = new FrmStart());
        }

        #endregion Methods
    }
}