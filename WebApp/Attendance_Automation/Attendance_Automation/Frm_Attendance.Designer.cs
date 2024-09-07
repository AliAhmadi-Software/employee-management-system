namespace Attendance_Automation
{
    partial class Frm_Attendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.cmb_SearchByPersonel = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btn_Search = new System.Windows.Forms.PictureBox();
            this.persianUntilDate_Search = new BPersianCalender.BPersianCalenderTextBox();
            this.persianFromDate_Search = new BPersianCalender.BPersianCalenderTextBox();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtSearchByFamily = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSearchByID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.grd_Attendance = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.col_attendanceid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_radif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_personelid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_attendancedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_entertime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_leavetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_datesubmit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctm_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctm_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_ShowOptimizationForm = new DevComponents.DotNetBar.ButtonX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txt_LeaveTime = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.picbox_personel = new System.Windows.Forms.PictureBox();
            this.PersianCalander_DateAttendance = new BPersianCalender.BPersianCalenderTextBox();
            this.cmb_Personels = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btn_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.btn_EditFinal = new DevComponents.DotNetBar.ButtonX();
            this.btn_AddAttendance = new DevComponents.DotNetBar.ButtonX();
            this.txt_Description = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txt_EnterTime = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txt_Personelid = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.lbl_AttendanceId = new DevComponents.DotNetBar.LabelX();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Attendance)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_personel)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.line1);
            this.groupPanel2.Controls.Add(this.cmb_SearchByPersonel);
            this.groupPanel2.Controls.Add(this.btn_Search);
            this.groupPanel2.Controls.Add(this.persianUntilDate_Search);
            this.groupPanel2.Controls.Add(this.persianFromDate_Search);
            this.groupPanel2.Controls.Add(this.labelX9);
            this.groupPanel2.Controls.Add(this.labelX5);
            this.groupPanel2.Controls.Add(this.txtSearchByFamily);
            this.groupPanel2.Controls.Add(this.txtSearchByID);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel2.Location = new System.Drawing.Point(12, 249);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(983, 89);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 2;
            this.groupPanel2.Text = "بخش جست وجو";
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(714, -16);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(23, 81);
            this.line1.TabIndex = 23;
            this.line1.Text = "line1";
            this.line1.VerticalLine = true;
            // 
            // cmb_SearchByPersonel
            // 
            this.cmb_SearchByPersonel.DisplayMember = "Text";
            this.cmb_SearchByPersonel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_SearchByPersonel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SearchByPersonel.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb_SearchByPersonel.FormattingEnabled = true;
            this.cmb_SearchByPersonel.ItemHeight = 26;
            this.cmb_SearchByPersonel.Location = new System.Drawing.Point(550, 22);
            this.cmb_SearchByPersonel.Name = "cmb_SearchByPersonel";
            this.cmb_SearchByPersonel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_SearchByPersonel.Size = new System.Drawing.Size(156, 32);
            this.cmb_SearchByPersonel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_SearchByPersonel.TabIndex = 2;
            // 
            // btn_Search
            // 
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Image = global::Attendance_Automation.Properties.Resources.search_icon;
            this.btn_Search.Location = new System.Drawing.Point(9, 10);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(61, 50);
            this.btn_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Search.TabIndex = 14;
            this.btn_Search.TabStop = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // persianUntilDate_Search
            // 
            this.persianUntilDate_Search.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.persianUntilDate_Search.Location = new System.Drawing.Point(81, 20);
            this.persianUntilDate_Search.Miladi = new System.DateTime(((long)(0)));
            this.persianUntilDate_Search.Name = "persianUntilDate_Search";
            this.persianUntilDate_Search.NowDateSelected = false;
            this.persianUntilDate_Search.ReadOnly = true;
            this.persianUntilDate_Search.SelectedDate = null;
            this.persianUntilDate_Search.Shamsi = null;
            this.persianUntilDate_Search.Size = new System.Drawing.Size(160, 32);
            this.persianUntilDate_Search.TabIndex = 4;
            // 
            // persianFromDate_Search
            // 
            this.persianFromDate_Search.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.persianFromDate_Search.Location = new System.Drawing.Point(309, 20);
            this.persianFromDate_Search.Miladi = new System.DateTime(((long)(0)));
            this.persianFromDate_Search.Name = "persianFromDate_Search";
            this.persianFromDate_Search.NowDateSelected = false;
            this.persianFromDate_Search.ReadOnly = true;
            this.persianFromDate_Search.SelectedDate = null;
            this.persianFromDate_Search.Shamsi = null;
            this.persianFromDate_Search.Size = new System.Drawing.Size(160, 32);
            this.persianFromDate_Search.TabIndex = 3;
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX9.Location = new System.Drawing.Point(225, 23);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(75, 23);
            this.labelX9.TabIndex = 5;
            this.labelX9.Text = "تا تاریخ : ";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX5.Location = new System.Drawing.Point(447, 23);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 4;
            this.labelX5.Text = "از تاریخ : ";
            // 
            // txtSearchByFamily
            // 
            // 
            // 
            // 
            this.txtSearchByFamily.Border.Class = "TextBoxBorder";
            this.txtSearchByFamily.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearchByFamily.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearchByFamily.Location = new System.Drawing.Point(743, 22);
            this.txtSearchByFamily.Name = "txtSearchByFamily";
            this.txtSearchByFamily.PreventEnterBeep = true;
            this.txtSearchByFamily.Size = new System.Drawing.Size(125, 32);
            this.txtSearchByFamily.TabIndex = 1;
            this.txtSearchByFamily.WatermarkText = "نام خانوادگی";
            this.txtSearchByFamily.TextChanged += new System.EventHandler(this.txtSearchByFamily_TextChanged);
            // 
            // txtSearchByID
            // 
            // 
            // 
            // 
            this.txtSearchByID.Border.Class = "TextBoxBorder";
            this.txtSearchByID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearchByID.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearchByID.Location = new System.Drawing.Point(874, 22);
            this.txtSearchByID.Name = "txtSearchByID";
            this.txtSearchByID.PreventEnterBeep = true;
            this.txtSearchByID.Size = new System.Drawing.Size(98, 32);
            this.txtSearchByID.TabIndex = 0;
            this.txtSearchByID.WatermarkText = "کد پرسنلی";
            this.txtSearchByID.TextChanged += new System.EventHandler(this.txtSearchByID_TextChanged);
            this.txtSearchByID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchByID_KeyPress);
            // 
            // grd_Attendance
            // 
            this.grd_Attendance.AllowUserToAddRows = false;
            this.grd_Attendance.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Attendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_Attendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Attendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_attendanceid,
            this.col_radif,
            this.col_personelid,
            this.col_fullname,
            this.col_attendancedate,
            this.col_entertime,
            this.col_leavetime,
            this.col_datesubmit,
            this.col_description});
            this.grd_Attendance.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_Attendance.DefaultCellStyle = dataGridViewCellStyle2;
            this.grd_Attendance.EnableHeadersVisualStyles = false;
            this.grd_Attendance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grd_Attendance.Location = new System.Drawing.Point(16, 356);
            this.grd_Attendance.MultiSelect = false;
            this.grd_Attendance.Name = "grd_Attendance";
            this.grd_Attendance.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Attendance.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grd_Attendance.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grd_Attendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_Attendance.Size = new System.Drawing.Size(967, 246);
            this.grd_Attendance.TabIndex = 3;
            // 
            // col_attendanceid
            // 
            this.col_attendanceid.DataPropertyName = "AttendanceID";
            this.col_attendanceid.HeaderText = "attendanceid";
            this.col_attendanceid.Name = "col_attendanceid";
            this.col_attendanceid.ReadOnly = true;
            this.col_attendanceid.Visible = false;
            // 
            // col_radif
            // 
            this.col_radif.HeaderText = "ردیف";
            this.col_radif.Name = "col_radif";
            this.col_radif.ReadOnly = true;
            this.col_radif.Width = 50;
            // 
            // col_personelid
            // 
            this.col_personelid.DataPropertyName = "PersonelId_FK";
            this.col_personelid.HeaderText = "کد پرسنلی";
            this.col_personelid.Name = "col_personelid";
            this.col_personelid.ReadOnly = true;
            this.col_personelid.Width = 80;
            // 
            // col_fullname
            // 
            this.col_fullname.DataPropertyName = "FullName";
            this.col_fullname.HeaderText = "کارمند";
            this.col_fullname.Name = "col_fullname";
            this.col_fullname.ReadOnly = true;
            this.col_fullname.Width = 140;
            // 
            // col_attendancedate
            // 
            this.col_attendancedate.DataPropertyName = "AttendanceDate";
            this.col_attendancedate.HeaderText = "تاریخ";
            this.col_attendancedate.Name = "col_attendancedate";
            this.col_attendancedate.ReadOnly = true;
            // 
            // col_entertime
            // 
            this.col_entertime.DataPropertyName = "Enter_Time";
            this.col_entertime.HeaderText = "ساعت ورود";
            this.col_entertime.Name = "col_entertime";
            this.col_entertime.ReadOnly = true;
            this.col_entertime.Width = 80;
            // 
            // col_leavetime
            // 
            this.col_leavetime.DataPropertyName = "Leave_Time";
            this.col_leavetime.HeaderText = "ساعت خروج";
            this.col_leavetime.Name = "col_leavetime";
            this.col_leavetime.ReadOnly = true;
            this.col_leavetime.Width = 80;
            // 
            // col_datesubmit
            // 
            this.col_datesubmit.DataPropertyName = "Date_Submit";
            this.col_datesubmit.HeaderText = "تاریخ ثبت";
            this.col_datesubmit.Name = "col_datesubmit";
            this.col_datesubmit.ReadOnly = true;
            this.col_datesubmit.Width = 120;
            // 
            // col_description
            // 
            this.col_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_description.DataPropertyName = "Description";
            this.col_description.HeaderText = "توضیحات";
            this.col_description.Name = "col_description";
            this.col_description.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctm_edit,
            this.ctm_delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 52);
            // 
            // ctm_edit
            // 
            this.ctm_edit.Image = global::Attendance_Automation.Properties.Resources.Edit;
            this.ctm_edit.Name = "ctm_edit";
            this.ctm_edit.Size = new System.Drawing.Size(117, 24);
            this.ctm_edit.Text = "ویرایش";
            this.ctm_edit.Click += new System.EventHandler(this.ctm_edit_Click);
            // 
            // ctm_delete
            // 
            this.ctm_delete.Image = global::Attendance_Automation.Properties.Resources.DeleteRed;
            this.ctm_delete.Name = "ctm_delete";
            this.ctm_delete.Size = new System.Drawing.Size(117, 24);
            this.ctm_delete.Text = "حذف";
            this.ctm_delete.Click += new System.EventHandler(this.ctm_delete_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btn_ShowOptimizationForm);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.txt_LeaveTime);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.picbox_personel);
            this.groupPanel1.Controls.Add(this.PersianCalander_DateAttendance);
            this.groupPanel1.Controls.Add(this.cmb_Personels);
            this.groupPanel1.Controls.Add(this.btn_Cancel);
            this.groupPanel1.Controls.Add(this.btn_EditFinal);
            this.groupPanel1.Controls.Add(this.btn_AddAttendance);
            this.groupPanel1.Controls.Add(this.txt_Description);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.txt_EnterTime);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.txt_Personelid);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(7, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(989, 223);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            // 
            // btn_ShowOptimizationForm
            // 
            this.btn_ShowOptimizationForm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ShowOptimizationForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ShowOptimizationForm.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btn_ShowOptimizationForm.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_ShowOptimizationForm.ImageTextSpacing = 2;
            this.btn_ShowOptimizationForm.Location = new System.Drawing.Point(332, 168);
            this.btn_ShowOptimizationForm.Name = "btn_ShowOptimizationForm";
            this.btn_ShowOptimizationForm.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_ShowOptimizationForm.Size = new System.Drawing.Size(167, 38);
            this.btn_ShowOptimizationForm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ShowOptimizationForm.TabIndex = 15;
            this.btn_ShowOptimizationForm.Text = "بهینه سازی پایگاه داده";
            this.btn_ShowOptimizationForm.Click += new System.EventHandler(this.btn_ShowOptimizationForm_Click);
            // 
            // labelX8
            // 
            this.labelX8.AutoSize = true;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX8.FontBold = true;
            this.labelX8.Location = new System.Drawing.Point(880, 118);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(50, 27);
            this.labelX8.TabIndex = 10;
            this.labelX8.Text = "تاریخ  : ";
            // 
            // txt_LeaveTime
            // 
            // 
            // 
            // 
            this.txt_LeaveTime.Border.Class = "TextBoxBorder";
            this.txt_LeaveTime.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_LeaveTime.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_LeaveTime.Location = new System.Drawing.Point(152, 16);
            this.txt_LeaveTime.MaxLength = 5;
            this.txt_LeaveTime.Name = "txt_LeaveTime";
            this.txt_LeaveTime.PreventEnterBeep = true;
            this.txt_LeaveTime.Size = new System.Drawing.Size(92, 32);
            this.txt_LeaveTime.TabIndex = 7;
            this.txt_LeaveTime.WatermarkText = "00:00";
            this.txt_LeaveTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_LeaveTime_KeyPress);
            this.txt_LeaveTime.Leave += new System.EventHandler(this.txt_LeaveTime_Leave);
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX7.FontBold = true;
            this.labelX7.Location = new System.Drawing.Point(240, 21);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(87, 27);
            this.labelX7.TabIndex = 6;
            this.labelX7.Text = "ساعت خروج : ";
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX6.FontBold = true;
            this.labelX6.Location = new System.Drawing.Point(35, 16);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 27);
            this.labelX6.TabIndex = 19;
            this.labelX6.Text = "تصویر کارمند";
            // 
            // picbox_personel
            // 
            this.picbox_personel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbox_personel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox_personel.Location = new System.Drawing.Point(6, 54);
            this.picbox_personel.Name = "picbox_personel";
            this.picbox_personel.Size = new System.Drawing.Size(125, 130);
            this.picbox_personel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_personel.TabIndex = 18;
            this.picbox_personel.TabStop = false;
            // 
            // PersianCalander_DateAttendance
            // 
            this.PersianCalander_DateAttendance.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PersianCalander_DateAttendance.Location = new System.Drawing.Point(721, 118);
            this.PersianCalander_DateAttendance.Miladi = new System.DateTime(((long)(0)));
            this.PersianCalander_DateAttendance.Name = "PersianCalander_DateAttendance";
            this.PersianCalander_DateAttendance.NowDateSelected = false;
            this.PersianCalander_DateAttendance.ReadOnly = true;
            this.PersianCalander_DateAttendance.SelectedDate = null;
            this.PersianCalander_DateAttendance.Shamsi = null;
            this.PersianCalander_DateAttendance.Size = new System.Drawing.Size(160, 32);
            this.PersianCalander_DateAttendance.TabIndex = 11;
            // 
            // cmb_Personels
            // 
            this.cmb_Personels.DisplayMember = "Text";
            this.cmb_Personels.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Personels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Personels.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb_Personels.FormattingEnabled = true;
            this.cmb_Personels.ItemHeight = 26;
            this.cmb_Personels.Location = new System.Drawing.Point(721, 16);
            this.cmb_Personels.Name = "cmb_Personels";
            this.cmb_Personels.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Personels.Size = new System.Drawing.Size(156, 32);
            this.cmb_Personels.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_Personels.TabIndex = 1;
            this.cmb_Personels.SelectedIndexChanged += new System.EventHandler(this.cmb_Personels_SelectedIndexChanged);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Cancel.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Cancel.ImageTextSpacing = 2;
            this.btn_Cancel.Location = new System.Drawing.Point(529, 168);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_Cancel.Size = new System.Drawing.Size(115, 38);
            this.btn_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Cancel.Symbol = "";
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "بستن";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_EditFinal
            // 
            this.btn_EditFinal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_EditFinal.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_EditFinal.Enabled = false;
            this.btn_EditFinal.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_EditFinal.ImageTextSpacing = 2;
            this.btn_EditFinal.Location = new System.Drawing.Point(653, 168);
            this.btn_EditFinal.Name = "btn_EditFinal";
            this.btn_EditFinal.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_EditFinal.Size = new System.Drawing.Size(115, 38);
            this.btn_EditFinal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_EditFinal.Symbol = "";
            this.btn_EditFinal.TabIndex = 13;
            this.btn_EditFinal.Text = "ویرایش نهایی";
            this.btn_EditFinal.Click += new System.EventHandler(this.btn_EditFinal_Click);
            // 
            // btn_AddAttendance
            // 
            this.btn_AddAttendance.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_AddAttendance.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_AddAttendance.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_AddAttendance.ImageTextSpacing = 2;
            this.btn_AddAttendance.Location = new System.Drawing.Point(780, 168);
            this.btn_AddAttendance.Name = "btn_AddAttendance";
            this.btn_AddAttendance.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_AddAttendance.Size = new System.Drawing.Size(108, 38);
            this.btn_AddAttendance.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_AddAttendance.Symbol = "";
            this.btn_AddAttendance.TabIndex = 12;
            this.btn_AddAttendance.Text = "ثبت";
            this.btn_AddAttendance.Click += new System.EventHandler(this.btn_AddAttendance_Click);
            // 
            // txt_Description
            // 
            // 
            // 
            // 
            this.txt_Description.Border.Class = "TextBoxBorder";
            this.txt_Description.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Description.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Description.Location = new System.Drawing.Point(239, 65);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.PreventEnterBeep = true;
            this.txt_Description.Size = new System.Drawing.Size(642, 32);
            this.txt_Description.TabIndex = 9;
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX4.FontBold = true;
            this.labelX4.Location = new System.Drawing.Point(879, 64);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(70, 27);
            this.labelX4.TabIndex = 8;
            this.labelX4.Text = "توضیحات : ";
            // 
            // txt_EnterTime
            // 
            // 
            // 
            // 
            this.txt_EnterTime.Border.Class = "TextBoxBorder";
            this.txt_EnterTime.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_EnterTime.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_EnterTime.Location = new System.Drawing.Point(333, 16);
            this.txt_EnterTime.MaxLength = 5;
            this.txt_EnterTime.Name = "txt_EnterTime";
            this.txt_EnterTime.PreventEnterBeep = true;
            this.txt_EnterTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_EnterTime.Size = new System.Drawing.Size(92, 32);
            this.txt_EnterTime.TabIndex = 5;
            this.txt_EnterTime.WatermarkText = "00:00";
            this.txt_EnterTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_EnterTime_KeyPress);
            this.txt_EnterTime.Leave += new System.EventHandler(this.txt_EnterTime_Leave);
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX3.FontBold = true;
            this.labelX3.Location = new System.Drawing.Point(419, 21);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(80, 27);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "ساعت ورود : ";
            // 
            // txt_Personelid
            // 
            // 
            // 
            // 
            this.txt_Personelid.Border.Class = "TextBoxBorder";
            this.txt_Personelid.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Personelid.Enabled = false;
            this.txt_Personelid.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Personelid.Location = new System.Drawing.Point(517, 16);
            this.txt_Personelid.Name = "txt_Personelid";
            this.txt_Personelid.PreventEnterBeep = true;
            this.txt_Personelid.Size = new System.Drawing.Size(111, 32);
            this.txt_Personelid.TabIndex = 3;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX2.FontBold = true;
            this.labelX2.Location = new System.Drawing.Point(626, 21);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 27);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "کد پرسنلی : ";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX1.FontBold = true;
            this.labelX1.Location = new System.Drawing.Point(880, 21);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(93, 27);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "انتخاب کارمند : ";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.groupPanel2);
            this.panelEx1.Controls.Add(this.lbl_AttendanceId);
            this.panelEx1.Controls.Add(this.grd_Attendance);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1008, 628);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 4;
            // 
            // lbl_AttendanceId
            // 
            // 
            // 
            // 
            this.lbl_AttendanceId.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_AttendanceId.Location = new System.Drawing.Point(1057, 88);
            this.lbl_AttendanceId.Name = "lbl_AttendanceId";
            this.lbl_AttendanceId.Size = new System.Drawing.Size(75, 23);
            this.lbl_AttendanceId.TabIndex = 3;
            this.lbl_AttendanceId.Text = "label_attendanceid";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // Frm_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 628);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_Attendance";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم  کنترل ورود و خروج کارمندان";
            this.Load += new System.EventHandler(this.Frm_Attendance_Load);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Attendance)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_personel)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_SearchByPersonel;
        private System.Windows.Forms.PictureBox btn_Search;
        private BPersianCalender.BPersianCalenderTextBox persianUntilDate_Search;
        private BPersianCalender.BPersianCalenderTextBox persianFromDate_Search;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearchByFamily;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearchByID;
        private DevComponents.DotNetBar.Controls.DataGridViewX grd_Attendance;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btn_ShowOptimizationForm;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_LeaveTime;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.PictureBox picbox_personel;
        private BPersianCalender.BPersianCalenderTextBox PersianCalander_DateAttendance;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_Personels;
        private DevComponents.DotNetBar.ButtonX btn_Cancel;
        private DevComponents.DotNetBar.ButtonX btn_EditFinal;
        private DevComponents.DotNetBar.ButtonX btn_AddAttendance;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Description;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_EnterTime;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Personelid;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX lbl_AttendanceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_attendanceid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_radif;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_personelid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_attendancedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_entertime;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_leavetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_datesubmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_description;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctm_edit;
        private System.Windows.Forms.ToolStripMenuItem ctm_delete;
    }
}