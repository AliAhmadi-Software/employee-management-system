﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stimulsoft.Report;
using Stimulsoft.Report.Win;
using Attendance_Automation.Model;
using System.Globalization;



namespace Attendance_Automation
{
    public partial class Frm_LeavesHistory : Form
    {
        Attendance_DBEntities db = new Attendance_DBEntities();
        public int intPersonelID;
        public string strFromDate,strUntilDate;
        public Frm_LeavesHistory()
        {
            InitializeComponent();
            grd_LeaveHistory.AutoGenerateColumns = false;
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
        private void printLeaves(StiReport report)
        {
            var query = db.Tbl_Leaves.SqlQuery("SELECT * FROM Tbl_Leaves WHERE PersonelID_FK=@p0 AND From_Date>=@p1 AND Until_Date<=@p2", intPersonelID, strFromDate, strUntilDate).ToList();
            report.RegData("reportLeaves", query);
        }
        private void btn_Report_Click(object sender, EventArgs e)
        {
            var qUserInfo = (from rows in db.Tbl_Personels where rows.PersonelID == intPersonelID select rows).FirstOrDefault();
            report.Load(Application.StartupPath + @"\report\Report_Leaves.mrt");
            printLeaves(report);
            report.Dictionary.Variables["varDateLeaves"].Value = "گزارش مرخصی از تاریخ : " + strFromDate + " تا " + strUntilDate;
            report.Dictionary.Variables["varPersonelID"].Value = intPersonelID.ToString();
            report.Dictionary.Variables["varPersonelName"].Value = qUserInfo.Name + " " + qUserInfo.Family;
            report.Dictionary.Variables["varJobSide"].Value = qUserInfo.Post;
            report.Dictionary.Variables["varPrintDate"].Value = ShamsiDate();
            report.Compile();
            report.Show();
        }
    }
}
