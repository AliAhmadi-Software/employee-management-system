using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Automation
{
    public partial class Frm_SplashScreen : Form
    {
        public Frm_SplashScreen()
        {
            InitializeComponent();
        }

       
        private void Frm_SplashScreen_Load(object sender, EventArgs e)
        {
           
        }
        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter == 100)
            {
                counter = 0;
            }
            circularProgress1.Value = counter;
            counter++;
        }
    }
}
