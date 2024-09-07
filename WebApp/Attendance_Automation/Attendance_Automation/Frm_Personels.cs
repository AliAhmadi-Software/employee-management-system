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
using System.Net;

namespace Attendance_Automation
{
    public partial class Frm_Personels : Frm_Template
    {
        Attendance_DBEntities database = new Attendance_DBEntities();
        public string personelImage = "";
        public string personelImagePath = "";

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
                personelImagePath = "";
                picbox_personel.Image = null;
                btn_AddPersonel.Enabled = true;
                btn_EditFinal.Enabled = false;
                btn_Cancel.Text = "بستن";
                txt_PersonelId.ReadOnly = false;
                flagEdit = false;
                openFileDialog1.FileName = "";
            }
            else  // حالت ثبت اطلاعات
            {
                txt_Family.ResetText();
                txt_Mobile.ResetText();
                txt_Name.ResetText();
                txt_PersonelId.ResetText();
                txt_Post.ResetText();
                personelImage = "";
                personelImagePath = "";
                picbox_personel.Image = null;
                openFileDialog1.FileName = "";
            }
        }

        private void Show_Personels()
        {
            var records = (from rows in database.Tbl_Personels select rows).ToList();
            grd_Personels.DataSource = records;
        }

        private bool Upload(string ftpServer, string userName, string password, string filename)
        {

            bool fileUploaded = false;
            string reply = "Success";
            try
            {
                using (System.Net.WebClient client = new System.Net.WebClient()) //System.Net.WebClient client = new System.Net.WebClient()
                {
                    client.Credentials = new System.Net.NetworkCredential(userName, password);
                    client.Proxy = new WebProxy();
                    FileInfo fi = new FileInfo(filename);
                    client.UploadFile(ftpServer + "//" + fi.Name, "STOR", filename);
                    fileUploaded = true;
                }
            }
            catch (Exception ex)
            {
                reply = ex.Message;
                fileUploaded = false;
            }
            return fileUploaded;
        }

        private bool CheckIfFileExistsOnServer(string fileName)
        {
            var qSettingApp = database.Tbl_SettingApp.FirstOrDefault();
            string ftpServer = qSettingApp.FtpAddress + "httpdocs/Attendance_Automation/Personel_Images/";

            var request = (FtpWebRequest)WebRequest.Create(ftpServer + fileName);
            request.Credentials = new NetworkCredential(qSettingApp.FtpUsername, qSettingApp.FtpPassword);
            request.Method = WebRequestMethods.Ftp.GetFileSize;

            try
            {
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                return true;
            }
            catch (WebException ex)
            {
                FtpWebResponse response = (FtpWebResponse)ex.Response;
                if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                    return false;
            }
            return false;
        }

        public bool DeleteFileOnFtpServer(Uri serverUri, string ftpUsername, string ftpPassword)
        {
            try
            {
                // The serverUri parameter should use the ftp:// scheme.
                // It contains the name of the server file that is to be deleted.
                // Example: ftp://contoso.com/someFile.txt.
                // 

                if (serverUri.Scheme != Uri.UriSchemeFtp)
                {
                    return false;
                }
                // Get the object used to communicate with the server.
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(serverUri);
                request.Credentials = new NetworkCredential(ftpUsername, ftpPassword);
                request.Method = WebRequestMethods.Ftp.DeleteFile;

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                //Console.WriteLine("Delete status: {0}", response.StatusDescription);
                response.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public byte[] GetImgByte(string ftpFilePath)
        {
            var qSettingApp = database.Tbl_SettingApp.FirstOrDefault();

            WebClient ftpClient = new WebClient();
            ftpClient.Credentials = new NetworkCredential(qSettingApp.FtpUsername, qSettingApp.FtpPassword);
            byte[] imageByte = ftpClient.DownloadData(ftpFilePath);
            return imageByte;

        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;

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
            else if (picbox_personel.ImageLocation == null || picbox_personel.ImageLocation == "" || picbox_personel.Image == null)
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


                //-----------------------Upload  Personel Image in FTP----------------------//
                var qSettingApp = database.Tbl_SettingApp.FirstOrDefault();
                string ftpServer = qSettingApp.FtpAddress + "httpdocs/Attendance_Automation/Personel_Images";
                if (Upload(ftpServer, qSettingApp.FtpUsername, qSettingApp.FtpPassword, personelImagePath) == true)
                {
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
                else
                {
                    MessageBox.Show("خطایی در اپلود عکس کارمند به وجود امده لطفا مجددا امتحان نمایید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //--------------------------------------------------------------------------//


                //if (Directory.Exists(Application.StartupPath + @"\personel_images"))
                //{
                //    if (picbox_personel.Image != null)
                //        File.Copy(picbox_personel.ImageLocation, Application.StartupPath + @"\personel_images\" + personelImage);
                //}
                //else
                //{
                //    Directory.CreateDirectory(Application.StartupPath + @"\personel_images");
                //    File.Copy(picbox_personel.ImageLocation, Application.StartupPath + @"\personel_images\" + personelImage);
                //}


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
                personelImage = openFileDialog1.SafeFileName.ToLower(); // for save to db
                personelImagePath = openFileDialog1.FileName; // for upload

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
                    //  picbox_personel.ImageLocation = Application.StartupPath + @"\personel_images\" + Selected.Personel_Image;
                    //-------------------------Get Perosnel Image From FTP---------------------//
                    var qSettingApp = database.Tbl_SettingApp.FirstOrDefault();
                    string ftpServer = qSettingApp.FtpAddress + "httpdocs/Attendance_Automation/Personel_Images/" + Selected.Personel_Image;
                    if (CheckIfFileExistsOnServer(Selected.Personel_Image))
                    {
                        picbox_personel.Image = ByteToImage(GetImgByte(ftpServer));
                    }
                    //-------------------------------------------------------------------------//

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
                    string oldPersonelImage = Update_Query.Personel_Image;
                    Update_Query.Name = txt_Name.Text;
                    Update_Query.Family = txt_Family.Text;
                    Update_Query.Mobile = txt_Mobile.Text;
                    Update_Query.Post = txt_Post.Text;


                    //-----------------------------------------
                    var qSettingApp = database.Tbl_SettingApp.FirstOrDefault();
                    if (openFileDialog1.FileName != null && openFileDialog1.FileName != "")
                    {
                        if (CheckIfFileExistsOnServer(Update_Query.Personel_Image))
                        {
                        
                            string serverUri = qSettingApp.FtpAddress + "httpdocs/Attendance_Automation/Personel_Images/" + Update_Query.Personel_Image;

                            if (DeleteFileOnFtpServer(new Uri(serverUri), qSettingApp.FtpUsername, qSettingApp.FtpPassword) == true)
                            {
                                string ftpServer = qSettingApp.FtpAddress + "httpdocs/Attendance_Automation/Personel_Images";
                                if (Upload(ftpServer, qSettingApp.FtpUsername, qSettingApp.FtpPassword, personelImagePath) == true)
                                {
                                    Update_Query.Personel_Image = openFileDialog1.SafeFileName;
                                }
                                else
                                {
                                    MessageBox.Show("در اپلود عکس کارمند مکشلی پیش آمده ، لطفا دوباره امتحان کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                            }
                        }
                        else
                        {
                            string ftpServer = qSettingApp.FtpAddress + "httpdocs/Attendance_Automation/Personel_Images";
                            if (Upload(ftpServer, qSettingApp.FtpUsername, qSettingApp.FtpPassword, personelImagePath) == true)
                            {
                                Update_Query.Personel_Image = openFileDialog1.SafeFileName;
                            }
                            else
                            {
                                MessageBox.Show("در اپلود عکس کارمند مکشلی پیش آمده ، لطفا دوباره امتحان کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);                               
                                return;
                            }
                        }


                        //if (Directory.Exists(Application.StartupPath + @"\personel_images"))
                        //{
                        //    picbox_personel.ImageLocation = openFileDialog1.FileName;
                        //    Update_Query.Personel_Image = personelImage;
                        //    File.Copy(picbox_personel.ImageLocation, Application.StartupPath + @"\personel_images\" + personelImage);
                        //}
                        //else
                        //{
                        //    Directory.CreateDirectory(Application.StartupPath + @"\personel_images");
                        //    picbox_personel.ImageLocation = openFileDialog1.FileName;
                        //    Update_Query.Personel_Image = personelImage;
                        //    File.Copy(picbox_personel.ImageLocation, Application.StartupPath + @"\personel_images\" + personelImage);
                        //}
                    }
                    else
                    {
                        Update_Query.Personel_Image = oldPersonelImage;
                    }

                }
                database.SaveChanges();
                MessageBox.Show("اطلاعات کارمند با موفقیت ویرایش گردید", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset_Items();
                Show_Personels();
               openFileDialog1.FileName = "";
            }
        }

        private void txt_PersonelId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
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

        private void ctm_delete_Click(object sender, EventArgs e)
        {
            if (grd_Personels.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                int personelId;
                int.TryParse(grd_Personels.CurrentRow.Cells["col_personelid"].Value.ToString(), out personelId);
                var Selected = (from rows in database.Tbl_Personels where rows.PersonelID == personelId select rows).SingleOrDefault();
                if (Selected != null)
                {
                    DialogResult dr;
                    dr = MessageBox.Show("ایا میخواهید این کارمند را حذف نمایید؟\n" + "در صورت حذف کارمند تمامی اطلاعات مربوط به مرخصی ها- ماموریت ها و ورود و خروج حذف خواهد شد ، ایا ادامه میدهید؟", "حذف کارمند", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        //------------------Remove Attendance Personels---------------------//
                        List<Tbl_Attendance> qAttendance = (from rows in database.Tbl_Attendance where rows.PersonelID_FK == personelId select rows).ToList();
                        if (qAttendance != null)
                        {
                            database.Tbl_Attendance.RemoveRange(qAttendance.AsEnumerable());
                        }
                        //####################################################################
                        //------------------Remove Leaves Personels---------------------//
                        List<Tbl_Leaves> qLeaves = (from rows in database.Tbl_Leaves where rows.PersonelID_FK == personelId select rows).ToList();
                        if (qLeaves != null)
                        {
                            database.Tbl_Leaves.RemoveRange(qLeaves.AsEnumerable());
                        }
                        //####################################################################

                        //------------------Remove LeavesTime Personels---------------------//
                        List<Tbl_LeavesTime> qLeavesTime = (from rows in database.Tbl_LeavesTime where rows.PersonelID_FK == personelId select rows).ToList();
                        if (qLeavesTime != null)
                        {
                            database.Tbl_LeavesTime.RemoveRange(qLeavesTime.AsEnumerable());
                        }

                        //####################################################################

                        //------------------Remove Report Missions Personels---------------------//
                        List<Tbl_ReportMission> qReportMission = (from rows in database.Tbl_ReportMission where rows.PersonelID_FK == personelId select rows).ToList();
                        if (qReportMission != null)
                        {
                            database.Tbl_ReportMission.RemoveRange(qReportMission.AsEnumerable());
                        }

                        //####################################################################

                        //------------------Remove Missions Personels---------------------//
                        List<Tbl_Missions> qMission = (from rows in database.Tbl_Missions where rows.PersonelID_FK == personelId select rows).ToList();
                        if (qMission != null)
                        {
                            database.Tbl_Missions.RemoveRange(qMission.AsEnumerable());
                        }
                        //####################################################################
                        if (CheckIfFileExistsOnServer(Selected.Personel_Image))
                        {
                            database.Tbl_Personels.Remove(Selected);
                            var qSettingApp = database.Tbl_SettingApp.FirstOrDefault();
                            string serverUri = qSettingApp.FtpAddress + "httpdocs/Attendance_Automation/Personel_Images/" + Selected.Personel_Image;
                            if (DeleteFileOnFtpServer(new Uri(serverUri), qSettingApp.FtpUsername, qSettingApp.FtpPassword) == true)
                            {

                                if (Convert.ToBoolean(database.SaveChanges()))
                                {

                                    MessageBox.Show("کارمند با موفقیت حذف گردید", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Show_Personels();
                                    personelImage = "";
                                    personelImagePath = "";
                                }
                            }
                            else
                            {
                                MessageBox.Show("خطایی در حذف عکس کارمند به وجود امده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        else
                        {
                            database.Tbl_Personels.Remove(Selected);
                            if (Convert.ToBoolean(database.SaveChanges()))
                            {

                                MessageBox.Show("کارمند با موفقیت حذف گردید", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Show_Personels();
                                personelImage = "";
                                personelImagePath = "";
                            }
                        }

                        

                    }
                }

            }
        }
    }
}
