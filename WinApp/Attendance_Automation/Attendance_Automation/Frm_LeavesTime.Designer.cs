namespace Attendance_Automation
{
    partial class Frm_LeavesTime
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.cmb_SearchByPersonel = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.persianUntilDate_Search = new BPersianCalender.BPersianCalenderTextBox();
            this.persianFromDate_Search = new BPersianCalender.BPersianCalenderTextBox();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.txtSearchByFamily = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSearchByID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_leaveId = new System.Windows.Forms.Label();
            this.grd_LeaveTime = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.col_leavetimeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_radif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_personelid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fromhours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_untilhours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_differencetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_leavedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_datesubmit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_ShowOptimizationForm = new DevComponents.DotNetBar.ButtonX();
            this.txt_UntilHours = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_FromHours = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txt_Description = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txt_DiffrenceTime = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.PersianCalander_LeaveDate = new BPersianCalender.BPersianCalenderTextBox();
            this.cmb_Personels = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btn_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.btn_EditFinal = new DevComponents.DotNetBar.ButtonX();
            this.btn_AddLeaveTime = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txt_Personelid = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctm_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctm_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Search = new System.Windows.Forms.PictureBox();
            this.picbox_personel = new System.Windows.Forms.PictureBox();
            this.panelEx1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_LeaveTime)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_personel)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.groupPanel2);
            this.panelEx1.Controls.Add(this.lbl_leaveId);
            this.panelEx1.Controls.Add(this.grd_LeaveTime);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(967, 608);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 16;
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
            this.groupPanel2.Controls.Add(this.labelX10);
            this.groupPanel2.Controls.Add(this.txtSearchByFamily);
            this.groupPanel2.Controls.Add(this.txtSearchByID);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel2.Location = new System.Drawing.Point(12, 241);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(938, 85);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
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
            this.groupPanel2.TabIndex = 1;
            this.groupPanel2.Text = "بخش جست وجو";
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(683, -5);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(23, 81);
            this.line1.TabIndex = 29;
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
            this.cmb_SearchByPersonel.Location = new System.Drawing.Point(531, 16);
            this.cmb_SearchByPersonel.Name = "cmb_SearchByPersonel";
            this.cmb_SearchByPersonel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_SearchByPersonel.Size = new System.Drawing.Size(156, 32);
            this.cmb_SearchByPersonel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_SearchByPersonel.TabIndex = 2;
            // 
            // persianUntilDate_Search
            // 
            this.persianUntilDate_Search.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.persianUntilDate_Search.Location = new System.Drawing.Point(85, 16);
            this.persianUntilDate_Search.Miladi = new System.DateTime(((long)(0)));
            this.persianUntilDate_Search.Name = "persianUntilDate_Search";
            this.persianUntilDate_Search.NowDateSelected = false;
            this.persianUntilDate_Search.ReadOnly = true;
            this.persianUntilDate_Search.SelectedDate = null;
            this.persianUntilDate_Search.Shamsi = null;
            this.persianUntilDate_Search.Size = new System.Drawing.Size(156, 32);
            this.persianUntilDate_Search.TabIndex = 6;
            // 
            // persianFromDate_Search
            // 
            this.persianFromDate_Search.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.persianFromDate_Search.Location = new System.Drawing.Point(312, 16);
            this.persianFromDate_Search.Miladi = new System.DateTime(((long)(0)));
            this.persianFromDate_Search.Name = "persianFromDate_Search";
            this.persianFromDate_Search.NowDateSelected = false;
            this.persianFromDate_Search.ReadOnly = true;
            this.persianFromDate_Search.SelectedDate = null;
            this.persianFromDate_Search.Shamsi = null;
            this.persianFromDate_Search.Size = new System.Drawing.Size(150, 32);
            this.persianFromDate_Search.TabIndex = 4;
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX9.Location = new System.Drawing.Point(220, 21);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(75, 23);
            this.labelX9.TabIndex = 5;
            this.labelX9.Text = "تا تاریخ : ";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX10.Location = new System.Drawing.Point(441, 20);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(75, 23);
            this.labelX10.TabIndex = 3;
            this.labelX10.Text = "از تاریخ : ";
            // 
            // txtSearchByFamily
            // 
            // 
            // 
            // 
            this.txtSearchByFamily.Border.Class = "TextBoxBorder";
            this.txtSearchByFamily.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearchByFamily.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearchByFamily.Location = new System.Drawing.Point(679, 17);
            this.txtSearchByFamily.Name = "txtSearchByFamily";
            this.txtSearchByFamily.PreventEnterBeep = true;
            this.txtSearchByFamily.Size = new System.Drawing.Size(131, 32);
            this.txtSearchByFamily.TabIndex = 1;
            this.txtSearchByFamily.WatermarkText = " نام خانوادگی";
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
            this.txtSearchByID.Location = new System.Drawing.Point(827, 17);
            this.txtSearchByID.Name = "txtSearchByID";
            this.txtSearchByID.PreventEnterBeep = true;
            this.txtSearchByID.Size = new System.Drawing.Size(96, 32);
            this.txtSearchByID.TabIndex = 0;
            this.txtSearchByID.WatermarkText = "کد پرسنلی";
            this.txtSearchByID.TextChanged += new System.EventHandler(this.txtSearchByID_TextChanged);
            this.txtSearchByID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchByID_KeyPress);
            // 
            // lbl_leaveId
            // 
            this.lbl_leaveId.AutoSize = true;
            this.lbl_leaveId.Location = new System.Drawing.Point(1049, 33);
            this.lbl_leaveId.Name = "lbl_leaveId";
            this.lbl_leaveId.Size = new System.Drawing.Size(16, 13);
            this.lbl_leaveId.TabIndex = 3;
            this.lbl_leaveId.Text = "---";
            // 
            // grd_LeaveTime
            // 
            this.grd_LeaveTime.AllowUserToAddRows = false;
            this.grd_LeaveTime.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_LeaveTime.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_LeaveTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_LeaveTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_leavetimeid,
            this.col_radif,
            this.col_personelid,
            this.col_fullname,
            this.col_fromhours,
            this.col_untilhours,
            this.col_differencetime,
            this.col_leavedate,
            this.col_description,
            this.col_datesubmit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_LeaveTime.DefaultCellStyle = dataGridViewCellStyle2;
            this.grd_LeaveTime.EnableHeadersVisualStyles = false;
            this.grd_LeaveTime.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grd_LeaveTime.Location = new System.Drawing.Point(12, 332);
            this.grd_LeaveTime.MultiSelect = false;
            this.grd_LeaveTime.Name = "grd_LeaveTime";
            this.grd_LeaveTime.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_LeaveTime.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grd_LeaveTime.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grd_LeaveTime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_LeaveTime.Size = new System.Drawing.Size(931, 264);
            this.grd_LeaveTime.TabIndex = 0;
            // 
            // col_leavetimeid
            // 
            this.col_leavetimeid.DataPropertyName = "LeaveTimeID";
            this.col_leavetimeid.HeaderText = "leaveid";
            this.col_leavetimeid.Name = "col_leavetimeid";
            this.col_leavetimeid.ReadOnly = true;
            this.col_leavetimeid.Visible = false;
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
            this.col_personelid.Width = 90;
            // 
            // col_fullname
            // 
            this.col_fullname.DataPropertyName = "FullName";
            this.col_fullname.HeaderText = "کارمند";
            this.col_fullname.Name = "col_fullname";
            this.col_fullname.ReadOnly = true;
            this.col_fullname.Width = 120;
            // 
            // col_fromhours
            // 
            this.col_fromhours.DataPropertyName = "From_Hours";
            this.col_fromhours.HeaderText = "از ساعت";
            this.col_fromhours.Name = "col_fromhours";
            this.col_fromhours.ReadOnly = true;
            // 
            // col_untilhours
            // 
            this.col_untilhours.DataPropertyName = "Until_Hours";
            this.col_untilhours.HeaderText = "تا ساعت";
            this.col_untilhours.Name = "col_untilhours";
            this.col_untilhours.ReadOnly = true;
            // 
            // col_differencetime
            // 
            this.col_differencetime.DataPropertyName = "Difference_Time";
            this.col_differencetime.HeaderText = "اختلاف زمان";
            this.col_differencetime.Name = "col_differencetime";
            this.col_differencetime.ReadOnly = true;
            this.col_differencetime.Width = 80;
            // 
            // col_leavedate
            // 
            this.col_leavedate.DataPropertyName = "LeaveDate";
            this.col_leavedate.HeaderText = "تاریخ مرخصی";
            this.col_leavedate.Name = "col_leavedate";
            this.col_leavedate.ReadOnly = true;
            // 
            // col_description
            // 
            this.col_description.DataPropertyName = "Description";
            this.col_description.HeaderText = "توضیحات";
            this.col_description.Name = "col_description";
            this.col_description.ReadOnly = true;
            this.col_description.Width = 110;
            // 
            // col_datesubmit
            // 
            this.col_datesubmit.DataPropertyName = "Date_Submit";
            this.col_datesubmit.HeaderText = "تاریخ ثبت";
            this.col_datesubmit.Name = "col_datesubmit";
            this.col_datesubmit.ReadOnly = true;
            this.col_datesubmit.Width = 130;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btn_ShowOptimizationForm);
            this.groupPanel1.Controls.Add(this.txt_UntilHours);
            this.groupPanel1.Controls.Add(this.txt_FromHours);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.txt_Description);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.txt_DiffrenceTime);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.picbox_personel);
            this.groupPanel1.Controls.Add(this.PersianCalander_LeaveDate);
            this.groupPanel1.Controls.Add(this.cmb_Personels);
            this.groupPanel1.Controls.Add(this.btn_Cancel);
            this.groupPanel1.Controls.Add(this.btn_EditFinal);
            this.groupPanel1.Controls.Add(this.btn_AddLeaveTime);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.txt_Personelid);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(938, 220);
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
            this.groupPanel1.TabIndex = 1;
            // 
            // btn_ShowOptimizationForm
            // 
            this.btn_ShowOptimizationForm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ShowOptimizationForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ShowOptimizationForm.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btn_ShowOptimizationForm.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_ShowOptimizationForm.ImageTextSpacing = 2;
            this.btn_ShowOptimizationForm.Location = new System.Drawing.Point(156, 158);
            this.btn_ShowOptimizationForm.Name = "btn_ShowOptimizationForm";
            this.btn_ShowOptimizationForm.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_ShowOptimizationForm.Size = new System.Drawing.Size(167, 38);
            this.btn_ShowOptimizationForm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ShowOptimizationForm.TabIndex = 17;
            this.btn_ShowOptimizationForm.Text = "بهینه سازی پایگاه داده";
            this.btn_ShowOptimizationForm.Click += new System.EventHandler(this.btn_ShowOptimizationForm_Click);
            // 
            // txt_UntilHours
            // 
            // 
            // 
            // 
            this.txt_UntilHours.Border.Class = "TextBoxBorder";
            this.txt_UntilHours.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_UntilHours.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_UntilHours.Location = new System.Drawing.Point(582, 59);
            this.txt_UntilHours.MaxLength = 5;
            this.txt_UntilHours.Name = "txt_UntilHours";
            this.txt_UntilHours.PreventEnterBeep = true;
            this.txt_UntilHours.Size = new System.Drawing.Size(78, 32);
            this.txt_UntilHours.TabIndex = 7;
            this.txt_UntilHours.WatermarkText = "00:00";
            this.txt_UntilHours.TextChanged += new System.EventHandler(this.txt_UntilHours_TextChanged);
            this.txt_UntilHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_UntilHours_KeyPress);
            this.txt_UntilHours.Leave += new System.EventHandler(this.txt_UntilHours_Leave);
            // 
            // txt_FromHours
            // 
            // 
            // 
            // 
            this.txt_FromHours.Border.Class = "TextBoxBorder";
            this.txt_FromHours.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_FromHours.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_FromHours.Location = new System.Drawing.Point(745, 58);
            this.txt_FromHours.MaxLength = 5;
            this.txt_FromHours.Name = "txt_FromHours";
            this.txt_FromHours.PreventEnterBeep = true;
            this.txt_FromHours.Size = new System.Drawing.Size(78, 32);
            this.txt_FromHours.TabIndex = 5;
            this.txt_FromHours.WatermarkText = "00:00";
            this.txt_FromHours.TextChanged += new System.EventHandler(this.txt_FromHours_TextChanged);
            this.txt_FromHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_FromHours_KeyPress);
            this.txt_FromHours.Leave += new System.EventHandler(this.txt_FromHours_Leave);
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
            this.labelX8.Location = new System.Drawing.Point(312, 62);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(93, 27);
            this.labelX8.TabIndex = 10;
            this.labelX8.Text = "تاریخ مرخصی : ";
            // 
            // txt_Description
            // 
            // 
            // 
            // 
            this.txt_Description.Border.Class = "TextBoxBorder";
            this.txt_Description.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Description.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Description.Location = new System.Drawing.Point(156, 111);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.PreventEnterBeep = true;
            this.txt_Description.Size = new System.Drawing.Size(667, 32);
            this.txt_Description.TabIndex = 13;
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX5.FontBold = true;
            this.labelX5.Location = new System.Drawing.Point(829, 116);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(70, 27);
            this.labelX5.TabIndex = 12;
            this.labelX5.Text = "توضیحات : ";
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
            this.labelX4.Location = new System.Drawing.Point(485, 63);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(83, 27);
            this.labelX4.TabIndex = 8;
            this.labelX4.Text = "اختلاف زمان : ";
            // 
            // txt_DiffrenceTime
            // 
            // 
            // 
            // 
            this.txt_DiffrenceTime.Border.Class = "TextBoxBorder";
            this.txt_DiffrenceTime.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_DiffrenceTime.Enabled = false;
            this.txt_DiffrenceTime.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_DiffrenceTime.Location = new System.Drawing.Point(415, 59);
            this.txt_DiffrenceTime.MaxLength = 5;
            this.txt_DiffrenceTime.Name = "txt_DiffrenceTime";
            this.txt_DiffrenceTime.PreventEnterBeep = true;
            this.txt_DiffrenceTime.ReadOnly = true;
            this.txt_DiffrenceTime.Size = new System.Drawing.Size(64, 32);
            this.txt_DiffrenceTime.TabIndex = 9;
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
            this.labelX7.Location = new System.Drawing.Point(666, 64);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(65, 27);
            this.labelX7.TabIndex = 6;
            this.labelX7.Text = "تا ساعت : ";
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
            this.labelX6.TabIndex = 18;
            this.labelX6.Text = "تصویر کارمند";
            // 
            // PersianCalander_LeaveDate
            // 
            this.PersianCalander_LeaveDate.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PersianCalander_LeaveDate.Location = new System.Drawing.Point(156, 57);
            this.PersianCalander_LeaveDate.Miladi = new System.DateTime(((long)(0)));
            this.PersianCalander_LeaveDate.Name = "PersianCalander_LeaveDate";
            this.PersianCalander_LeaveDate.NowDateSelected = false;
            this.PersianCalander_LeaveDate.ReadOnly = true;
            this.PersianCalander_LeaveDate.SelectedDate = null;
            this.PersianCalander_LeaveDate.Shamsi = null;
            this.PersianCalander_LeaveDate.Size = new System.Drawing.Size(154, 32);
            this.PersianCalander_LeaveDate.TabIndex = 11;
            // 
            // cmb_Personels
            // 
            this.cmb_Personels.DisplayMember = "Text";
            this.cmb_Personels.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Personels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Personels.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb_Personels.FormattingEnabled = true;
            this.cmb_Personels.ItemHeight = 26;
            this.cmb_Personels.Location = new System.Drawing.Point(667, 11);
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
            this.btn_Cancel.Location = new System.Drawing.Point(463, 158);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_Cancel.Size = new System.Drawing.Size(115, 38);
            this.btn_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Cancel.Symbol = "";
            this.btn_Cancel.TabIndex = 16;
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
            this.btn_EditFinal.Location = new System.Drawing.Point(587, 158);
            this.btn_EditFinal.Name = "btn_EditFinal";
            this.btn_EditFinal.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_EditFinal.Size = new System.Drawing.Size(115, 38);
            this.btn_EditFinal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_EditFinal.Symbol = "";
            this.btn_EditFinal.TabIndex = 15;
            this.btn_EditFinal.Text = "ویرایش نهایی";
            this.btn_EditFinal.Click += new System.EventHandler(this.btn_EditFinal_Click);
            // 
            // btn_AddLeaveTime
            // 
            this.btn_AddLeaveTime.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_AddLeaveTime.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_AddLeaveTime.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_AddLeaveTime.ImageTextSpacing = 2;
            this.btn_AddLeaveTime.Location = new System.Drawing.Point(715, 158);
            this.btn_AddLeaveTime.Name = "btn_AddLeaveTime";
            this.btn_AddLeaveTime.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_AddLeaveTime.Size = new System.Drawing.Size(108, 38);
            this.btn_AddLeaveTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_AddLeaveTime.Symbol = "";
            this.btn_AddLeaveTime.TabIndex = 14;
            this.btn_AddLeaveTime.Text = "ثبت";
            this.btn_AddLeaveTime.Click += new System.EventHandler(this.btn_AddLeaveTime_Click);
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
            this.labelX3.Location = new System.Drawing.Point(825, 63);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(65, 27);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "از ساعت : ";
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
            this.txt_Personelid.Location = new System.Drawing.Point(398, 11);
            this.txt_Personelid.Name = "txt_Personelid";
            this.txt_Personelid.PreventEnterBeep = true;
            this.txt_Personelid.ReadOnly = true;
            this.txt_Personelid.Size = new System.Drawing.Size(160, 32);
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
            this.labelX2.Location = new System.Drawing.Point(556, 16);
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
            this.labelX1.Location = new System.Drawing.Point(826, 16);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(93, 27);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "انتخاب کارمند : ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
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
            // btn_Search
            // 
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Image = global::Attendance_Automation.Properties.Resources.search_icon;
            this.btn_Search.Location = new System.Drawing.Point(13, 1);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(55, 50);
            this.btn_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Search.TabIndex = 27;
            this.btn_Search.TabStop = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
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
            // Frm_LeavesTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 608);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_LeavesTime";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم مرخصی ساعتی کارمندان";
            this.Load += new System.EventHandler(this.Frm_LeavesTime_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_LeaveTime)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_personel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_SearchByPersonel;
        private System.Windows.Forms.PictureBox btn_Search;
        private BPersianCalender.BPersianCalenderTextBox persianUntilDate_Search;
        private BPersianCalender.BPersianCalenderTextBox persianFromDate_Search;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearchByFamily;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearchByID;
        private System.Windows.Forms.Label lbl_leaveId;
        private DevComponents.DotNetBar.Controls.DataGridViewX grd_LeaveTime;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btn_ShowOptimizationForm;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_UntilHours;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_FromHours;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Description;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_DiffrenceTime;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.PictureBox picbox_personel;
        private BPersianCalender.BPersianCalenderTextBox PersianCalander_LeaveDate;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_Personels;
        private DevComponents.DotNetBar.ButtonX btn_Cancel;
        private DevComponents.DotNetBar.ButtonX btn_EditFinal;
        private DevComponents.DotNetBar.ButtonX btn_AddLeaveTime;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Personelid;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctm_edit;
        private System.Windows.Forms.ToolStripMenuItem ctm_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_leavetimeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_radif;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_personelid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fromhours;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_untilhours;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_differencetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_leavedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_datesubmit;
    }
}