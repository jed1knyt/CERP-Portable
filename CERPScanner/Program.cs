using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CERPScanner
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            //Login login = new Login();
            //if (login.ShowDialog() == DialogResult.OK)
            //{
            //    Application.Run(new Home());
            //}
            Application.Run(new Home());
        }
    }
}