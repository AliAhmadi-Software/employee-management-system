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
using System.Globalization;
using Attendance_Automation.Classes;
using System.Net;

namespace Attendance_Automation
{
    public partial class Frm_Missions : Frm_Template
    {
        Attendance_DBEntities database = new Attendance_DBEntities();
        private bool validateFromHours = false;
        private bool validateUntilHours = false;
        private bool flagEdit = false;
        public Frm_Missions()
        {
            InitializeComponent();
            grd_Missions.AutoGenerateColumns = false;

        }
        //-----------------------------Methods-----------------------//
        private void Show_Personels()
        {
            var personelList = (from rows in database.Tbl_Personels
                                select new
                                {
                                    FullName = rows.Name + " " + rows.Family,
                                    rows.PersonelID
                                }).ToList();

            cmb_Personels.DataSource = personelList;
            cmb_Personels.DisplayMember = "FullName";
            cmb_Personels.ValueMember = "PersonelID";
            int personelID = personelList[0].PersonelID;
            txt_Personelid.Text = personelID.ToString();
            Show_Perosonel_Image(personelID);
            //-----------------------------------------------------------------------------------

            var personelListForSearch = (from rows in database.Tbl_Personels
                                         select new
                                         {
                                             FullName = rows.Name + " " + rows.Family,
                                             rows.PersonelID
                                         }).ToList();

            cmb_SearchByPersonel.DataSource = personelListForSearch;
            cmb_SearchByPersonel.DisplayMember = "FullName";
            cmb_SearchByPersonel.ValueMember = "PersonelID";

        }

        private void Reset_Items()
        {
            if (flagEdit == true)
            {
                PersianCalander_DateMission.Today_Click(null, null);
                txt_Description.ResetText();
                txt_Destination.ResetText();
                txt_FromHours.ResetText();
                txt_UnitlHours.ResetText();
                cmb_Personels.SelectedIndex = 0;
                //--------------------------------------
                btn_AddMission.Enabled = true;
                btn_Cancel.Text = "بستن";
                btn_EditFinal.Enabled = false;
                cmb_Personels.Enabled = true;
                lbl_missionId.Text = "label_mission";
                flagEdit = false;
            }
            else
            {
                PersianCalander_DateMission.Today_Click(null, null);
                txt_Description.ResetText();
                txt_Destination.ResetText();
                txt_FromHours.ResetText();
                txt_UnitlHours.ResetText();
                cmb_Personels.SelectedIndex = 0;
            }
        }

        private void Show_Missions()
        {
            var records = (from rows in database.Tbl_Missions
                           select new
                           {
                               FullName = rows.Tbl_Personels.Name + " " + rows.Tbl_Personels.Family,
                               rows.Date_Mission,
                               rows.Date_Sumbit,
                               rows.Description,
                               rows.Destination,
                               rows.From_Hours,
                               rows.Until_Hours,
                               rows.PersonelID_FK,
                               rows.MissionID,
                           }).ToList();
            grd_Missions.DataSource = records;

            var result = records.ToList();
            if (result != null)
            {
                for (int i = 0; i <= result.Count - 1; i++)
                {
                    int missionID = result[i].MissionID;
                    var qReport = (from rows in database.Tbl_ReportMission where rows.MissionID_FK == missionID select rows).ToList();
                    if (qReport.Count > 0)
                    {
                        grd_Missions.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                }
            }
        }

        private void Show_Perosonel_Image(int personelID)
        {
            var Selected = (from rows in database.Tbl_Personels where rows.PersonelID == personelID select rows).SingleOrDefault();
            if (Selected != null)
            {



                if (CheckIfFileExistsOnServer(Selected.Personel_Image))
                {
                    var qSettingApp = database.Tbl_SettingApp.FirstOrDefault();
                    string filePath = qSettingApp.FtpAddress + "httpdocs/Attendance_Automation/Personel_Images/" + Selected.Personel_Image;
                    picbox_personel.Image = ByteToImage(GetImgByte(filePath));
                }


                //txt_Personelid.Text = Selected.PersonelID.ToString();
                //if (Directory.Exists(Application.StartupPath + @"\personel_images"))
                //{
                //    if (File.Exists(Application.StartupPath + @"\personel_images\" + Selected.Personel_Image))
                //    {
                //        picbox_personel.ImageLocation = Application.StartupPath + @"\personel_images\" + Selected.Personel_Image;
                //    }
                //    else
                //    {
                //        picbox_personel.ImageLocation = null;
                //    }
                //}

            }
        }
        private string ShamsiDate()
        {
            string today = "";
            PersianCalendar pc = new PersianCalendar();
            DateTime dt = DateTime.Now;
            today = pc.GetYear(dt).ToString("0000/") + pc.GetMonth(dt).ToString("00/") + pc.GetDayOfMonth(dt).ToString("00");
            today += " - " + dt.Hour + ":" + dt.Minute;
            return today;
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



        //---------------------------End Methods---------------------//
        private void Frm_Missions_Load(object sender, EventArgs e)
        {
            Show_Personels();
            Show_Missions();
            PersianCalander_DateMission.Today_Click(null, null);
        }

        private void cmb_Personels_SelectedIndexChanged(object sender, EventArgs e)
        {
            int personelID;
            int.TryParse(cmb_Personels.SelectedValue.ToString(), out personelID);
            Show_Perosonel_Image(personelID);



        }

        private bool IsPersonelMission(int PersonelID)
        {
            string dateMission = PersianCalander_DateMission.Text;
            string untilHours = txt_UnitlHours.Text;
            var qCheck_Mission = (from rows in database.Tbl_Missions
                                  where (rows.PersonelID_FK == PersonelID && rows.Date_Mission == dateMission && rows.Until_Hours == untilHours)
                                  select rows
                                ).Any();
            if (qCheck_Mission == true)  // اگر همچین ماموریتی وجود داشت
            {
                return true;
            }
            return false;
        }

        private void btn_AddMission_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_FromHours.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_FromHours, "مقدار الزامی است");
                txt_FromHours.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_UnitlHours.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_UnitlHours, "مقدار الزامی است");
                txt_UnitlHours.Focus();
                return;
            }
            else if (validateFromHours == false)
            {
                errorProvider1.Clear();
                MessageBox.Show("لطفا ساعت را صحیح و با قالب 24 ساعته وارد نمایید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_FromHours.Focus();
                txt_FromHours.SelectAll();
                errorProvider1.SetError(txt_FromHours, "زمان و ساعت نامعتبر");
                return;
            }
            else if (validateUntilHours == false)
            {
                errorProvider1.Clear();
                MessageBox.Show("لطفا ساعت را صحیح و با قالب 24 ساعته وارد نمایید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_UnitlHours.Focus();
                txt_UnitlHours.SelectAll();
                errorProvider1.SetError(txt_UnitlHours, "زمان و ساعت نامعتبر");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txt_Destination.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_Destination, "مقدار الزامی است");
                txt_Destination.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txt_Description.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_Description, "مقدار الزامی است");
                txt_Description.Focus();
                return;
            }
            else if (IsPersonelMission(int.Parse(txt_Personelid.Text)) == true)
            {
                MessageBox.Show("امکان ثبت ماموریت وجود ندارد\n" + "برای ثبت  باید ساعت ماموریت کارمند به اتمام برسد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {

                errorProvider1.Clear();
                database.Tbl_Missions.Add(new Tbl_Missions()
                {
                    Date_Mission = PersianCalander_DateMission.Text,
                    Date_Sumbit = ShamsiDate(),
                    Description = txt_Description.Text,
                    Destination = txt_Destination.Text,
                    From_Hours = txt_FromHours.Text,
                    PersonelID_FK = Convert.ToInt32(txt_Personelid.Text),
                    Until_Hours = txt_UnitlHours.Text
                });
                if (Convert.ToBoolean(database.SaveChanges()))
                {
                    MessageBox.Show("ماموریت با موفقیت ثبت گردید", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Show_Personels();
                    Show_Missions();
                    Reset_Items();
                }
                else
                {
                    MessageBox.Show("خطایی در ثبت اطلاعات به وجود آمده\n" + "لطفا در ورود اطلاعات دقت فرمایید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
        }



        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (flagEdit == true)
            {
                Reset_Items();
            }
            else
                this.Close();
        }

        private void txt_FromHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar) || e.KeyChar == ':'))
            {
                e.Handled = true;
            }
        }

        private void txt_UnitlHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar) || e.KeyChar == ':'))
            {
                e.Handled = true;
            }
        }

        private void txt_FromHours_Leave(object sender, EventArgs e)
        {
            //try
            //{
            //    string[] a = txt_FromHours.Text.Split(':'); // 23:10;  s1=23  :   s2=10
            //    int s1 = Convert.ToInt16(a[0]);
            //    int s2 = Convert.ToInt16(a[1]);

            //    if(s1 >= 24 || s2 > 59)
            //    {
            //        MessageBox.Show("ساعت نا معتبر");
            //    }
            //}
            //catch
            //{

            //}

            try
            {
                if (txt_FromHours.Text == string.Empty)
                    return;

                if (Functions.isValidTime(txt_FromHours.Text))
                {
                    errorProvider1.Clear();
                    validateFromHours = true;
                }
                else
                {
                    errorProvider1.Clear();
                    MessageBox.Show("لطفا ساعت را صحیح و با قالب 24 ساعته وارد نمایید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_FromHours.Focus();
                    txt_FromHours.SelectAll();
                    errorProvider1.SetError(txt_FromHours, "ساعت نامعتبر");
                    validateFromHours = false;

                }

            }
            catch
            {
                MessageBox.Show("لطفا ساعت را صحیح و با قالب 24 ساعته وارد نمایید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validateFromHours = false;

            }
        }

        private void txt_UnitlHours_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_UnitlHours.Text == string.Empty)
                    return;

                if (Functions.isValidTime(txt_UnitlHours.Text))
                {
                    errorProvider1.Clear();
                    validateUntilHours = true;
                }
                else
                {
                    errorProvider1.Clear();
                    MessageBox.Show("لطفا ساعت را صحیح و با قالب 24 ساعته وارد نمایید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_UnitlHours.Focus();
                    txt_UnitlHours.SelectAll();
                    errorProvider1.SetError(txt_UnitlHours, "ساعت نامعتبر");
                    validateUntilHours = false;
                }

            }
            catch
            {
                MessageBox.Show("لطفا ساعت را صحیح و با قالب 24 ساعته وارد نمایید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validateUntilHours = false;

            }
        }

        private void ctm_edit_Click(object sender, EventArgs e)
        {
            if (grd_Missions.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                int missionID;
                int.TryParse(grd_Missions.CurrentRow.Cells["col_missionid"].Value.ToString(), out missionID);
                var Selected = (from rows in database.Tbl_Missions where rows.MissionID == missionID select rows).SingleOrDefault();
                if (Selected != null)
                {
                    txt_Description.Text = Selected.Description;
                    txt_Destination.Text = Selected.Destination;
                    txt_FromHours.Text = Selected.From_Hours;
                    cmb_Personels.SelectedValue = Selected.PersonelID_FK;
                    txt_UnitlHours.Text = Selected.Until_Hours;
                    PersianCalander_DateMission.Text = Selected.Date_Mission;
                    lbl_missionId.Text = Selected.MissionID.ToString();
                    //----------------------------------------------------------
                    cmb_Personels.Enabled = false;
                    btn_AddMission.Enabled = false;
                    btn_EditFinal.Enabled = true;
                    btn_Cancel.Text = "انصراف";
                    flagEdit = true;
                }
            }
        }

        private void btn_EditFinal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_FromHours.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_FromHours, "مقدار الزامی است");
                txt_FromHours.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_UnitlHours.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_UnitlHours, "مقدار الزامی است");
                txt_UnitlHours.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txt_Destination.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_Destination, "مقدار الزامی است");
                txt_Destination.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txt_Description.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_Description, "مقدار الزامی است");
                txt_Description.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
                int missionID;
                int.TryParse(lbl_missionId.Text, out missionID);
                var qMissionUpdate = (from rows in database.Tbl_Missions where rows.MissionID == missionID select rows).SingleOrDefault();
                if (qMissionUpdate != null)
                {
                    qMissionUpdate.Date_Mission = PersianCalander_DateMission.Text;
                    qMissionUpdate.Description = txt_Description.Text;
                    qMissionUpdate.Destination = txt_Destination.Text;
                    qMissionUpdate.From_Hours = txt_FromHours.Text;
                    qMissionUpdate.Until_Hours = txt_UnitlHours.Text;

                    database.SaveChanges();
                    MessageBox.Show("اطلاعات ماموریت با موفقیت ویرایش گردید", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset_Items();
                    Show_Missions();

                }
            }
        }

        private void txt_FromHours_TextChanged(object sender, EventArgs e)
        {

        }

        private void ctm_delete_Click(object sender, EventArgs e)
        {
            if (grd_Missions.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                int RowID;
                int.TryParse(grd_Missions.CurrentRow.Cells["col_missionid"].Value.ToString(), out RowID);
                var Selected = (from rows in database.Tbl_Missions where rows.MissionID == RowID select rows).SingleOrDefault();
                if (Selected != null)
                {
                    DialogResult dr;
                    dr = MessageBox.Show("ایا میخواهید این مورد را حذف نمایید", "حذف ماموریت", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        var qReportMission = (from r in database.Tbl_ReportMission where r.MissionID_FK == RowID select r).FirstOrDefault();
                        if (qReportMission != null)
                        {
                            database.Tbl_ReportMission.Remove(qReportMission);
                        }
                        database.Tbl_Missions.Remove(Selected);
                        if (Convert.ToBoolean(database.SaveChanges()))
                        {
                            MessageBox.Show("ماموریت با موفقیت حذف گردید", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Show_Missions();
                        }
                    }
                }
            }
        }

        private void ctm_printMission_Click(object sender, EventArgs e)
        {
            if (grd_Missions.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                int missionId;
                int.TryParse(grd_Missions.CurrentRow.Cells["col_missionid"].Value.ToString(), out missionId);
                var Selected = (from rows in database.Tbl_Missions where rows.MissionID == missionId select rows).SingleOrDefault();
                if (Selected != null)
                {
                    Frm_ReportMission f = new Frm_ReportMission();
                    var qCheckReportMission = (from r in database.Tbl_ReportMission where r.MissionID_FK == missionId select r).FirstOrDefault();
                    if (qCheckReportMission != null)   // گزارش از قبل وجود دارد و برای ویرایش
                    {
                        f.txt_dateMission.Text = Selected.Date_Mission;
                        f.txt_docId.Text = Selected.MissionID.ToString();
                        f.txt_personelId.Text = Selected.PersonelID_FK.ToString();
                        f.txt_personelName.Text = Selected.Tbl_Personels.Name + " " + Selected.Tbl_Personels.Family;
                        f.txt_titleMission.Text = Selected.Description;
                        f.flagEdit = true;

                    }
                    else   //  گزارش ماموریت از قبل وجود ندارد و گزارش جدیدی میخواهد ثبت شود
                    {
                        f.txt_dateMission.Text = Selected.Date_Mission;
                        f.txt_docId.Text = Selected.MissionID.ToString();
                        f.txt_personelId.Text = Selected.PersonelID_FK.ToString();
                        f.txt_personelName.Text = Selected.Tbl_Personels.Name + " " + Selected.Tbl_Personels.Family;
                        f.txt_titleMission.Text = Selected.Description;
                        f.PersianCalender_DateMission.Today_Click(null, null);
                        f.btn_removeReport.Visible = false;
                        f.flagEdit = false;

                    }
                    try
                    {
                        f.ShowDialog();
                        Show_Missions();
                    }
                    catch
                    {


                    }

                }
            }
        }

        private void txtSearchByID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchByID.Text))
            {
                Show_Missions();
            }
            else
            {
                int personelID;
                int.TryParse(txtSearchByID.Text, out personelID);
                var qSearch = (from rows in database.Tbl_Missions where rows.PersonelID_FK == personelID select rows).Any();
                if (qSearch == true)
                {
                    var records = (from rows in database.Tbl_Missions
                                   where rows.PersonelID_FK == personelID
                                   select new
                                   {
                                       FullName = rows.Tbl_Personels.Name + " " + rows.Tbl_Personels.Family,
                                       rows.Date_Mission,
                                       rows.Date_Sumbit,
                                       rows.Description,
                                       rows.Destination,
                                       rows.From_Hours,
                                       rows.Until_Hours,
                                       rows.PersonelID_FK,
                                       rows.MissionID,
                                   }).ToList();
                    grd_Missions.DataSource = records;
                }
            }
        }

        private void txtSearchByFamily_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByFamily.Text == string.Empty)
            {
                Show_Missions();

            }
            else
            {
                string searchByFamily = txtSearchByFamily.Text;
                var records = (from rows in database.Tbl_Missions
                               where rows.Tbl_Personels.Family.StartsWith(searchByFamily)
                               select new
                               {
                                   FullName = rows.Tbl_Personels.Name + " " + rows.Tbl_Personels.Family,
                                   rows.Date_Mission,
                                   rows.Date_Sumbit,
                                   rows.Description,
                                   rows.Destination,
                                   rows.From_Hours,
                                   rows.Until_Hours,
                                   rows.PersonelID_FK,
                                   rows.MissionID,
                               }).ToList();
                grd_Missions.DataSource = records;

            }

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (persianFromDate_Search.Text != string.Empty && persianUntilDate_Search.Text != string.Empty)
            {
                string fromDate = persianFromDate_Search.Text;
                string untilDate = persianUntilDate_Search.Text;
                string personelName = cmb_SearchByPersonel.Text;
                int personelID;
                int.TryParse(cmb_SearchByPersonel.SelectedValue.ToString(), out personelID);
                var query = database.Tbl_Missions.SqlQuery("SELECT * FROM Tbl_Missions WHERE PersonelID_FK=@p0 AND Date_Mission >=@p1 AND Date_Mission <=@p2", personelID, fromDate, untilDate).ToList();
                Frm_MissionHistory f = new Frm_MissionHistory();
                f.lbl_personel.Text = "سوابق ماموریت" + " " + personelName;
                f.lbl_fromDate.Text = "از تاریخ : " + Functions.GetShamsiMonthFromDate(fromDate) + " تا تاریخ : "
                    + Functions.GetShamsiMonthUntilDate(untilDate);
                f.grd_MissionHistory.DataSource = query;
                f.intPersonelID = personelID;
                f.strFromDate = fromDate;
                f.strUntilDate = untilDate;
                f.ShowDialog();
            }
        }

        private void grd_Missions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            grd_Missions.Rows[e.RowIndex].Cells["col_radif"].Value = e.RowIndex + 1;
        }

        private void btn_ShowOptimizationForm_Click(object sender, EventArgs e)
        {
            new Frm_OptimizeMission().ShowDialog();
            Show_Missions();
        }

        private void chk_multiSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_multiSelect.Checked)
            {
                grd_Missions.Columns["col_select"].Visible = true;
                btn_FinalDeleteData.Visible = true;

            }
            else
            {
                grd_Missions.Columns["col_select"].Visible = false;
                btn_FinalDeleteData.Visible = false;

            }
        }

        private async void btn_FinalDeleteData_Click(object sender, EventArgs e)
        {
            int total = grd_Missions.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells["col_select"].Value) == true).Count();
            if (total > 0)
            {
                string message = "ایا میخواهید این سطر را حذف نمایید ؟";
                if (total > 1)
                    message = $" ایا میخواهید تعداد {total} سطر را حذف نماید؟";
                if (MessageBox.Show(message, "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = grd_Missions.RowCount - 1; i >= 0; i--)
                    {
                        DataGridViewRow row = grd_Missions.Rows[i];
                        if (Convert.ToBoolean(row.Cells["col_select"].Value) == true)
                        {
                            int selected;
                            int.TryParse(row.Cells["col_missionid"].Value.ToString(), out selected);
                            var q = (from rows in database.Tbl_Missions where rows.MissionID == selected select rows).ToList();
                            database.Tbl_Missions.RemoveRange(q.AsEnumerable());
                        }
                    }
                }
                else
                {
                    return;
                }
            }
            DialogResult dr;
            dr = MessageBox.Show("ایا مایل به ادامه عملیات حذف داده ها هستید", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                await database.SaveChangesAsync();
                MessageBox.Show("حذف داده ها با موفقیت انجام گردید", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Show_Missions();
            }
        }
    }
}
