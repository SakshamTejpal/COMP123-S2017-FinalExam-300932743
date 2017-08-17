using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Saksham Tejpal
 * Date: 8/17/17
 * StudentID: 300932743
 * Description: Splash Form to show prior to actual application
 * Version: 0.4-Designed Splash Form
 */

namespace COMP123_S2017_FinalExam_300932743
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            

        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            PickHighestCardForm pickHighestCardForm = new PickHighestCardForm();
            pickHighestCardForm.Show();
            this.Hide();
            SplashFormTimer.Enabled = false;
        }
    }
}
