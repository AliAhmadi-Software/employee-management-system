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
using System.IO;
using System.Globalization;

namespace Attendance_Automation
{
    public partial class Frm_Leaves : Form
    {
        Attendance_DBEntities database = new Attendance_DBEntities();
        private bool flagEdit = false;
        public Frm_Leaves()
        {
            InitializeComponent();
            grd_Leave.AutoGenerateColumns = false;
        }

        //-----------------------------Methods-----------------------//
        private string ShamsiDate()
        {
            string today = "";
            PersianCalendar pc = new PersianCalendar();
            DateTime dt = DateTime.Now;
            today = pc.GetYear(dt).ToString("0000/") + pc.GetMonth(dt).ToString("00/") + pc.GetDayOfMonth(dt).ToString("00");
            today += " - " + dt.Hour + ":" + dt.Minute;
            return today;
        }

        private void Show_Leaves()
        {
            var records = (from rows in database.Tbl_Leaves
                           select new
                           {
                               rows.Date_Submit,
                               rows.Description,
                               rows.From_Date,
                               rows.Until_Date,
                               rows.PersonelID_FK,
                               rows.LeaveID,
                               CountDate = rows.Difference_Date + " روز",
                               FullName = rows.Tbl_Personels.Name + " " + rows.Tbl_Personels.Family,

                           }).ToList();
            grd_Leave.DataSource = records;
        }

        private void Reset_Items()
        {
            if (flagEdit == true)
            {
                PersianCalander_FromDate.Today_Click(null, null);
                PersianCalander_UntilDate.Text = string.Empty;
                txt_Description.ResetText();
                cmb_Personels.SelectedIndex = 0;
                txt_DiffrenceDate.ResetText();
                //----------------------------------------
                btn_AddLeave.Enabled = true;
                btn_Cancel.Text = "بستن";
                btn_EditFinal.Enabled = false;
                cmb_Personels.Enabled = true;
                flagEdit = false;
            }
            else
            {
                PersianCalander_FromDate.Today_Click(null, null);
                PersianCalander_UntilDate.Text = string.Empty;
                txt_Description.ResetText();
                cmb_Personels.SelectedIndex = 0;
                txt_DiffrenceDate.ResetText();
            }


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
        int Retday(string strtdate, string enddate)
        {

            int temp = 0, temp1 = 0;
            int day = 0, day1 = 0;

            temp = Convert.ToInt32(strtdate.Substring(5, 2));
            temp1 = Convert.ToInt32(strtdate.Substring(8, 2));
            if (temp > 6)
            {
                day = 186 + (temp - 7) * 30;
                day += temp1;
            }
            else
            {
                day = (temp - 1) * 31;
                day += temp1;
            }

            temp = Convert.ToInt32(enddate.Substring(5, 2));
            temp1 = Convert.ToInt32(enddate.Substring(8, 2));
            if (temp > 6)
            {
                day1 = 186 + (temp - 7) * 30;
                day1 += temp1;
            }
            else
            {
                day1 = (temp - 1) * 31;
                day1 += temp1;
            }
            temp = Convert.ToInt32(strtdate.Substring(0, 4));
            temp1 = Convert.ToInt32(enddate.Substring(0, 4));
            if (temp1 == temp)
            {
                return day1 - day;
            }
            else
            {
                return 365 - day + day1;
            }
        }


        //------------------------------End Methods---------------------------------------------//


        private void Frm_Leaves_Load(object sender, EventArgs e)
        {
            Show_Personels();
            Show_Leaves();
        }

        private void cmb_Personels_SelectedIndexChanged(object sender, EventArgs e)
        {
            int personelID;
            int.TryParse(cmb_Personels.SelectedValue.ToString(), out personelID);
            Show_Perosonel_Image(personelID);
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

        private void PersianCalander_FromDate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (PersianCalander_FromDate.Text != string.Empty)
                {
                    if (Retday(PersianCalander_FromDate.Text, PersianCalander_UntilDate.Text) == 0)
                    {
                        MessageBox.Show("تعداد روز نمیتواند 0 باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Retday(PersianCalander_FromDate.Text, PersianCalander_UntilDate.Text) < 0)
                    {
                        MessageBox.Show("تعداد روز نمیتواند  کمتر از 0 باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    txt_DiffrenceDate.Text = Retday(PersianCalander_FromDate.Text, PersianCalander_UntilDate.Text).ToString();
                }
            }
            catch
            {


            }
        }

        private void PersianCalander_UntilDate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (PersianCalander_UntilDate.Text != string.Empty)
                {
                    if (Retday(PersianCalander_FromDate.Text, PersianCalander_UntilDate.Text) == 0)
                    {
                        MessageBox.Show("تعداد روز نمیتواند 0 باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Retday(PersianCalander_FromDate.Text, PersianCalander_UntilDate.Text) < 0)
                    {
                        MessageBox.Show("تعداد روز نمیتواند  کمتر از 0 باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    txt_DiffrenceDate.Text = Retday(PersianCalander_FromDate.Text, PersianCalander_UntilDate.Text).ToString();
                }
            }
            catch
            {


            }
        }

        private bool IsPersonelLeaves(int personelID)
        {
            string untilDate = PersianCalander_UntilDate.Text;
            var qCheckLeaves = (from rows in database.Tbl_Leaves
                                where
                                rows.PersonelID_FK == personelID && rows.Until_Date == untilDate
                                select rows).Any();
            if (qCheckLeaves == true)
            {
                return true;
            }
            else
            return false;
        }
        private void btn_AddLeave_Click(object sender, EventArgs e)
        {
            if (PersianCalander_FromDate.Text == string.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(PersianCalander_FromDate, "تاریخ شروع مرخصی را انتخاب کنید");
                PersianCalander_FromDate.Focus();
                return;
            }
            else if (PersianCalander_UntilDate.Text == string.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(PersianCalander_UntilDate, "تاریخ پایان مرخصی را انتخاب کنید");
                PersianCalander_UntilDate.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txt_Description.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_Description, "توضبحات مربوط به نوع مرخصی را وارد کنید");
                txt_Description.Focus();
                return;
            }
            else if(IsPersonelLeaves(int.Parse( txt_Personelid.Text))==true)
            {
                MessageBox.Show("امکان ثبت مرخصی وجود ندارد\n" + "برای ثبت  باید تاریخ مرخصی کارمند به اتمام برسد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                errorProvider1.Clear();
                database.Tbl_Leaves.Add(new Tbl_Leaves()
                {
                    Date_Submit = ShamsiDate(),
                    Description = txt_Description.Text,
                    Difference_Date = Convert.ToInt16(txt_DiffrenceDate.Text),
                    From_Date = PersianCalander_FromDate.Text,
                    Until_Date = PersianCalander_UntilDate.Text,
                    PersonelID_FK = Convert.ToInt32(txt_Personelid.Text),
                });

                if (Convert.ToBoolean(database.SaveChanges()))
                {
                    MessageBox.Show("مرخصی  با موفقیت ثبت گردید", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Show_Leaves();
                    Reset_Items();
                }
                else
                {

                }
            }
        }

        private void grd_Leave_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            grd_Leave.Rows[e.RowIndex].Cells["col_radif"].Value = e.RowIndex + 1;
        }

        private void ctm_delete_Click(object sender, EventArgs e)
        {
            if (grd_Leave.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                int leaveID;
                int.TryParse(grd_Leave.CurrentRow.Cells["col_leaveid"].Value.ToString(), out leaveID);
                var Selected = (from rows in database.Tbl_Leaves where rows.LeaveID == leaveID select rows).Single();
                if (Selected != null)
                {
                    DialogResult dr;
                    dr = MessageBox.Show("ایا می خواهید این مرخصی را حذف نمایید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        database.Tbl_Leaves.Remove(Selected);
                        if (Convert.ToBoolean(database.SaveChanges()) == true)
                        {
                            MessageBox.Show("مرخصی با موفقیت حذف گردید", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Show_Leaves();
                        }
                        else
                        {
                            MessageBox.Show("خطایی در حذف مرخصی به وجود آمده\n" + "لطفا مجدد امتحان کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                }

            }
        }

        private void ctm_edit_Click(object sender, EventArgs e)
        {
            if (grd_Leave.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                int leaveID;
                int.TryParse(grd_Leave.CurrentRow.Cells["col_leaveid"].Value.ToString(), out leaveID);
                var Selected = (from rows in database.Tbl_Leaves where rows.LeaveID == leaveID select rows).Single();
                if (Selected != null)
                {
                    cmb_Personels.SelectedValue = Selected.PersonelID_FK;
                    txt_Description.Text = Selected.Description;
                    PersianCalander_FromDate.Text = Selected.From_Date;
                    PersianCalander_UntilDate.Text = Selected.Until_Date;
                    lbl_leaveId.Text = Selected.LeaveID.ToString();
                    //-----------------------------------------------------------
                    btn_AddLeave.Enabled = false;
                    btn_Cancel.Text = "انصراف";
                    btn_EditFinal.Enabled = true;
                    cmb_Personels.Enabled = false;
                    flagEdit = true;
                }
            }
        }

        private void btn_EditFinal_Click(object sender, EventArgs e)
        {

            if (PersianCalander_FromDate.Text == string.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(PersianCalander_FromDate, "تاریخ شروع مرخصی را انتخاب کنید");
                PersianCalander_FromDate.Focus();
                return;
            }
            else if (PersianCalander_UntilDate.Text == string.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(PersianCalander_UntilDate, "تاریخ پایان مرخصی را انتخاب کنید");
                PersianCalander_UntilDate.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txt_Description.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_Description, "توضبحات مربوط به نوع مرخصی را وارد کنید");
                txt_Description.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
                int leaveID = Convert.ToInt32(lbl_leaveId.Text);
                var qUpdate_Leaves = (from rows in database.Tbl_Leaves where rows.LeaveID == leaveID select rows).Single();
                if (qUpdate_Leaves != null)
                {
                    qUpdate_Leaves.Description = txt_Description.Text;
                    qUpdate_Leaves.From_Date = PersianCalander_FromDate.Text;
                    qUpdate_Leaves.Until_Date = PersianCalander_UntilDate.Text;
                    database.SaveChanges();
                    MessageBox.Show("اطلاعات مرخصی با موفقیت ویرایش گردید", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //-----------------------------------
                    Reset_Items();
                    Show_Leaves();
                }

            }
        }

        private void txtSearchByID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;

            }
        }

        private void txtSearchByID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchByID.Text))
            {
                Show_Leaves();
            }
            else
            {
                int personelID;
                int.TryParse(txtSearchByID.Text, out personelID);
                var qSearch = (from rows in database.Tbl_Leaves where rows.PersonelID_FK == personelID select rows).Any();
                if (qSearch == true)
                {
                    var records = (from rows in database.Tbl_Leaves
                                   where rows.PersonelID_FK == personelID
                                   select new
                                   {
                                       rows.Date_Submit,
                                       rows.Description,
                                       rows.From_Date,
                                       rows.Until_Date,
                                       rows.PersonelID_FK,
                                       rows.LeaveID,
                                       CountDate = rows.Difference_Date + " روز",
                                       FullName = rows.Tbl_Personels.Name + " " + rows.Tbl_Personels.Family,

                                   }).ToList();
                    grd_Leave.DataSource = records;
                }
            }
        }

        private void txtSearchByFamily_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByFamily.Text == string.Empty)
            {
                Show_Leaves();

            }
            else
            {
                string searchByFamily = txtSearchByFamily.Text;
                var records = (from rows in database.Tbl_Leaves
                               where rows.Tbl_Personels.Family.StartsWith(searchByFamily)
                               select new
                               {
                                   rows.Date_Submit,
                                   rows.Description,
                                   rows.From_Date,
                                   rows.Until_Date,
                                   rows.PersonelID_FK,
                                   rows.LeaveID,
                                   CountDate = rows.Difference_Date + " روز",
                                   FullName = rows.Tbl_Personels.Name + " " + rows.Tbl_Personels.Family,
                               }).ToList();
                grd_Leave.DataSource = records;


            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (persianFromDate_Search.Text != string.Empty && persianUntilDate_Search.Text != string.Empty)
            {
                string fromDate = persianFromDate_Search.Text;
                string untilDate = persianUntilDate_Search.Text;
                int personelID = 0;
                int.TryParse(cmb_SearchByPersonel.SelectedValue.ToString(), out personelID);
                var qHistory = database.Tbl_Leaves.SqlQuery("SELECT * FROM Tbl_Leaves WHERE PersonelID_FK=@p0 AND From_Date>=@p1 AND Until_Date<=@p2", personelID, fromDate, untilDate).ToList();
                string personelName = cmb_SearchByPersonel.Text;
                Frm_LeavesHistory f = new Frm_LeavesHistory();
                f.lbl_personel.Text = "سوابق مرخصی روزانه" + " " + personelName;
                f.lbl_fromDate.Text = "از تاریخ : " + Functions.GetShamsiMonthFromDate(fromDate) + " تا تاریخ : "
                                    + Functions.GetShamsiMonthUntilDate(untilDate);
                f.grd_LeaveHistory.DataSource = qHistory;
                //---------------------------محاسبه تعداد روز مرخصی -----------------------//
                try
                {
                    string sql = ("SELECT SUM(Difference_Date) FROM Tbl_Leaves WHERE PersonelID_FK=@p0 AND From_Date>=@p1 AND Until_Date<=@p2");
                    var total = database.Database.SqlQuery<int>(sql, personelID, fromDate, untilDate).FirstOrDefault();
                    string calcDayOfLeaves = total.ToString();
                    f.lbl_countDayLeaves.Text = calcDayOfLeaves;

                }
                catch
                {


                }
                f.intPersonelID = personelID;
                f.strFromDate = fromDate;
                f.strUntilDate = untilDate;
                f.ShowDialog();
            }
        }

        private void btn_ShowOptimizationForm_Click(object sender, EventArgs e)
        {
            new Frm_OptimizeLeaves().ShowDialog();
            Show_Leaves();
        }
    }
}

