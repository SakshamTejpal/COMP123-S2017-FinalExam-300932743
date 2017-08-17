using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name:Saksham Tejpal
 * Date:8/17/17
 * StudentID:300932743
 * Description:Driver Class
 * Version:0.1-Setup SplashForm Timer
 */

namespace COMP123_S2017_FinalExam_300932743
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
        }
    }
}
