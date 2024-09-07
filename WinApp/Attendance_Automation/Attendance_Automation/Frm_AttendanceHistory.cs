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
using System.Globalization;
using Stimulsoft.Report;

namespace Attendance_Automation
{
    public partial class Frm_AttendanceHistory : Form
    {
        public int intPersonelID;
        public string strFromDate, strUntilDate;
        Attendance_DBEntities db = new Attendance_DBEntities();
        public Frm_AttendanceHistory()
        {
            InitializeComponent();
            grd_AttendanceHistory.AutoGenerateColumns = false;
        }
        private string ShamsiDate()
        {
            string today = "";
            PersianCalendar pc = new PersianCalendar();
            DateTime dt = DateTime.Now;
            today = pc.GetYear(dt).ToString("0000/") + pc.GetMonth(dt).ToString("00/") + pc.GetDayOfMonth(dt).ToString("00");

            return today;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        StiReport report = new StiReport();
        private void reportAttendance(StiReport report)
        {
            var query = db.Tbl_Attendance.SqlQuery("select * from Tbl_Attendance where PersonelID_FK=@p0 AND AttendanceDate>=@p1 AND AttendanceDate<=@p2", intPersonelID, strFromDate, strUntilDate).ToList();
            report.RegData("reportAttendance", query);
        }
        private void btn_Report_Click(object sender, EventArgs e)
        {
            var qUserInfo = (from rows in db.Tbl_Personels where rows.PersonelID == intPersonelID select rows).FirstOrDefault();
            report.Load(Application.StartupPath + @"\report\Report_Attendance.mrt");
            reportAttendance(report);
            report.Dictionary.Variables["varDateAttendance"].Value = "گزارش ورود و خروج از تاریخ : " + strFromDate + " تا " + strUntilDate;
            report.Dictionary.Variables["varPersonelID"].Value = intPersonelID.ToString();
            report.Dictionary.Variables["varPersonelName"].Value = qUserInfo.Name + " " + qUserInfo.Family;
            report.Dictionary.Variables["varJobSide"].Value = qUserInfo.Post;
            report.Dictionary.Variables["varPrintDate"].Value = ShamsiDate();
            report.Compile();
            report.Show();
            Application.DoEvents();
        }
    }
}
