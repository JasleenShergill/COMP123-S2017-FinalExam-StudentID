using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name:Jasleen
 * Date:17 August 2017
 * StudentID:300929376
 * Description:Final Project
 * Version:0.1 version creating splash formm
 */

namespace COMP123_S2017_FinalExam_StudentID
{
    public static class Program
    {
        public static PickHighestCardForm pickHighestCardForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            pickHighestCardForm = new PickHighestCardForm();
            Application.Run(new SplashForm());
        }
    }
}
