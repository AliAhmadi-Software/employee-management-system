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
    public partial class Frm_LoginFTP : Form
    {
        Attendance_DBEntities database = new Attendance_DBEntities();
        public Frm_LoginFTP()
        {
            InitializeComponent();
        }

        private void btn_loginFtp_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_FtpLoginPassword.Text))
            {
                errorProvider1.SetError(txt_FtpLoginPassword, "مقدار الزامی است");
                txt_FtpLoginPassword.Focus();
                return;
            }

            string loginFtpPass = txt_FtpLoginPassword.Text.ToLower();
            var qLoginFtp = (from rows in database.Tbl_SettingApp where rows.LoginFTP == loginFtpPass select rows).FirstOrDefault();
            if(qLoginFtp !=null)
            {
                this.Hide();
                new Frm_Ftp().ShowDialog();
            }
            else
            {
                errorProvider1.Clear();
                MessageBox.Show("لطفا کلید دسترسی را صحیح وارد نمایید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_FtpLoginPassword.Focus();
                txt_FtpLoginPassword.ResetText();

            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
