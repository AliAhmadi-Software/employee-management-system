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
    public partial class Frm_OptimizeDatabase : Form
    {
        public Frm_OptimizeDatabase()
        {
            InitializeComponent();
        }

        private void btn_Mission_Click(object sender, EventArgs e)
        {
            new Frm_OptimizeMission().ShowDialog();
        }

        private void btn_Leaves_Click(object sender, EventArgs e)
        {
            new Frm_OptimizeLeaves().ShowDialog();
        }

        private void btn_Attendance_Click(object sender, EventArgs e)
        {
            new Frm_OptimizeAttendance().ShowDialog();
        }

        private void btn_LeavesTime_Click(object sender, EventArgs e)
        {
            new Frm_OptimizeLeavesTime().ShowDialog();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
