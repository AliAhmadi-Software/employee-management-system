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
using Stimulsoft.Report;
using System.Globalization;
using Stimulsoft.Report.Export;
using Stimulsoft.Report.Components;

namespace Attendance_Automation
{
    public partial class Frm_ReportMission : Form
    {
        public bool flagEdit = false;
        Attendance_DBEntities database = new Attendance_DBEntities();
        public Frm_ReportMission()
        {
            InitializeComponent();
        }
        private string ShamsiDate()
        {
            string today = "";
            PersianCalendar pc = new PersianCalendar();
            DateTime dt = DateTime.Now;
            today = pc.GetYear(dt).ToString("0000/") + pc.GetMonth(dt).ToString("00/") + pc.GetDayOfMonth(dt).ToString("00");

            return today;
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_titleReport.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_titleReport, "مقدار الزامی است");
                txt_titleReport.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_noteReport.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_noteReport, "مقدار الزامی است");
                txt_noteReport.Focus();
                return;
            }
            if (flagEdit == true)  // برای ویرایش
            {
                int missionID;
                int.TryParse(txt_docId.Text, out missionID);
                var q = (from rows in database.Tbl_ReportMission where rows.MissionID_FK == missionID select rows).SingleOrDefault();
                if (q != null)
                {
                    q.Title = txt_titleReport.Text;
                    q.Description = txt_noteReport.Text;
                    q.ReportDate = PersianCalender_DateMission.Text;
                }
                database.SaveChanges();
                MessageBox.Show("گزارش با موفقیت تصحیح گردید", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else if (flagEdit == false) // برای ذخیره گزارش جدید
            {
                database.Tbl_ReportMission.Add(new Tbl_ReportMission()
                {
                    Description = txt_noteReport.Text,
                    MissionID_FK = Convert.ToInt32(txt_docId.Text),
                    PersonelID_FK = Convert.ToInt32(txt_personelId.Text),
                    ReportDate = PersianCalender_DateMission.Text,
                    Title = txt_titleReport.Text,

                });
                if (Convert.ToBoolean(database.SaveChanges()))
                {
                    MessageBox.Show("گزارش ماموریت با موفقیت ثبت گردید", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
        }

        private void Frm_ReportMission_Load(object sender, EventArgs e)
        {
            if (flagEdit == false)
            {
                PersianCalender_DateMission.Today_Click(null, null);
            }
            else if (flagEdit == true)
            {
                int missionID;
                int.TryParse(txt_docId.Text, out missionID);
                var q = (from rows in database.Tbl_ReportMission where rows.MissionID_FK == missionID select rows).SingleOrDefault();
                if (q != null)
                {
                    txt_titleReport.Text = q.Title;
                    txt_noteReport.Text = q.Description;
                    PersianCalender_DateMission.Text = q.ReportDate;
                   
                }
            }
            cmb_extensionReport.SelectedIndex = 0;
        }

        private void btn_removeReport_Click(object sender, EventArgs e)
        {
            if (flagEdit == true && txt_docId.Text != string.Empty)
            {
                string titleReport = txt_titleReport.Text;
                int missionID;
                int.TryParse(txt_docId.Text, out missionID);
                var Selected = (from rows in database.Tbl_ReportMission where rows.MissionID_FK == missionID select rows).SingleOrDefault();
                if (Selected != null)
                {
                    DialogResult dr;
                    dr = MessageBox.Show("ایا میخواهید این گزارش را حذف نمایید؟", "حذف گزارش", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        database.Tbl_ReportMission.Remove(Selected);
                        if (Convert.ToBoolean(database.SaveChanges()) == true)
                        {
                            MessageBox.Show("گزارش " + titleReport + " با موفقیت حذف گردید", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();

                        }
                    }
                }

            }
        }
        StiReport report = new StiReport();
        private void btn_Report_Click(object sender, EventArgs e)
        {
            report.Load(Application.StartupPath + @"\report\Report_NoteMission.mrt");
            report.Dictionary.Variables["varDocId"].Value = txt_docId.Text;
            report.Dictionary.Variables["varTitleMission"].Value = txt_titleReport.Text;
            report.Dictionary.Variables["varPrintDate"].Value = ShamsiDate(); report.Dictionary.Variables["varPersonelID"].Value = txt_personelId.Text;
            report.Dictionary.Variables["varPersonelName"].Value = txt_personelName.Text;
            report.Dictionary.Variables["varDateMission"].Value = txt_dateMission.Text;
            report.Dictionary.Variables["varNoteMission"].Value = txt_noteReport.Text;
            report.Compile();
            SaveFileDialog sf = new SaveFileDialog();
            Random rnd = new Random();
            int number = rnd.Next(1000, 9999);
            string filename = "ReportMission_" + number.ToString();
            sf.AddExtension = true;

            sf.FileName = filename;
            sf.Title = "ذخیره فایل گزارش";
            string extension = cmb_extensionReport.Text;
            DialogResult dr = MessageBox.Show("ایا میخواهید یک نسخه از فایل گزارش را در سیستم ذخیره کنید؟", "ذخیره فایل گزارش", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                switch (extension)
                {
                    case "pdf":
                        {
                            sf.DefaultExt = "pdf";
                            sf.ShowDialog();
                            sf.CheckFileExists = true;
                            sf.CheckPathExists = true;
                            report.Render();
                            report.ExportDocument(StiExportFormat.Pdf, sf.FileName);
                            break;
                        }
                    case "jpeg":
                        {
                            sf.DefaultExt = "jpeg";
                            sf.ShowDialog();
                            sf.CheckFileExists = true;
                            sf.CheckPathExists = true;
                            report.Render();
                            report.ExportDocument(StiExportFormat.ImageJpeg, sf.FileName);
                            break;
                        }
                    case "word":
                        {
                            sf.DefaultExt = "doc";
                            sf.ShowDialog();
                            sf.CheckFileExists = true;
                            sf.CheckPathExists = true;
                            report.Render();
                            report.ExportDocument(StiExportFormat.Word2007, sf.FileName);
                            break;
                        }
                    case "excel":
                        {
                            sf.DefaultExt = "xls";
                            sf.ShowDialog();
                            sf.CheckFileExists = true;
                            sf.CheckPathExists = true;
                            report.Render();
                            report.ExportDocument(StiExportFormat.Excel, sf.FileName);
                            break;
                        }
                    default:
                        {
                            sf.DefaultExt = "pdf";
                            sf.ShowDialog();
                            sf.CheckFileExists = true;
                            sf.CheckPathExists = true;
                            report.Render();
                            report.ExportDocument(StiExportFormat.Pdf, sf.FileName);
                            break;
                        }
                }
            }

              report.Show();
        }
    }
}
 