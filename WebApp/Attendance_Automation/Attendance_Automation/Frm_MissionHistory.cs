using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stimulsoft.Report;
using Stimulsoft.Base;
using Attendance_Automation.Model;
using System.Globalization;
using System.Threading;
using System.IO;

namespace Attendance_Automation
{
    public partial class Frm_MissionHistory : Form
    {
        Attendance_DBEntities db = new Attendance_DBEntities();
        public string strFromDate;
        public string strUntilDate;
        public int intPersonelID;
        public Frm_MissionHistory()
        {
            InitializeComponent();
            grd_MissionHistory.AutoGenerateColumns = false;
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
        private void printMission(StiReport report)
        {

           
                var query = db.Tbl_Missions.SqlQuery("SELECT * FROM Tbl_Missions WHERE PersonelID_FK=@p0 AND Date_Mission >=@p1 AND Date_Mission <=@p2", intPersonelID, strFromDate, strUntilDate).ToList();
                report.RegData("reportMissions", query);
           


        }
        private void btn_Report_Click(object sender, EventArgs e)
        {
          
            lbl_waiting.Visible = true;
            
            var qUserInfo = (from rows in db.Tbl_Personels where rows.PersonelID == intPersonelID select rows).FirstOrDefault();
            report.Load(Application.StartupPath + @"\report\Report_Missions.mrt");
            printMission(report);
            report.Dictionary.Variables["varDateMission"].Value = "گزارش ماموریت از تاریخ : " + strFromDate + " تا " + strUntilDate;
            report.Dictionary.Variables["varPersonelID"].Value = intPersonelID.ToString();
            report.Dictionary.Variables["varPersonelName"].Value = qUserInfo.Name + " " + qUserInfo.Family;
            report.Dictionary.Variables["varJobSide"].Value = qUserInfo.Post;
            report.Dictionary.Variables["varPrintDate"].Value = ShamsiDate();
            report.Compile();
            report.Show();
            Application.DoEvents();
            lbl_waiting.Visible = false;
        }

    }
}















