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
 * Name: Anupom Roy
 * Date: August 17,2017
 * StudentID: 300853516
 * Description:Pick Highest  card form using windows forms and UI Controls
 * Version: 0. -  SplashScreenTimer Tick event modify
 */
namespace COMP123_S2017_FinalExam_300853516
{
    public partial class SplashForm : Form
    {
        //PUBLIC PROPERTIES
        public PickHighestCardForm pickHighestCardForm
        {
            get
            {
                return Program.pickHighestCardForm;
            }
        }
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Timer Tick Event hendelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            this.pickHighestCardForm.Show();
            this.Hide();
            SplashFormTimer.Enabled = false;//turned timer off
        }
    }
}
