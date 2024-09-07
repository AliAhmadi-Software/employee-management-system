using Attendance_Automation.Classes;
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
using System.Globalization;
using System.IO;
using System.Data.Entity;

namespace Attendance_Automation
{
    public partial class Frm_LeavesTime : Form
    {
        Attendance_DBEntities database = new Attendance_DBEntities();
        private bool validateFromHours = false;
        private bool validateUntilHours = false;
        private bool flagEdit = false;

        public Frm_LeavesTime()
        {
            InitializeComponent();
            grd_LeaveTime.AutoGenerateColumns = false;
        }

        //----------------------------Methods--------------------------------//
        private void Reset_Items()
        {
            if (flagEdit == true)
            {
                txt_Description.ResetText();
                txt_FromHours.ResetText();
                txt_UntilHours.ResetText();
                txt_DiffrenceTime.ResetText();
                PersianCalander_LeaveDate.Today_Click(null, null);
                cmb_Personels.SelectedIndex = 0;
                lbl_leaveId.Text = "---";
                cmb_Personels.Enabled = true;
                btn_AddLeaveTime.Enabled = true;
                btn_Cancel.Text = "بستن";
                btn_EditFinal.Enabled = false;
                flagEdit = false;

            }
            else if (flagEdit == false)
            {
                cmb_Personels.SelectedIndex = 0;
                txt_Description.ResetText();
                txt_FromHours.ResetText();
                txt_UntilHours.ResetText();
                txt_DiffrenceTime.ResetText();
                PersianCalander_LeaveDate.Today_Click(null, null);

            }
        }

        private void Show_LeavesTime()
        {
            var records = (from rows in database.Tbl_LeavesTime
                           select new
                           {
                               FullName = rows.Tbl_Personels.Name + " " + rows.Tbl_Personels.Family,
                               rows.Date_Submit,
                               rows.Description,
                               rows.Difference_Time,
                               rows.From_Hours,
                               rows.LeaveDate,
                               rows.PersonelID_FK,
                               rows.LeaveTimeID,
                               rows.Until_Hours,

                           }).ToList();
            grd_LeaveTime.DataSource = records;

        }
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





        private void Show_Perosonel_Image(int personelID)
        {
            var Selected = (from rows in database.Tbl_Personels where rows.PersonelID == personelID select rows).SingleOrDefault();
            if (Selected != null)
            {
                txt_Personelid.Text = Selected.PersonelID.ToString();
                if (Directory.Exists(Application.StartupPath + @"\personel_images"))
                {
                    if (File.Exists(Application.StartupPath + @"\personel_images\" + Selected.Personel_Image))
                    {
                        picbox_personel.ImageLocation = Application.StartupPath + @"\personel_images\" + Selected.Personel_Image;
                    }
                    else
                    {
                        picbox_personel.ImageLocation = null;
                    }
                }

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

        private string CalculateTime(string inputStartTime, string inputEndTime)
        {
            DateTime startTime = Convert.ToDateTime(inputStartTime);
            DateTime endtime = Convert.ToDateTime(inputEndTime);

            TimeSpan duration = startTime - endtime;
            return duration.ToString(@"hh\:mm");
        }



        //---------------------------End Methods ----------------------------//

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (flagEdit == true)
            {
                Reset_Items();
            }
            else
            {
                this.Close();
            }
        }

        private void txt_FromHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar) || e.KeyChar == ':'))
            {
                e.Handled = true;
            }
        }

        private void txt_UntilHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar) || e.KeyChar == ':'))
            {
                e.Handled = true;
            }
        }

        private void txt_FromHours_Leave(object sender, EventArgs e)
        {
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

        private void txt_UntilHours_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_UntilHours.Text == string.Empty)
                    return;

                if (Functions.isValidTime(txt_UntilHours.Text))
                {
                    errorProvider1.Clear();

                    validateUntilHours = true;
                }
                else
                {
                    errorProvider1.Clear();
                    MessageBox.Show("لطفا ساعت را صحیح و با قالب 24 ساعته وارد نمایید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_UntilHours.Focus();
                    txt_UntilHours.SelectAll();
                    errorProvider1.SetError(txt_UntilHours, "ساعت نامعتبر");
                    validateUntilHours = false;
                }

            }
            catch
            {
                MessageBox.Show("لطفا ساعت را صحیح و با قالب 24 ساعته وارد نمایید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validateUntilHours = false;

            }
        }

        private void txtSearchByID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void cmb_Personels_SelectedIndexChanged(object sender, EventArgs e)
        {
            int personelID;
            int.TryParse(cmb_Personels.SelectedValue.ToString(), out personelID);
            Show_Perosonel_Image(personelID);
        }

        private void Frm_LeavesTime_Load(object sender, EventArgs e)
        {
            Show_LeavesTime();
            Show_Personels();
        }

        private void txt_FromHours_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_DiffrenceTime.Text = CalculateTime(txt_FromHours.Text, txt_UntilHours.Text);
            }
            catch
            {


            }
        }

        private void txt_UntilHours_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_DiffrenceTime.Text = CalculateTime(txt_FromHours.Text, txt_UntilHours.Text);
            }
            catch
            {


            }
        }

        private void btn_AddLeaveTime_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_FromHours.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_FromHours, "لطفا ساعت شرروع مرخصی را وارد کنید");
                txt_FromHours.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_UntilHours.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_UntilHours, "لطفا ساعت پایان مرخصی را وارد کنید");
                txt_UntilHours.Focus();
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
                txt_UntilHours.Focus();
                txt_UntilHours.SelectAll();
                errorProvider1.SetError(txt_UntilHours, "زمان و ساعت نامعتبر");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txt_DiffrenceTime.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_UntilHours, "محاسبه زمان انجام نشده است");
                return;
            }
            else if (string.IsNullOrWhiteSpace(PersianCalander_LeaveDate.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(PersianCalander_LeaveDate, "لطفا تاریخ مرخصی ساعتی را انتخاب کنید");
                txt_UntilHours.Focus();
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
                DateTime dt = Convert.ToDateTime(txt_DiffrenceTime.Text);
                var dt2 = dt;
                database.Tbl_LeavesTime.Add(new Tbl_LeavesTime()
                {
                    Date_Submit = ShamsiDate(),
                    Description = txt_Description.Text,
                    Difference_Time = dt2.TimeOfDay,
                    From_Hours = txt_FromHours.Text,
                    LeaveDate = PersianCalander_LeaveDate.Text,
                    PersonelID_FK = Convert.ToInt32(txt_Personelid.Text),
                    Until_Hours = txt_UntilHours.Text,

                });
                if (Convert.ToBoolean(database.SaveChanges()))
                {
                    MessageBox.Show("مرخصی ساعتی با موفقیت ثبت گردید", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Show_LeavesTime();
                    Reset_Items();
                }
                else
                {
                    MessageBox.Show("خطایی در ثبت مرخصی ساعتی به وجود آمده\n" + "لطفا مجددا امتحان کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void ctm_delete_Click(object sender, EventArgs e)
        {
            if (grd_LeaveTime.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                int leaveTimeID;
                int.TryParse(grd_LeaveTime.CurrentRow.Cells["col_leavetimeid"].Value.ToString(), out leaveTimeID);
                var Selected = (from rows in database.Tbl_LeavesTime where rows.LeaveTimeID == leaveTimeID select rows).SingleOrDefault();
                if (Selected != null)
                {
                    DialogResult dr;
                    dr = MessageBox.Show("ایا  مایل به حذف این گزینه هستید؟", "حذف مرخصی ساعتی", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        database.Tbl_LeavesTime.Remove(Selected);
                        database.SaveChanges();
                        MessageBox.Show("مرخصی  ساعتی با موفقیت حذف گردید", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Show_LeavesTime();
                    }
                }
            }
        }

        private void ctm_edit_Click(object sender, EventArgs e)
        {
            if (grd_LeaveTime.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                int leaveTimeID;
                int.TryParse(grd_LeaveTime.CurrentRow.Cells["col_leavetimeid"].Value.ToString(), out leaveTimeID);
                var Selected = (from rows in database.Tbl_LeavesTime where rows.LeaveTimeID == leaveTimeID select rows).SingleOrDefault();
                if (Selected != null)
                {
                    cmb_Personels.SelectedValue = Selected.PersonelID_FK;
                    txt_FromHours.Text = Selected.From_Hours;
                    txt_UntilHours.Text = Selected.Until_Hours;
                    PersianCalander_LeaveDate.Text = Selected.LeaveDate;
                    txt_Description.Text = Selected.Description;
                    lbl_leaveId.Text = Selected.LeaveTimeID.ToString();
                    //------------------------------------------------------
                    cmb_Personels.Enabled = false;
                    btn_AddLeaveTime.Enabled = false;
                    btn_Cancel.Text = "انصراف";
                    btn_EditFinal.Enabled = true;
                    flagEdit = true;
                }
            }
        }

        private void btn_EditFinal_Click(object sender, EventArgs e)
        {
            if (flagEdit == true)
            {
                int leaveTimeId;
                int.TryParse(lbl_leaveId.Text, out leaveTimeId);
                var Query_Update = (from rows in database.Tbl_LeavesTime where rows.LeaveTimeID == leaveTimeId select rows).Single();
                if (Query_Update != null)
                {
                    DateTime dt = Convert.ToDateTime(txt_DiffrenceTime.Text);
                    var dt2 = dt;

                    Query_Update.Description = txt_Description.Text;
                    Query_Update.From_Hours = txt_FromHours.Text;
                    Query_Update.LeaveDate = PersianCalander_LeaveDate.Text;
                    Query_Update.Until_Hours = txt_UntilHours.Text;
                    Query_Update.Difference_Time = dt2.TimeOfDay;

                    database.SaveChanges();
                    MessageBox.Show("ویرایش اطلاعات با موفقیت انجام گردید", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Show_LeavesTime();
                    Reset_Items();

                    //---------------------------------------------------------------





                }
            }
        }





        private void txtSearchByID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchByID.Text))
            {
                Show_LeavesTime();
            }
            else
            {
                int personelID;
                int.TryParse(txtSearchByID.Text, out personelID);
                var qSearch = (from rows in database.Tbl_LeavesTime where rows.PersonelID_FK == personelID select rows).Any();
                if (qSearch == true)
                {
                    var records = (from rows in database.Tbl_LeavesTime
                                   where rows.PersonelID_FK == personelID
                                   select new
                                   {
                                       FullName = rows.Tbl_Personels.Name + " " + rows.Tbl_Personels.Family,
                                       rows.Date_Submit,
                                       rows.Description,
                                       rows.Difference_Time,
                                       rows.From_Hours,
                                       rows.LeaveDate,
                                       rows.PersonelID_FK,
                                       rows.LeaveTimeID,
                                       rows.Until_Hours,

                                   }).ToList();
                    grd_LeaveTime.DataSource = records;
                }
            }
        }

        private void txtSearchByFamily_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByFamily.Text == string.Empty)
            {
                Show_LeavesTime();

            }
            else
            {
                string searchByFamily = txtSearchByFamily.Text;
                var records = (from rows in database.Tbl_LeavesTime
                               where rows.Tbl_Personels.Family.StartsWith(searchByFamily)
                               select new
                               {
                                   FullName = rows.Tbl_Personels.Name + " " + rows.Tbl_Personels.Family,
                                   rows.Date_Submit,
                                   rows.Description,
                                   rows.Difference_Time,
                                   rows.From_Hours,
                                   rows.LeaveDate,
                                   rows.PersonelID_FK,
                                   rows.LeaveTimeID,
                                   rows.Until_Hours,

                               }).ToList();
                grd_LeaveTime.DataSource = records;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (persianFromDate_Search.Text != string.Empty && persianUntilDate_Search.Text != string.Empty)
            {
                int personelID = 0;
                string fromDate = persianFromDate_Search.Text;
                string untilDate = persianUntilDate_Search.Text;
                string personelName = cmb_SearchByPersonel.Text;
                int.TryParse(cmb_SearchByPersonel.SelectedValue.ToString(), out personelID);

                List<Tbl_LeavesTime> qHistory = database.Tbl_LeavesTime.SqlQuery("SELECT * FROM Tbl_LeavesTime where PersonelID_FK=@p0 AND LeaveDate>=@p1 AND LeaveDate<=@p2", personelID, fromDate, untilDate).ToList();
                Frm_LeavesTimeHistory f = new Frm_LeavesTimeHistory();
                f.lbl_PersonelName.Text = "سوابق مرخصی ساعتی" + " " + personelName;
                f.lbl_leaveDate.Text = "از تاریخ : " + Functions.GetShamsiMonthFromDate(fromDate) + " تا تاریخ : "
                                    + Functions.GetShamsiMonthUntilDate(untilDate);
                f.grd_LeavesTimeHistory.DataSource = qHistory;
                //-----------------------------------------------------------
                f.intPersonelID = personelID;
                f.strFromDate = fromDate;
                f.strUntilDate = untilDate;
                f.ShowDialog();
            }
        }

        private void btn_ShowOptimizationForm_Click(object sender, EventArgs e)
        {
            new Frm_OptimizeLeavesTime().ShowDialog();
            Show_LeavesTime();
        }
    }

}
    




