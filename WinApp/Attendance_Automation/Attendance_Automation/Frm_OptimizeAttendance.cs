using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance_Automation.Model;

namespace Attendance_Automation
{
    public partial class Frm_OptimizeAttendance : Form
    {
        Attendance_DBEntities Entities = new Attendance_DBEntities();
        public Frm_OptimizeAttendance()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_StartOptimize_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("ایا میخواهید اطلاعات را حذف نمایید ؟؟؟", "حذف  داده ها", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string fromDate = string.Format("{0:yyyy/MM/dd}", Convert.ToDateTime(persianDate_From.Value.Year + "/" + persianDate_From.Value.Month + "/" + persianDate_From.Value.Day));
                string untilDate = string.Format("{0:yyyy/MM/dd}", Convert.ToDateTime(persianDate_Until.Value.Year + "/" + persianDate_Until.Value.Month + "/" + persianDate_Until.Value.Day));
                int sqlQuery = Entities.Database.ExecuteSqlCommand("delete from Tbl_Attendance where AttendanceDate>=@p0 AND AttendanceDate<=@p1", fromDate, untilDate);
                if (sqlQuery != 0)
                {
                    MessageBox.Show("اطلاعات با موفقیت حذف گردید", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("موردی در تاریخ انتخاب شده پیدا نشد", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}
