namespace Attendance_Automation
{
    partial class Frm_LeavesHistory
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
            this.btn_Report = new DevComponents.DotNetBar.ButtonX();
            this.grd_LeaveHistory = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.col_leaveid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_radif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_personelid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fromdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_untildate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_differencedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbl_countDayLeaves = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lbl_fromDate = new DevComponents.DotNetBar.LabelX();
            this.lbl_personel = new DevComponents.DotNetBar.LabelX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            ((System.ComponentModel.ISupportInitialize)(this.grd_LeaveHistory)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Report
            // 
            this.btn_Report.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Report.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Report.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Report.ImageTextSpacing = 2;
            this.btn_Report.Location = new System.Drawing.Point(175, 486);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_Report.Size = new System.Drawing.Size(115, 38);
            this.btn_Report.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Report.Symbol = "";
            this.btn_Report.TabIndex = 1;
            this.btn_Report.Text = "گزارش";
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // grd_LeaveHistory
            // 
            this.grd_LeaveHistory.AllowUserToAddRows = false;
            this.grd_LeaveHistory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_LeaveHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_LeaveHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_LeaveHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_leaveid,
            this.col_radif,
            this.col_personelid,
            this.col_fromdate,
            this.col_untildate,
            this.col_differencedate,
            this.col_description});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_LeaveHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.grd_LeaveHistory.EnableHeadersVisualStyles = false;
            this.grd_LeaveHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grd_LeaveHistory.Location = new System.Drawing.Point(11, 167);
            this.grd_LeaveHistory.MultiSelect = false;
            this.grd_LeaveHistory.Name = "grd_LeaveHistory";
            this.grd_LeaveHistory.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_LeaveHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grd_LeaveHistory.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grd_LeaveHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_LeaveHistory.Size = new System.Drawing.Size(613, 311);
            this.grd_LeaveHistory.TabIndex = 24;
            // 
            // col_leaveid
            // 
            this.col_leaveid.DataPropertyName = "LeaveId";
            this.col_leaveid.HeaderText = "leaveid";
            this.col_leaveid.Name = "col_leaveid";
            this.col_leaveid.ReadOnly = true;
            this.col_leaveid.Visible = false;
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
            // col_fromdate
            // 
            this.col_fromdate.DataPropertyName = "From_Date";
            this.col_fromdate.HeaderText = "از تاریخ";
            this.col_fromdate.Name = "col_fromdate";
            this.col_fromdate.ReadOnly = true;
            // 
            // col_untildate
            // 
            this.col_untildate.DataPropertyName = "Until_Date";
            this.col_untildate.HeaderText = "تا تاریخ";
            this.col_untildate.Name = "col_untildate";
            this.col_untildate.ReadOnly = true;
            // 
            // col_differencedate
            // 
            this.col_differencedate.DataPropertyName = "Difference_Date";
            this.col_differencedate.HeaderText = "تعداد روز";
            this.col_differencedate.Name = "col_differencedate";
            this.col_differencedate.ReadOnly = true;
            this.col_differencedate.Width = 80;
            // 
            // col_description
            // 
            this.col_description.DataPropertyName = "Description";
            this.col_description.HeaderText = "توضیحات";
            this.col_description.Name = "col_description";
            this.col_description.ReadOnly = true;
            this.col_description.Width = 150;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Cancel.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Cancel.ImageTextSpacing = 2;
            this.btn_Cancel.Location = new System.Drawing.Point(330, 486);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_Cancel.Size = new System.Drawing.Size(115, 38);
            this.btn_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Cancel.Symbol = "";
            this.btn_Cancel.TabIndex = 0;
            this.btn_Cancel.Text = "بستن";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.lbl_countDayLeaves);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.lbl_fromDate);
            this.groupPanel1.Controls.Add(this.lbl_personel);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupPanel1.Location = new System.Drawing.Point(11, 3);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(613, 158);
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
            this.groupPanel1.TabIndex = 22;
            this.groupPanel1.Text = "اطلاعات";
            // 
            // lbl_countDayLeaves
            // 
            this.lbl_countDayLeaves.AutoSize = true;
            // 
            // 
            // 
            this.lbl_countDayLeaves.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_countDayLeaves.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_countDayLeaves.FontBold = true;
            this.lbl_countDayLeaves.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_countDayLeaves.Location = new System.Drawing.Point(425, 100);
            this.lbl_countDayLeaves.Name = "lbl_countDayLeaves";
            this.lbl_countDayLeaves.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_countDayLeaves.Size = new System.Drawing.Size(32, 27);
            this.lbl_countDayLeaves.TabIndex = 25;
            this.lbl_countDayLeaves.Text = "4 روز";
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
            this.labelX1.ForeColor = System.Drawing.Color.Maroon;
            this.labelX1.Location = new System.Drawing.Point(464, 99);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(140, 27);
            this.labelX1.TabIndex = 24;
            this.labelX1.Text = "تعداد روز های مرخصی : ";
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
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btn_Report);
            this.panelEx1.Controls.Add(this.grd_LeaveHistory);
            this.panelEx1.Controls.Add(this.btn_Cancel);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(632, 532);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 4;
            // 
            // stiReport1
            // 
            this.stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport1.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport1.ReportAlias = "Report";
            this.stiReport1.ReportGuid = "95c8285ac2e746ea8965bf757392f710";
            this.stiReport1.ReportName = "Report";
            this.stiReport1.ReportSource = null;
            this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport1.UseProgressInThread = false;
            // 
            // Frm_LeavesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 532);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_LeavesHistory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم سوابق مرخصی های روزانه کارمندان";
            ((System.ComponentModel.ISupportInitialize)(this.grd_LeaveHistory)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.ButtonX btn_Report;
        public DevComponents.DotNetBar.Controls.DataGridViewX grd_LeaveHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_leaveid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_radif;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_personelid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fromdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_untildate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_differencedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_description;
        private DevComponents.DotNetBar.ButtonX btn_Cancel;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        public DevComponents.DotNetBar.LabelX lbl_countDayLeaves;
        public DevComponents.DotNetBar.LabelX labelX1;
        public DevComponents.DotNetBar.LabelX lbl_fromDate;
        public DevComponents.DotNetBar.LabelX lbl_personel;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private Stimulsoft.Report.StiReport stiReport1;
    }
}