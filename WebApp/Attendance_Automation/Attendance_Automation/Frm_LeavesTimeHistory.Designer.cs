namespace Attendance_Automation
{
    partial class Frm_LeavesTimeHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Report = new DevComponents.DotNetBar.ButtonX();
            this.btn_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbl_fromDate = new DevComponents.DotNetBar.LabelX();
            this.lbl_personel = new DevComponents.DotNetBar.LabelX();
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.grd_LeavesTimeHistory = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_description2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReport = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbl_leaveDate = new DevComponents.DotNetBar.LabelX();
            this.lbl_PersonelName = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_LeaveTime)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_LeavesTimeHistory)).BeginInit();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Report
            // 
            this.btn_Report.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Report.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Report.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Report.ImageTextSpacing = 2;
            this.btn_Report.Location = new System.Drawing.Point(197, 447);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_Report.Size = new System.Drawing.Size(115, 38);
            this.btn_Report.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Report.Symbol = "";
            this.btn_Report.TabIndex = 24;
            this.btn_Report.Text = "گزارش";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Cancel.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Cancel.ImageTextSpacing = 2;
            this.btn_Cancel.Location = new System.Drawing.Point(352, 447);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_Cancel.Size = new System.Drawing.Size(115, 38);
            this.btn_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Cancel.Symbol = "";
            this.btn_Cancel.TabIndex = 23;
            this.btn_Cancel.Text = "بستن";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.lbl_fromDate);
            this.groupPanel1.Controls.Add(this.lbl_personel);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(637, 158);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
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
            this.groupPanel1.TabIndex = 25;
            this.groupPanel1.Text = "اطلاعات";
            // 
            // lbl_fromDate
            // 
            this.lbl_fromDate.AutoSize = true;
            // 
            // 
            // 
            this.lbl_fromDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_fromDate.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_fromDate.FontBold = true;
            this.lbl_fromDate.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_fromDate.Location = new System.Drawing.Point(182, 52);
            this.lbl_fromDate.Name = "lbl_fromDate";
            this.lbl_fromDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_fromDate.Size = new System.Drawing.Size(79, 27);
            this.lbl_fromDate.TabIndex = 23;
            this.lbl_fromDate.Text = "تاریخ مرخصی";
            // 
            // lbl_personel
            // 
            this.lbl_personel.AutoSize = true;
            // 
            // 
            // 
            this.lbl_personel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_personel.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_personel.FontBold = true;
            this.lbl_personel.Location = new System.Drawing.Point(208, 3);
            this.lbl_personel.Name = "lbl_personel";
            this.lbl_personel.Size = new System.Drawing.Size(197, 27);
            this.lbl_personel.TabIndex = 22;
            this.lbl_personel.Text = "سوابق مرخصی های روزانه کارمند ...";
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
            this.grd_LeaveTime.Location = new System.Drawing.Point(21, 177);
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
            this.grd_LeaveTime.Size = new System.Drawing.Size(611, 264);
            this.grd_LeaveTime.TabIndex = 26;
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
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.grd_LeavesTimeHistory);
            this.panelEx1.Controls.Add(this.btnReport);
            this.panelEx1.Controls.Add(this.btnClose);
            this.panelEx1.Controls.Add(this.groupPanel2);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(758, 536);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 30;
            // 
            // grd_LeavesTimeHistory
            // 
            this.grd_LeavesTimeHistory.AllowUserToAddRows = false;
            this.grd_LeavesTimeHistory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_LeavesTimeHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grd_LeavesTimeHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_LeavesTimeHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.col_description2});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_LeavesTimeHistory.DefaultCellStyle = dataGridViewCellStyle6;
            this.grd_LeavesTimeHistory.EnableHeadersVisualStyles = false;
            this.grd_LeavesTimeHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grd_LeavesTimeHistory.Location = new System.Drawing.Point(12, 149);
            this.grd_LeavesTimeHistory.MultiSelect = false;
            this.grd_LeavesTimeHistory.Name = "grd_LeavesTimeHistory";
            this.grd_LeavesTimeHistory.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_LeavesTimeHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grd_LeavesTimeHistory.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.grd_LeavesTimeHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_LeavesTimeHistory.Size = new System.Drawing.Size(734, 316);
            this.grd_LeavesTimeHistory.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "LeaveTimeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "leaveid";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "ردیف";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PersonelId_FK";
            this.dataGridViewTextBoxColumn3.HeaderText = "کد پرسنلی";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "From_Hours";
            this.dataGridViewTextBoxColumn5.HeaderText = "از ساعت";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Until_Hours";
            this.dataGridViewTextBoxColumn6.HeaderText = "تا ساعت";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "LeaveDate";
            this.dataGridViewTextBoxColumn8.HeaderText = "تاریخ مرخصی";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 106;
            // 
            // col_description2
            // 
            this.col_description2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_description2.DataPropertyName = "Description";
            this.col_description2.HeaderText = "توضیحات";
            this.col_description2.Name = "col_description2";
            this.col_description2.ReadOnly = true;
            // 
            // btnReport
            // 
            this.btnReport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReport.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnReport.ImageTextSpacing = 2;
            this.btnReport.Location = new System.Drawing.Point(231, 486);
            this.btnReport.Name = "btnReport";
            this.btnReport.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btnReport.Size = new System.Drawing.Size(115, 38);
            this.btnReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReport.Symbol = "";
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "گزارش";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.ImageTextSpacing = 2;
            this.btnClose.Location = new System.Drawing.Point(386, 486);
            this.btnClose.Name = "btnClose";
            this.btnClose.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btnClose.Size = new System.Drawing.Size(115, 38);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.Symbol = "";
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "بستن";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.lbl_leaveDate);
            this.groupPanel2.Controls.Add(this.lbl_PersonelName);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupPanel2.Location = new System.Drawing.Point(11, 3);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(735, 127);
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
            this.groupPanel2.TabIndex = 22;
            this.groupPanel2.Text = "اطلاعات";
            // 
            // lbl_leaveDate
            // 
            this.lbl_leaveDate.AutoSize = true;
            // 
            // 
            // 
            this.lbl_leaveDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_leaveDate.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_leaveDate.FontBold = true;
            this.lbl_leaveDate.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_leaveDate.Location = new System.Drawing.Point(268, 61);
            this.lbl_leaveDate.Name = "lbl_leaveDate";
            this.lbl_leaveDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_leaveDate.Size = new System.Drawing.Size(79, 27);
            this.lbl_leaveDate.TabIndex = 23;
            this.lbl_leaveDate.Text = "تاریخ مرخصی";
            // 
            // lbl_PersonelName
            // 
            this.lbl_PersonelName.AutoSize = true;
            // 
            // 
            // 
            this.lbl_PersonelName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_PersonelName.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_PersonelName.FontBold = true;
            this.lbl_PersonelName.Location = new System.Drawing.Point(294, 12);
            this.lbl_PersonelName.Name = "lbl_PersonelName";
            this.lbl_PersonelName.Size = new System.Drawing.Size(197, 27);
            this.lbl_PersonelName.TabIndex = 22;
            this.lbl_PersonelName.Text = "سوابق مرخصی های روزانه کارمند ...";
            // 
            // Frm_LeavesTimeHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 536);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.grd_LeaveTime);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.groupPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_LeavesTimeHistory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم سوابق مرخصی ساعتی کارمند";
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_LeaveTime)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_LeavesTimeHistory)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.ButtonX btn_Report;
        private DevComponents.DotNetBar.ButtonX btn_Cancel;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        public DevComponents.DotNetBar.LabelX lbl_fromDate;
        public DevComponents.DotNetBar.LabelX lbl_personel;
        private DevComponents.DotNetBar.Controls.DataGridViewX grd_LeaveTime;
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
        private DevComponents.DotNetBar.PanelEx panelEx1;
        public DevComponents.DotNetBar.ButtonX btnReport;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        public DevComponents.DotNetBar.LabelX lbl_leaveDate;
        public DevComponents.DotNetBar.LabelX lbl_PersonelName;
        public DevComponents.DotNetBar.Controls.DataGridViewX grd_LeavesTimeHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_description2;
    }
}