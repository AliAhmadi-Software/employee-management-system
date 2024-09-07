using Attendance_Automation.Classes;
using Attendance_Automation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Automation
{
    public partial class Frm_Attendance : Form
    {
        Attendance_DBEntities database = new Attendance_DBEntities();
        private bool validateEnterTime = false;
        private bool validateLeaveTime = false;
        private bool flagEdit = false;
        public Frm_Attendance()
        {
            InitializeComponent();
            grd_Attendance.AutoGenerateColumns = false;
        }

        //--------------------------Methods----------------------//

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
        private void Show_Attendance()
        {
            var records = (from rows in database.Tbl_Attendance
                           select new
                           {
                               FullName = rows.Tbl_Personels.Name + " " + rows.Tbl_Personels.Family,
                               rows.AttendanceID,
                               rows.AttendanceDate,
                               rows.Enter_Time,
                               rows.Leave_Time,
                               rows.PersonelID_FK,
                               rows.Description,
                               rows.Date_Submit
                           }).ToList();
            grd_Attendance.DataSource = records;
        }
        private void Reset_Items()
        {
            if (flagEdit == true)
            {
                cmb_Personels.SelectedIndex = 0;
                PersianCalander_DateAttendance.Text = string.Empty;
                txt_EnterTime.ResetText();
                txt_LeaveTime.ResetText();
                txt_Description.ResetText();

                //------------------------------------------------------------------------
                lbl_AttendanceId.Text = "lbl_attendanceid";
                btn_AddAttendance.Enabled = true;
                btn_Cancel.Text = "بستن";
                btn_EditFinal.Enabled = false;
                cmb_Personels.Enabled = true;
                flagEdit = false;

            }
            else if (flagEdit == false)
            {
                cmb_Personels.SelectedIndex = 0;
                PersianCalander_DateAttendance.Today_Click(null, null);
                txt_EnterTime.ResetText();
                txt_LeaveTime.ResetText();
                txt_Description.ResetText();
            }
        }

        //------------------------End Methods--------------------//

        private void Frm_Attendance_Load(object sender, EventArgs e)
        {
            Show_Personels();
            Show_Attendance();
        }

        private void cmb_Personels_SelectedIndexChanged(object sender, EventArgs e)
        {
            int personelID;
            int.TryParse(cmb_Personels.SelectedValue.ToString(), out personelID);
            Show_Perosonel_Image(personelID);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if(flagEdit==true)
            {
                Reset_Items();
            }
            else
            {
                this.Close();
            }
            
        }

        private void txtSearchByID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txt_EnterTime_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_EnterTime.Text == string.Empty)
                    return;

                if (Functions.isValidTime(txt_EnterTime.Text))
                {
                    errorProvider1.Clear();

                    validateEnterTime = true;
                }
                else
                {
                    errorProvider1.Clear();
                    MessageBox.Show("لطفا ساعت را صحیح و با قالب 24 ساعته وارد نمایید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_EnterTime.Focus();
                    txt_EnterTime.SelectAll();
                    errorProvider1.SetError(txt_EnterTime, "ساعت نامعتبر");
                    validateEnterTime = false;
                }

            }
            catch
            {
                MessageBox.Show("لطفا ساعت را صحیح و با قالب 24 ساعته وارد نمایید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validateEnterTime = false;

            }
        }

        private void txt_LeaveTime_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_LeaveTime.Text == string.Empty)
                    return;

                if (Functions.isValidTime(txt_LeaveTime.Text))
                {
                    errorProvider1.Clear();

                    validateLeaveTime = true;
                }
                else
                {
                    errorProvider1.Clear();
                    MessageBox.Show("لطفا ساعت را صحیح و با قالب 24 ساعته وارد نمایید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_LeaveTime.Focus();
                    txt_LeaveTime.SelectAll();
                    errorProvider1.SetError(txt_LeaveTime, "ساعت نامعتبر");
                    validateLeaveTime = false;
                }

            }
            catch
            {
                MessageBox.Show("لطفا ساعت را صحیح و با قالب 24 ساعته وارد نمایید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validateLeaveTime = false;

            }
        }

        private void txt_EnterTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar) || e.KeyChar == ':'))
            {
                e.Handled = true;
            }
        }

        private void txt_LeaveTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar) || e.KeyChar == ':'))
            {
                e.Handled = true;
            }
        }

        private void btn_AddAttendance_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_EnterTime.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_EnterTime, "مقدار الزامی است");
                txt_EnterTime.Focus();
                return;
            }
            else if(string.IsNullOrWhiteSpace(txt_LeaveTime.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_LeaveTime, "مقدار الزامی است");
                txt_LeaveTime.Focus();
                return;
            }
            else if(validateEnterTime==false)
            {
                errorProvider1.Clear();
                MessageBox.Show("لطفا ساعت را صحیح و با قالب 24 ساعته وارد نمایید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_EnterTime.Focus();
                txt_EnterTime.SelectAll();
                errorProvider1.SetError(txt_EnterTime, "زمان و ساعت نامعتبر");
                return;

            }
            else if(validateLeaveTime==false)
            {
                errorProvider1.Clear();
                MessageBox.Show("لطفا ساعت را صحیح و با قالب 24 ساعته وارد نمایید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_LeaveTime.Focus();
                txt_LeaveTime.SelectAll();
                errorProvider1.SetError(txt_LeaveTime, "زمان و ساعت نامعتبر");
                return;
            }
            else if(PersianCalander_DateAttendance.Text==string.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(PersianCalander_DateAttendance, "مقدار الزامی است");
                PersianCalander_DateAttendance.Focus();
                return;
            }
            else if(string.IsNullOrWhiteSpace(txt_Description.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_Description, "مقدار الزامی است");
                txt_Description.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
                database.Tbl_Attendance.Add(new Tbl_Attendance()
                {
                    AttendanceDate=PersianCalander_DateAttendance.Text,
                    Date_Submit=ShamsiDate(),
                    Description=txt_Description.Text,
                    Enter_Time=txt_EnterTime.Text,
                    Leave_Time=txt_LeaveTime.Text,
                    PersonelID_FK=Convert.ToInt32(txt_Personelid.Text),
                });
                if(Convert.ToBoolean(database.SaveChanges()))
                {
                    MessageBox.Show("ورود و خروج ساعت کارمند با موفقیت ثبت گردید","موفق",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Show_Attendance();
                    Reset_Items();
                }
                else
                {
                    MessageBox.Show("خطایی در ثبت اطلاعات به وجود امده لطفا دوباره تلاش کنید","خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            
        }

        private void ctm_delete_Click(object sender, EventArgs e)
        {
            if(grd_Attendance.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                int attendanceID;
                int.TryParse(grd_Attendance.CurrentRow.Cells["col_attendanceid"].Value.ToString(), out attendanceID);
                var Selected = (from rows in database.Tbl_Attendance
                                where rows.AttendanceID == attendanceID
                                select rows).SingleOrDefault();
                if(Selected !=null)
                {
                    DialogResult dr;
                    dr = MessageBox.Show("ایا میخواهید این مورد را حذف نمایید؟","حذف",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if(dr==DialogResult.Yes)
                    {
                        database.Tbl_Attendance.Remove(Selected);
                        database.SaveChanges();
                        MessageBox.Show("ورود و خروج با موفقیت حذف گردید","موفق",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        Show_Attendance();
                    }
                }
            }
        }

        private void ctm_edit_Click(object sender, EventArgs e)
        {
            if (grd_Attendance.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                int attendanceID;
                int.TryParse(grd_Attendance.CurrentRow.Cells["col_attendanceid"].Value.ToString(), out attendanceID);
                var Selected = (from rows in database.Tbl_Attendance
                                where rows.AttendanceID == attendanceID
                                select rows).SingleOrDefault();
                if (Selected != null)
                {
                    txt_Description.Text = Selected.Description;
                    txt_EnterTime.Text = Selected.Enter_Time;
                    txt_LeaveTime.Text = Selected.Leave_Time;
                    PersianCalander_DateAttendance.Text = Selected.AttendanceDate;
                    cmb_Personels.SelectedValue = Selected.PersonelID_FK;
                    //-------------------------------------------------------
                    lbl_AttendanceId.Text = Selected.AttendanceID.ToString();
                    btn_AddAttendance.Enabled = false;
                    btn_Cancel.Text = "انصراف";
                    btn_EditFinal.Enabled = true;
                    cmb_Personels.Enabled = false;
                    flagEdit = true;
                }
            }
        }

        private void btn_EditFinal_Click(object sender, EventArgs e)
        {
            if(flagEdit==true)
            {
                int attendanceID;
                int.TryParse(lbl_AttendanceId.Text, out attendanceID);
                var qUpdateAttendance = (from rows in database.Tbl_Attendance
                                         where rows.AttendanceID == attendanceID
                                         select rows).SingleOrDefault();
                if(qUpdateAttendance !=null)
                {
                    qUpdateAttendance.AttendanceDate = PersianCalander_DateAttendance.Text;
                    qUpdateAttendance.Description = txt_Description.Text;
                    qUpdateAttendance.Enter_Time = txt_EnterTime.Text;
                    qUpdateAttendance.Leave_Time = txt_LeaveTime.Text;
                    database.SaveChanges();
                    MessageBox.Show("ویرایش اطلاعات با موفقیت انجام گردید","موفق",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Show_Attendance();
                    Reset_Items();
                }
            }
        }

        private void txtSearchByID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchByID.Text))
            {
                Show_Attendance();
            }
            else
            {
                int personelID;
                int.TryParse(txtSearchByID.Text, out personelID);
                var qSearch = (from rows in database.Tbl_Attendance where rows.PersonelID_FK == personelID select rows).Any();
                if (qSearch == true)
                {

                    var records = (from rows in database.Tbl_Attendance
                                   where rows.PersonelID_FK==personelID
                                   select new
                                   {
                                       FullName = rows.Tbl_Personels.Name + " " + rows.Tbl_Personels.Family,
                                       rows.AttendanceID,
                                       rows.AttendanceDate,
                                       rows.Enter_Time,
                                       rows.Leave_Time,
                                       rows.PersonelID_FK,
                                       rows.Description,
                                       rows.Date_Submit
                                   }).ToList();
                    grd_Attendance.DataSource = records;
                }
            }
        }

        private void txtSearchByFamily_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByFamily.Text == string.Empty)
            {
                Show_Attendance();

            }
            else
            {
                string searchByFamily = txtSearchByFamily.Text;
                var records = (from rows in database.Tbl_Attendance
                               where rows.Tbl_Personels.Family.StartsWith(searchByFamily)
                               select new
                               {
                                   FullName = rows.Tbl_Personels.Name + " " + rows.Tbl_Personels.Family,
                                   rows.AttendanceID,
                                   rows.AttendanceDate,
                                   rows.Enter_Time,
                                   rows.Leave_Time,
                                   rows.PersonelID_FK,
                                   rows.Description,
                                   rows.Date_Submit
                               }).ToList();
                grd_Attendance.DataSource = records;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(persianFromDate_Search.Text !=string.Empty && persianUntilDate_Search.Text !=string.Empty)
            {
                string fromDate = persianFromDate_Search.Text;
                string untilDate = persianUntilDate_Search.Text;
                string personelName = cmb_SearchByPersonel.Text;
                int personelID;
                int.TryParse(cmb_SearchByPersonel.SelectedValue.ToString(), out personelID);

                List<Tbl_Attendance> qHistory = database.Tbl_Attendance.SqlQuery("select * from Tbl_Attendance where PersonelID_FK=@p0 AND AttendanceDate>=@p1 AND AttendanceDate<=@p2", personelID, fromDate, untilDate).ToList();
                Frm_AttendanceHistory f = new Frm_AttendanceHistory();
                f.lbl_personel.Text ="سوابق حضور و غیاب" + " " +  personelName;
                f.grd_AttendanceHistory.DataSource = qHistory;
                f.lbl_fromDate.Text= "از تاریخ : " + Functions.GetShamsiMonthFromDate(fromDate) + " تا تاریخ : "
                    + Functions.GetShamsiMonthUntilDate(untilDate);
                f.intPersonelID = personelID;
                f.strFromDate = fromDate;
                f.strUntilDate = untilDate;
                f.ShowDialog();
            }
        }

        private void btn_ShowOptimizationForm_Click(object sender, EventArgs e)
        {
            new Frm_OptimizeAttendance().ShowDialog();
            Show_Attendance();

        }
    }
}
