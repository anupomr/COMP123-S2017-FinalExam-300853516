using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Anupom Roy
 * Date: August 17,2017
 * StudentID: 300853516
 * Description:Pick Highest  card form
 * Version: 0.1 created an instance of the PickHighestCardForm object

 */

namespace COMP123_S2017_FinalExam_300853516
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
