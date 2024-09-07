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
using System.Security.Cryptography;

namespace Attendance_Automation
{
    public partial class Frm_Users : Form
    {
        Attendance_DBEntities database = new Attendance_DBEntities();
        private bool flagEdit = false;
        public Frm_Users()
        {
            InitializeComponent();
            grd_Users.AutoGenerateColumns = false;
        }

        //----------------------Methods--------------------------//

        private void ShowUsersByRoles(int roleId1, int roleId2) // roleId=1 =>Admin || roleId=2 =>User
        {
            var records = (from rows in database.Tbl_Users
                           where rows.RoleID_FK == roleId1 || rows.RoleID_FK == roleId2
                           select new
                           {
                               rows.Family,
                               rows.LastLogin,
                               rows.Name,
                               rows.RoleID_FK,
                               rows.Username,
                               rows.UserId,
                           }).ToList();

            grd_Users.DataSource = records;

        }

        private void ShowRoles()
        {
            if (MainForm.roleId == 1)
            {
                List<Tbl_Roles> list = (from rows in database.Tbl_Roles select rows).ToList();
                cmb_Access.DataSource = list;
                cmb_Access.DisplayMember = "RoleName";
                cmb_Access.ValueMember = "RoleID";
                cmb_Access.SelectedIndex = 0;
            }
            else if (MainForm.roleId == 2)
            {
                List<Tbl_Roles> list = (from rows in database.Tbl_Roles where rows.RoleID == 2 select rows).ToList();
                cmb_Access.DataSource = list;
                cmb_Access.DisplayMember = "RoleName";
                cmb_Access.ValueMember = "RoleID";
                cmb_Access.SelectedIndex = 0;
                cmb_Access.Enabled = false;
            }
        }

        private void GetAccessUser()
        {
            int? Access;
            for (int i = 0; i < grd_Users.Rows.Count; i++)
            {
                int RowId = Convert.ToInt32(grd_Users["col_userid", i].Value);
                var query = (from u in database.Tbl_Users where u.UserId == RowId select u).FirstOrDefault();
                if (query != null)
                {
                    Access = query.RoleID_FK;
                    switch (Access)
                    {
                        case 1:  // اگر مدیر بود
                            {
                                grd_Users.Rows[i].Cells["col_roleid"].Value = "مدیر";
                                break;
                            }
                        case 2: //اگر کاربر عادی بود
                            {
                                grd_Users.Rows[i].Cells["col_roleid"].Value = "کاربر عادی";
                                break;
                            }
                    }
                }
            }
        }

        private void ResetItems()
        {
            if (MainForm.roleId == 1) // for admin
            {
                txt_Family.Text = string.Empty;
                txt_Name.Text = string.Empty;
                txt_Pass.Text = string.Empty;
                txt_Pass2.Text = string.Empty;
                txt_Username.Text = string.Empty;
                chk_Attendance.Checked = false;
                chk_Leaves.Checked = false;
                chk_LeavesTime.Checked = false;
                chk_Missions.Checked = false;
                chk_Personels.Checked = false;
                chk_Users.Checked = false;
                cmb_Access.Enabled = true;
                cmb_Access.SelectedIndex = 0;
                if (flagEdit == true)
                {
                    btn_AddUser.Enabled = true;
                    btn_EditFinal.Enabled = false;
                    btn_Cancel.Text = "بستن";
                    txt_Username.Enabled = true;
                    flagEdit = false;
                }


            }
            else if (MainForm.roleId == 2) // for user
            {
                txt_Family.Text = string.Empty;
                txt_Name.Text = string.Empty;
                txt_Pass.Text = string.Empty;
                txt_Pass2.Text = string.Empty;
                txt_Username.Text = string.Empty;
                chk_Attendance.Checked = false;
                chk_Leaves.Checked = false;
                chk_LeavesTime.Checked = false;
                chk_Missions.Checked = false;
                chk_Personels.Checked = false;
                chk_Users.Checked = false;
                if (flagEdit == true)
                {
                    btn_AddUser.Enabled = true;
                    btn_EditFinal.Enabled = false;
                    btn_Cancel.Text = "بستن";
                    txt_Username.Enabled = true;
                    flagEdit = false;
                }
            }
        }
        //----------------------End Methods----------------------//
        private void Frm_Users_Load(object sender, EventArgs e)
        {
            ShowRoles();
            if (MainForm.roleId == 1) // for admin
            {
                ShowUsersByRoles(1, 2); // نمایش تمامی مدیران و کاربران عادی
            }
            else if (MainForm.roleId == 2)  // for user
            {
                ShowUsersByRoles(2, 2); // فقط نمایش کاربران
                ctm_delete.Visible = false;
            }
            GetAccessUser();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (flagEdit == true)
            {
                ResetItems();
            }
            else
                this.Close();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Username.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_Username, "نام کاربری را وارد نمایید");
                txt_Username.Focus();
                return;
            }
            else if (txt_Pass.Text == string.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_Pass, "کلمه عبور را وارد نمایید");
                txt_Pass.Focus();
                return;
            }
            else if (txt_Pass2.Text != txt_Pass.Text)
            {
                errorProvider1.Clear();
                MessageBox.Show("تکرار کلمه عبور با هم مطابقت ندارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Pass2.ResetText();
                txt_Pass.ResetText();
                txt_Pass.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txt_Name.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_Name, "نام  را وارد نمایید");
                txt_Name.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txt_Family.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_Family, "نام خانوادگی را وارد نمایید");
                txt_Family.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
                //--------------------------Hashing Password---------------------------------//
                SHA256CryptoServiceProvider SHA256 = new SHA256CryptoServiceProvider();
                byte[] b1 = UTF8Encoding.UTF8.GetBytes(txt_Pass.Text);
                byte[] b2 = SHA256.ComputeHash(b1);
                string HashedPassword = BitConverter.ToString(b2).Replace("-", "");
                //---------------------------------------------------------------------------//
                if (MainForm.roleId == 1) // for admin
                {
                    Tbl_Users table_user = new Tbl_Users()
                    {
                        Family = txt_Family.Text,
                        Name = txt_Name.Text,
                        Password = HashedPassword,
                        RoleID_FK = Convert.ToInt32(cmb_Access.SelectedValue),
                        Username = txt_Username.Text.ToLower(),
                    };
                    database.Tbl_Users.Add(table_user);

                    database.Tbl_Persmissions.Add(new Tbl_Persmissions()
                    {
                        UserID_FK = table_user.UserId,
                        Attendance = chk_Attendance.Checked,
                        Leaves = chk_Leaves.Checked,
                        LeavesTime = chk_LeavesTime.Checked,
                        Mission = chk_Missions.Checked,
                        Personels = chk_Personels.Checked,
                        Users = chk_Users.Checked,
                    });
                }
                else if (MainForm.roleId == 2) // for user
                {
                    Tbl_Users table_user = new Tbl_Users()
                    {
                        Family = txt_Family.Text,
                        Name = txt_Name.Text,
                        Password = HashedPassword,
                        RoleID_FK = 2, // یعنی کاربر عادی
                        Username = txt_Username.Text.ToLower(),
                    };
                    database.Tbl_Users.Add(table_user);

                    database.Tbl_Persmissions.Add(new Tbl_Persmissions()
                    {
                        UserID_FK = table_user.UserId,
                        Attendance = chk_Attendance.Checked,
                        Leaves = chk_Leaves.Checked,
                        LeavesTime = chk_LeavesTime.Checked,
                        Mission = chk_Missions.Checked,
                        Personels = chk_Personels.Checked,
                        Users = chk_Users.Checked,
                    });
                }

                if (Convert.ToBoolean(database.SaveChanges()))
                {
                    MessageBox.Show("کاربر با موفقیت ذخیره گردید", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MainForm.roleId == 1) // for admin
                    {
                        ShowUsersByRoles(1, 2); // نمایش تمامی مدیران و کاربران عادی
                    }
                    else if (MainForm.roleId == 2)  // for user
                    {
                        ShowUsersByRoles(2, 2); // فقط نمایش کاربران
                    }
                }

            }
            ResetItems();
            GetAccessUser();
        }

        private void txt_Username_Leave(object sender, EventArgs e)
        {
            if (flagEdit == false)
            {
                string username = txt_Username.Text;
                var qCheckUsername = (from rows in database.Tbl_Users where rows.Username == username select rows).Any();
                if (qCheckUsername == true)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txt_Username, "نام کاربری تکراری است");
                    MessageBox.Show("نام کاربری وارد شده از قبل در سیستم وجود دارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Username.Focus();
                    txt_Username.SelectAll();
                    btn_AddUser.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    btn_AddUser.Enabled = true;
                }
            }

        }

        private void ctm_delete_Click(object sender, EventArgs e)
        {
            if (grd_Users.SelectedRows.Count == 0)
            {
                return;
            }
            else if (grd_Users.Rows.Count == 1)
            {
                MessageBox.Show("حداقل یک کاربر باید برای سیستم وجود داشته باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else
            {
                int userId = 0;
                int.TryParse(grd_Users.CurrentRow.Cells["col_userid"].Value.ToString(), out userId);
                var Selected = (from rows in database.Tbl_Users where rows.UserId == userId select rows).SingleOrDefault();
                if (Selected != null)
                {
                    DialogResult dr;
                    dr = MessageBox.Show("ایا میخواهید کاربر : " + Selected.Name + " " + Selected.Family + " را حذف نمایید", "حذف کاربر", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        var qPermissions = (from rows in database.Tbl_Persmissions
                                            where rows.UserID_FK == userId
                                            select rows).FirstOrDefault();

                        if (qPermissions != null)
                        {
                            database.Tbl_Persmissions.Remove(qPermissions);
                            database.Tbl_Users.Remove(Selected);
                            if (Convert.ToBoolean(database.SaveChanges()))
                            {
                                MessageBox.Show("کاربر با موفقیت حذف گردید", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (MainForm.roleId == 1) // for admin
                                {
                                    ShowUsersByRoles(1, 2); // نمایش تمامی کاربران عادی و مدیران
                                }
                                else if (MainForm.roleId == 2) //for user
                                {
                                    ShowUsersByRoles(2, 2);
                                }

                            }
                        }
                    }
                }
            }

            GetAccessUser();
        }

        private void ctm_edit_Click(object sender, EventArgs e)
        {
            if (grd_Users.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                int userId = 0;
                int.TryParse(grd_Users.CurrentRow.Cells["col_userid"].Value.ToString(), out userId);
                var Selected = (from rows in database.Tbl_Users where rows.UserId == userId select rows).SingleOrDefault();
                if (Selected != null)
                {
                    cmb_Access.SelectedValue = Selected.RoleID_FK;
                    txt_Username.Text = Selected.Username;
                    txt_Family.Text = Selected.Family;
                    txt_Name.Text = Selected.Name;
                    lbl_userid.Text = userId.ToString();
                    //----------------Show Access User Persmissions -------------------------------
                    var q = (from rows in database.Tbl_Persmissions where rows.UserID_FK == userId select rows).FirstOrDefault();
                    chk_Attendance.Checked = (bool)q.Attendance;
                    chk_Leaves.Checked = (bool)q.Leaves;
                    chk_LeavesTime.Checked = (bool)q.LeavesTime;
                    chk_Missions.Checked = (bool)q.Mission;
                    chk_Personels.Checked = (bool)q.Personels;
                    chk_Users.Checked = (bool)q.Users;
                    //-----------------------------------------------------
                    btn_AddUser.Enabled = false;
                    btn_Cancel.Text = "انصراف";
                    btn_EditFinal.Enabled = true;
                    txt_Username.Enabled = false;
                    flagEdit = true;
                }
            }
        }

        private void btn_EditFinal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Name.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_Name, "نام  را وارد نمایید");
                txt_Name.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_Family.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_Family, "نام خانوادگی را وارد نمایید");
                txt_Family.Focus();
                return;
            }
            if (txt_Pass.Text != string.Empty)   // ویرایش اطلاعات کاربری [به همراه تغییر] رمز عبور
            {
                int userid = Convert.ToInt32(lbl_userid.Text);
                var qUser = (from u in database.Tbl_Users where u.UserId == userid select u).SingleOrDefault();
                if (qUser != null)
                {
                    var qPermissions = (from rows in database.Tbl_Persmissions
                                        where rows.UserID_FK == userid
                                        select rows).FirstOrDefault();
                    //-------------------------------------------------------------
                    if (txt_Pass2.Text != txt_Pass.Text)
                    {
                        errorProvider1.Clear();
                        MessageBox.Show("تکرار کلمه عبور با هم مطابقت ندارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_Pass.Focus();
                        txt_Pass.SelectAll();
                        txt_Pass2.ResetText();
                        return;
                    }
                    //--------------------------Hashing Password---------------------------------//
                    SHA256CryptoServiceProvider SHA256 = new SHA256CryptoServiceProvider();
                    byte[] b1 = UTF8Encoding.UTF8.GetBytes(txt_Pass.Text);
                    byte[] b2 = SHA256.ComputeHash(b1);
                    string HashedPassword = BitConverter.ToString(b2).Replace("-", "");
                    //---------------------------update user table--------------------------------//
                    qUser.Password = HashedPassword;
                    qUser.Name = txt_Name.Text;
                    qUser.Family = txt_Family.Text;
                    qUser.RoleID_FK = Convert.ToInt32(cmb_Access.SelectedValue);
                    //--------------------Update Permssion Table --------------------------
                    qPermissions.Attendance = chk_Attendance.Checked;
                    qPermissions.Leaves = chk_Leaves.Checked;
                    qPermissions.LeavesTime = chk_LeavesTime.Checked;
                    qPermissions.Mission = chk_Missions.Checked;
                    qPermissions.Personels = chk_Personels.Checked;
                    qPermissions.Users = chk_Users.Checked;
                    database.SaveChanges();
                    MessageBox.Show("اطلاعات  کاربر به همراه تغییر رمز عبور با موفقیت به روز رسانی گردید", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MainForm.roleId == 1)
                    {
                        ShowUsersByRoles(1, 2);
                    }
                    else if (MainForm.roleId == 2)
                    {
                        ShowUsersByRoles(2, 2);
                    }
                    GetAccessUser();
                    ShowRoles();
                    ResetItems();
                }
            }
            else  // ویرایش اطلاعات کاربری [بدون تغییر] رمز عبور
            {
                int userid = Convert.ToInt32(lbl_userid.Text);
                var qUser = (from u in database.Tbl_Users where u.UserId == userid select u).SingleOrDefault();
                if (qUser != null)
                {
                    var qPermissions = (from rows in database.Tbl_Persmissions
                                        where rows.UserID_FK == userid
                                        select rows).FirstOrDefault();
                    //-------------------------------------------------------------
                    qUser.Name = txt_Name.Text;
                    qUser.Family = txt_Family.Text;
                    qUser.RoleID_FK = Convert.ToInt32(cmb_Access.SelectedValue);
                    //--------------------Update Permssion Table --------------------------
                    qPermissions.Attendance = chk_Attendance.Checked;
                    qPermissions.Leaves = chk_Leaves.Checked;
                    qPermissions.LeavesTime = chk_LeavesTime.Checked;
                    qPermissions.Mission = chk_Missions.Checked;
                    qPermissions.Personels = chk_Personels.Checked;
                    qPermissions.Users = chk_Users.Checked;
                    database.SaveChanges();
                    MessageBox.Show("اطلاعات  کاربر بدون تغییر رمز عبور با موفقیت به روز رسانی گردید", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MainForm.roleId == 1)
                    {
                        ShowUsersByRoles(1, 2);
                    }
                    else if (MainForm.roleId == 2)
                    {
                        ShowUsersByRoles(2, 2);
                    }
                    GetAccessUser();
                    ShowRoles();
                    ResetItems();

                }
            }

        }
    }
}
