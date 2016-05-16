using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace gomrokP1
{
    static class Program
    {
        public static MainForm mainForm;
        public static LoginForm loginForm;
        public static EzharForm ezharForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            loginForm = new LoginForm();
            Application.Run(loginForm);
        }
    }
}
