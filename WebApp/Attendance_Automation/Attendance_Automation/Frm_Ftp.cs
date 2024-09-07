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
    public partial class Frm_Ftp : Form
    {
        Attendance_DBEntities database = new Attendance_DBEntities();
        public Frm_Ftp()
        {
            InitializeComponent();
        }

        private void Frm_Ftp_Load(object sender, EventArgs e)
        {
            var records = (from rows in database.Tbl_SettingApp select rows).FirstOrDefault();
            if (records != null)
            {
                txt_ExpireDateHost.Text = records.ExpireDate_Host;
                txt_FtpAddress.Text = records.FtpAddress;
                txt_FtpLoginPassword.Text = records.LoginFTP;
                txt_FtpPassword.Text = records.FtpPassword;
                txt_FtpUsername.Text = records.FtpUsername;
            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var q = database.Tbl_SettingApp.FirstOrDefault();
            if (q != null)
            {
                q.ExpireDate_Host = txt_ExpireDateHost.Text;
                q.FtpAddress = txt_FtpAddress.Text;
                q.LoginFTP = txt_FtpLoginPassword.Text.ToLower();
                q.FtpPassword = txt_FtpPassword.Text;
                q.FtpUsername = txt_FtpUsername.Text;
                database.SaveChanges();
                MessageBox.Show("اطلاعات با موفقیت ذخیره گردید","موفق",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }

        private void chk_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_showPass.Checked)
            {
                txt_FtpPassword.PasswordChar = char.Parse("\0");
            }
            else
            {
                txt_FtpPassword.PasswordChar = '*';
            }
        }

        private void chk_showPassFtpLogin_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_showPassFtpLogin.Checked)
            {
                txt_FtpLoginPassword.PasswordChar = char.Parse("\0");
            }
            else
            {
                txt_FtpLoginPassword.PasswordChar = '*';
            }
        }
    }
}
