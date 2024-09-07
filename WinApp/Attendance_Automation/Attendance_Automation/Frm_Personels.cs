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
using System.IO;

namespace Attendance_Automation
{
    public partial class Frm_Personels : Frm_Template
    {
        Attendance_DBEntities database = new Attendance_DBEntities();
        public string personelImage = "";
        public bool flagEdit = false;

        //---------------------------------Methods--------------------------//
        private void Reset_Items()
        {
            if (flagEdit == true) //  حالت ویرایش اطلاعات
            {
                txt_Family.ResetText();
                txt_Mobile.ResetText();
                txt_Name.ResetText();
                txt_PersonelId.ResetText();
                txt_Post.ResetText();
                personelImage = "";
                picbox_personel.Image = null;
                btn_AddPersonel.Enabled = true;
                btn_EditFinal.Enabled = false;
                btn_Cancel.Text = "بستن";
                txt_PersonelId.ReadOnly = false;
                flagEdit = false;
            }
            else  // حالت ثبت اطلاعات
            {
                txt_Family.ResetText();
                txt_Mobile.ResetText();
                txt_Name.ResetText();
                txt_PersonelId.ResetText();
                txt_Post.ResetText();
                personelImage = "";
                picbox_personel.Image = null;
            }
        }

        private void Show_Personels()
        {
            var records = (from rows in database.Tbl_Personels select rows).ToList();
            grd_Personels.DataSource = records;
        }
        //---------------------------------End Methods----------------------//
        public Frm_Personels()
        {
            InitializeComponent();
            grd_Personels.AutoGenerateColumns = false;
        }

        private void btn_AddPersonel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_PersonelId.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_PersonelId, "کد پرسنلی کارمند را وارد نمایید");
                txt_PersonelId.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txt_Name.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_Name, "نام کارمند را وارد نمایید");
                txt_Name.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txt_Family.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_Family, "نام خانوادگی کارمند را وارد نمایید");
                txt_Family.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txt_Post.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_Post, "سمت شغلی کارمند را وارد نمایید");
                txt_Post.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txt_Mobile.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_Mobile, "شماره موبایل کارمند را وارد نمایید");
                txt_Mobile.Focus();
                return;
            }
            else if (picbox_personel.ImageLocation == null || picbox_personel.ImageLocation == "" || picbox_personel.Image==null)
            {
                MessageBox.Show("لطفا یک عکس برای کارمند انتخاب نمایید", "انتخاب عکس", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                openFileDialog1.ShowDialog();
            }
            else
            {
                errorProvider1.Clear();
                database.Tbl_Personels.Add(new Tbl_Personels()
                {
                    PersonelID = Convert.ToInt32(txt_PersonelId.Text),
                    Name = txt_Name.Text,
                    Family = txt_Family.Text,
                    Post = txt_Post.Text,
                    Mobile = txt_Mobile.Text,
                    Personel_Image = personelImage,
                });

                if (Directory.Exists(Application.StartupPath + @"\personel_images"))
                {
                    if (picbox_personel.Image != null)
                        File.Copy(picbox_personel.ImageLocation, Application.StartupPath + @"\personel_images\" + personelImage);
                }
                else
                {
                    Directory.CreateDirectory(Application.StartupPath + @"\personel_images");
                    File.Copy(picbox_personel.ImageLocation, Application.StartupPath + @"\personel_images\" + personelImage);
                }
                if (Convert.ToBoolean(database.SaveChanges()))
                {
                    MessageBox.Show("کارمند با موفقیت ثبت گردید", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Show_Personels();
                    Reset_Items();
                }
                else
                {
                    MessageBox.Show("خطایی در ثبت کارمند به وجود اماده است لطفا اطلاعات را صحیح وارد نمایید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }


        }



        private void picbox_personel_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "Jpg Files(*.jpg)|*.jpg| Png Files(*.png)|*.png";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.Title = "انتخاب تصویر کارمند";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picbox_personel.ImageLocation = openFileDialog1.FileName;
                personelImage = openFileDialog1.SafeFileName.ToLower();
            }
            else if (picbox_personel.ImageLocation != "") // زمانی که عکس وجود داشت دیگه پنجره انتخاب عکس نمایش داده نشود
            {
                return;
            }
            else
            {
                MessageBox.Show("لطفا یک عکس برای کارمند انتخاب نمایید", "انتخاب عکس", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                openFileDialog1.ShowDialog();
            }
        }

        private void Frm_Personels_Load(object sender, EventArgs e)
        {
            Show_Personels();
        }

        private void grd_Personels_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            grd_Personels.Rows[e.RowIndex].Cells["col_radif"].Value = e.RowIndex + 1;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (flagEdit == true)  // حالت ویرایش بود
            {
                Reset_Items();
            }
            else
                this.Close();

        }

        private void txt_PersonelId_Leave(object sender, EventArgs e)
        {
            if (flagEdit == false)
            {
                if (!string.IsNullOrWhiteSpace(txt_PersonelId.Text))
                {
                    int personelID;
                    int.TryParse(txt_PersonelId.Text, out personelID);
                    var CheckAlreadyExsitPersonelID_Query = (from rows in database.Tbl_Personels
                                                             where
                                                             rows.PersonelID == personelID
                                                             select rows).FirstOrDefault();
                    if (CheckAlreadyExsitPersonelID_Query != null) // اگر چنین کد پرسنلی وجود داشت
                    {
                        errorProvider1.Clear();
                        btn_AddPersonel.Enabled = false;
                        MessageBox.Show("کد پرسنلی وارد شده از قبل در سیستم وجود دارد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_PersonelId.Focus();
                        txt_PersonelId.SelectAll();
                        errorProvider1.SetError(txt_PersonelId, "کد پرسنلی تکراری می باشد");

                    }
                    else
                    {
                        btn_AddPersonel.Enabled = true;
                        errorProvider1.Clear();
                    }
                }
            }
        }

        private void ctm_edit_Click(object sender, EventArgs e)
        {
            if (grd_Personels.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                int personel_id = 0;
                int.TryParse(grd_Personels.CurrentRow.Cells["col_personelid"].Value.ToString(), out personel_id);
                var Selected = (from rows in database.Tbl_Personels where rows.PersonelID == personel_id select rows).SingleOrDefault();
                if (Selected != null)
                {
                    flagEdit = true;

                    txt_PersonelId.Text = Selected.PersonelID.ToString();
                    txt_Name.Text = Selected.Name;
                    txt_Family.Text = Selected.Family;
                    txt_Mobile.Text = Selected.Mobile;
                    txt_Post.Text = Selected.Post;
                    picbox_personel.ImageLocation = Application.StartupPath + @"\personel_images\" + Selected.Personel_Image;
                    //-------------------------------------
                    txt_PersonelId.ReadOnly = true;
                    btn_AddPersonel.Enabled = false;
                    btn_Cancel.Text = "انصراف";
                    btn_EditFinal.Enabled = true;
                    txt_Name.Focus();

                }
            }
        }

        private void btn_EditFinal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Name.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_Name, "نام کارمند را وارد نمایید");
                txt_Name.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txt_Family.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_Family, "نام خانوادگی کارمند را وارد نمایید");
                txt_Family.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txt_Post.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_Post, "سمت شغلی کارمند را وارد نمایید");
                txt_Post.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txt_Mobile.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_Mobile, "شماره موبایل کارمند را وارد نمایید");
                txt_Mobile.Focus();
                return;
            }
            else if (picbox_personel.Image == null)
            {
                MessageBox.Show("لطفا یک عکس برای کارمند انتخاب نمایید", "انتخاب عکس", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                openFileDialog1.ShowDialog();
            }
            else
            {
                errorProvider1.Clear();
                int personel_id = 0;
                int.TryParse(txt_PersonelId.Text, out personel_id);
                var Update_Query = (from rows in database.Tbl_Personels where rows.PersonelID == personel_id select rows).SingleOrDefault();
                if (Update_Query != null)
                {
                   // string oldPersonelImage = Update_Query.Personel_Image;
                    Update_Query.Name = txt_Name.Text;
                    Update_Query.Family = txt_Family.Text;
                    Update_Query.Mobile = txt_Mobile.Text;
                    Update_Query.Post = txt_Post.Text;


                    //-----------------------------------------
                    if (openFileDialog1.FileName != null && openFileDialog1.FileName != "")
                    {
                        if (Directory.Exists(Application.StartupPath + @"\personel_images"))
                        {
                            picbox_personel.ImageLocation = openFileDialog1.FileName;
                            Update_Query.Personel_Image = personelImage;
                            File.Copy(picbox_personel.ImageLocation, Application.StartupPath + @"\personel_images\" + personelImage);
                        }
                        else
                        {
                            Directory.CreateDirectory(Application.StartupPath + @"\personel_images");
                            picbox_personel.ImageLocation = openFileDialog1.FileName;
                            Update_Query.Personel_Image = personelImage;
                            File.Copy(picbox_personel.ImageLocation, Application.StartupPath + @"\personel_images\" + personelImage);
                        }
                    }

                }
                database.SaveChanges();
                MessageBox.Show("اطلاعات کارمند با موفقیت ویرایش گردید", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset_Items();
                Show_Personels();
            }
        }

        private void txt_PersonelId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || e.KeyChar==(char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txt_Mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
