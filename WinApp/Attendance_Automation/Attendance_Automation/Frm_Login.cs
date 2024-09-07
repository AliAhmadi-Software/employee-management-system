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
using Attendance_Automation.Classes;
using System.Security.Cryptography;
using System.Globalization;

namespace Attendance_Automation
{
    public partial class Frm_Login : Form
    {
        Attendance_DBEntities database = new Attendance_DBEntities();
        public Frm_Login()
        {
            InitializeComponent();
        }
        //----------------------------------------------------------

        private string ShamsiDate()
        {
            string today = "";
            PersianCalendar pc = new PersianCalendar();
            DateTime dt = DateTime.Now;
            today = pc.GetYear(dt).ToString("0000/") + pc.GetMonth(dt).ToString("00/") + pc.GetDayOfMonth(dt).ToString("00");
            today += " - " + dt.Hour + ":" + dt.Minute;
            return today;
        }

        //--------------------------------------------------------
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Username.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_Username, "نام کاربری را وارد نمایید");
                txt_Username.Focus();
                return;
            }
            else if (txt_Password.Text == string.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_Password, "کلمه عبور را وارد نمایید");
                txt_Password.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
                string username = txt_Username.Text.ToLower();
                //-------------------------Hashed Password--------------------//
                SHA256CryptoServiceProvider SHA256 = new SHA256CryptoServiceProvider();
                byte[] B1 = UTF8Encoding.UTF8.GetBytes(txt_Password.Text);
                byte[] B2 = SHA256.ComputeHash(B1);
                string HashedPassowrd = BitConverter.ToString(B2).Replace("-", "");
                //-------------------------------------------------------------//
                var qLogin = (from rows in database.Tbl_Users where rows.Username == username && rows.Password == HashedPassowrd select rows).FirstOrDefault();
                if(qLogin !=null)
                {
                    int Userid = qLogin.UserId;
                    MainForm.userId = Userid;
                    MainForm.roleId = qLogin.RoleID_FK;
                    //----------------------------------------------------------
                    var qPermission = (from rows in database.Tbl_Persmissions where rows.UserID_FK == Userid select rows).SingleOrDefault();
                    if(qPermission !=null)
                    {
                        UserAccess.Attendance =qPermission.Attendance;
                        UserAccess.Leaves = qPermission.Leaves;
                        UserAccess.LeavesTime = qPermission.LeavesTime;
                        UserAccess.Missions = qPermission.Mission;
                        UserAccess.Personels = qPermission.Personels;
                        UserAccess.Users = qPermission.Users;
                    }

                    qLogin.LastLogin = ShamsiDate();
                    database.SaveChanges();
                    MainForm f = new MainForm();
                    this.Hide();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("نام کاربری یا کلمه عبور اشتباه می باشد","خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txt_Password.Focus();
                    txt_Password.ResetText();
                }
            }
        }
    }
}
