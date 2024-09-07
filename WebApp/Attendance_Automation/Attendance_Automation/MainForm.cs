using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Attendance_Automation.Model;
using Attendance_Automation.Classes;

namespace Attendance_Automation
{
    public partial class MainForm : Form
    {
        Attendance_DBEntities database = new Attendance_DBEntities();
        public static int userId;
        public static int? roleId;
        public MainForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        private void getCountPersonelLeaves()
        {
            string today = ShamsiDate();
            int q = (from rows in database.Tbl_Leaves where rows.Date_Submit == today select rows).Count();
            lbl_cntLeaves.Text = q + " " + "نفر";
        }
        private void getCountPersonelLeavesHourTime()
        {
            string today = ShamsiDate();
            int q = (from rows in database.Tbl_LeavesTime where rows.LeaveDate == today select rows).Count();
            lbl_cntHourLeaves.Text = q + " " + "نفر";
        }
        private void getCountPersonelMission()
        {
            string today = ShamsiDate();
            int q = (from rows in database.Tbl_Missions where rows.Date_Mission == today select rows).Count();
            lbl_cntMission.Text = q + " " + "نفر";
        }

        private string ShamsiDate()
        {
            string today = "";
            PersianCalendar pc = new PersianCalendar();
            DateTime dt = DateTime.Now;
            today = pc.GetYear(dt).ToString("0000/") + pc.GetMonth(dt).ToString("00/") + pc.GetDayOfMonth(dt).ToString("00");
            return today;
        }

        private void SetAccessLevel()
        {
            btn_Attendance.Visible = (bool)UserAccess.Attendance;
            btn_Leaves.Visible = (bool)UserAccess.Leaves;
            btn_LeavesTime.Visible = (bool)UserAccess.LeavesTime;
            btn_ManagePersonels.Visible = (bool)UserAccess.Personels;
            btn_Missions.Visible = (bool)UserAccess.Missions;
            btn_ManageUsers.Visible = (bool)UserAccess.Users;
            if (roleId == 2)
            {
                btn_ManageFtp.Visible = false;
            }
        }

        private void getDayOfWeek()
        {
            DateTime dt = DateTime.Now.Date;
            if (dt.DayOfWeek == DayOfWeek.Saturday)
                lbl_dayOfWeek.Text = "شنبه";
            else if (dt.DayOfWeek == DayOfWeek.Sunday)
                lbl_dayOfWeek.Text = "یک شنبه";
            if (dt.DayOfWeek == DayOfWeek.Monday)
                lbl_dayOfWeek.Text = "دوشنبه";
            if (dt.DayOfWeek == DayOfWeek.Tuesday)
                lbl_dayOfWeek.Text = "سه شنبه";
            if (dt.DayOfWeek == DayOfWeek.Wednesday)
                lbl_dayOfWeek.Text = "چهارشنبه";
            if (dt.DayOfWeek == DayOfWeek.Thursday)
                lbl_dayOfWeek.Text = "پنج شنبه";
            if (dt.DayOfWeek == DayOfWeek.Friday)
                lbl_dayOfWeek.Text = "جمعه";
        }





        private void MainForm_Load(object sender, EventArgs e)
        {
            lbl_today.Text = ShamsiDate();
            getDayOfWeek();
            SetAccessLevel();
            //----------------------------------

            int CurrentUserId = userId;
            string currentUserInfo = "";
            var qUserInfo = (from rows in database.Tbl_Users where rows.UserId == CurrentUserId select rows).SingleOrDefault();
            if (qUserInfo != null)
            {
                if (roleId == 1) // for admin
                {
                    currentUserInfo = $" خوش آمدید  {qUserInfo.Name + " " + qUserInfo.Family} | سطح دسترسی : مدیر ";
                    lbl_currentUser.Text = currentUserInfo;
                }
                else if (roleId == 2) // for user
                {
                    currentUserInfo = $" خوش آمدید  {qUserInfo.Name + " " + qUserInfo.Family} | سطح دسترسی : کاربر عادی ";
                    lbl_currentUser.Text = currentUserInfo;

                }
                lbl_lastLogin.Text = qUserInfo.LastLogin;
            }


        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbl_time.Text = dt.Hour.ToString("00:") + dt.Minute.ToString("00:") + dt.Second.ToString("00");
        }

        private void btn_ManageUsers_Click(object sender, EventArgs e)
        {
            new Frm_Users().ShowDialog();
        }

        private void btn_ManagePersonels_Click(object sender, EventArgs e)
        {
            new Frm_Personels().ShowDialog();
        }

        private void btn_Missions_Click(object sender, EventArgs e)
        {
            new Frm_Missions().ShowDialog();
        }

        private void btn_Leaves_Click(object sender, EventArgs e)
        {
            new Frm_Leaves().ShowDialog();
        }

        private void btn_LeavesTime_Click(object sender, EventArgs e)
        {
            new Frm_LeavesTime().ShowDialog();
        }

        private void btn_Attendance_Click(object sender, EventArgs e)
        {
            new Frm_Attendance().ShowDialog();
        }

        private void btn_BackupDb_Click(object sender, EventArgs e)
        {
            new Frm_Backup().ShowDialog();
        }

        private void btn_Optimization_Click(object sender, EventArgs e)
        {
            new Frm_OptimizeDatabase().ShowDialog();
        }

        private void btn_ManageFtp_Click(object sender, EventArgs e)
        {
            new Frm_LoginFTP().ShowDialog();
        }

        private void btn_ManageHost_Click(object sender, EventArgs e)
        {
            new Frm_Host().ShowDialog();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            getCountPersonelLeaves();
            getCountPersonelLeavesHourTime();
            getCountPersonelMission();
        }

        private void btn_AppExit_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("آیا میخواهید از نرم افزار خارج شوید؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
