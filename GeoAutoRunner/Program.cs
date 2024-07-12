using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GeoAutoRunner
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static string temp, pulse;
        public static float distance;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new AddPatientForm());
           // Application.Run(new AddFcmForm());
           Application.Run(new WelcomeScreen());
        }
    }
}
