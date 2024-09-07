namespace Attendance_Automation
{
    partial class Frm_ReportMission
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.cmb_extensionReport = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.PersianCalender_DateMission = new BPersianCalender.BPersianCalenderTextBox();
            this.txt_noteReport = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.btn_removeReport = new DevComponents.DotNetBar.ButtonX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txt_docId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.btn_Report = new DevComponents.DotNetBar.ButtonX();
            this.btn_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.btn_Save = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_titleReport = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txt_titleMission = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txt_dateMission = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txt_personelName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txt_personelId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.labelX9);
            this.panelEx1.Controls.Add(this.cmb_extensionReport);
            this.panelEx1.Controls.Add(this.PersianCalender_DateMission);
            this.panelEx1.Controls.Add(this.txt_noteReport);
            this.panelEx1.Controls.Add(this.btn_removeReport);
            this.panelEx1.Controls.Add(this.labelX8);
            this.panelEx1.Controls.Add(this.txt_docId);
            this.panelEx1.Controls.Add(this.labelX7);
            this.panelEx1.Controls.Add(this.btn_Report);
            this.panelEx1.Controls.Add(this.btn_Cancel);
            this.panelEx1.Controls.Add(this.btn_Save);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.txt_titleReport);
            this.panelEx1.Controls.Add(this.labelX5);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(744, 657);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // labelX9
            // 
            this.labelX9.AutoSize = true;
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX9.FontBold = true;
            this.labelX9.Location = new System.Drawing.Point(267, 496);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(118, 27);
            this.labelX9.TabIndex = 43;
            this.labelX9.Text = "انتخاب فرمت گزارش";
            // 
            // cmb_extensionReport
            // 
            this.cmb_extensionReport.DisplayMember = "Text";
            this.cmb_extensionReport.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_extensionReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_extensionReport.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb_extensionReport.FormattingEnabled = true;
            this.cmb_extensionReport.ItemHeight = 26;
            this.cmb_extensionReport.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3,
            this.comboItem4});
            this.cmb_extensionReport.Location = new System.Drawing.Point(87, 496);
            this.cmb_extensionReport.Name = "cmb_extensionReport";
            this.cmb_extensionReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_extensionReport.Size = new System.Drawing.Size(156, 32);
            this.cmb_extensionReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_extensionReport.TabIndex = 42;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "pdf";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "jpeg";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "word";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "excel";
            // 
            // PersianCalender_DateMission
            // 
            this.PersianCalender_DateMission.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PersianCalender_DateMission.Location = new System.Drawing.Point(417, 496);
            this.PersianCalender_DateMission.Miladi = new System.DateTime(((long)(0)));
            this.PersianCalender_DateMission.Name = "PersianCalender_DateMission";
            this.PersianCalender_DateMission.NowDateSelected = false;
            this.PersianCalender_DateMission.ReadOnly = true;
            this.PersianCalender_DateMission.SelectedDate = null;
            this.PersianCalender_DateMission.Shamsi = null;
            this.PersianCalender_DateMission.Size = new System.Drawing.Size(166, 32);
            this.PersianCalender_DateMission.TabIndex = 41;
            // 
            // txt_noteReport
            // 
            // 
            // 
            // 
            this.txt_noteReport.BackgroundStyle.Class = "RichTextBoxBorder";
            this.txt_noteReport.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_noteReport.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_noteReport.Location = new System.Drawing.Point(15, 277);
            this.txt_noteReport.Name = "txt_noteReport";
            this.txt_noteReport.Rtf = "{\\rtf1\\fbidis\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset178 B " +
    "Mitra;}}\r\n\\viewkind4\\uc1\\pard\\rtlpar\\qr\\b\\f0\\rtlch\\fs24\\par\r\n}\r\n";
            this.txt_noteReport.Size = new System.Drawing.Size(568, 195);
            this.txt_noteReport.TabIndex = 34;
            // 
            // btn_removeReport
            // 
            this.btn_removeReport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_removeReport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_removeReport.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_removeReport.ImageTextSpacing = 2;
            this.btn_removeReport.Location = new System.Drawing.Point(76, 608);
            this.btn_removeReport.Name = "btn_removeReport";
            this.btn_removeReport.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_removeReport.Size = new System.Drawing.Size(115, 38);
            this.btn_removeReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_removeReport.Symbol = "";
            this.btn_removeReport.TabIndex = 39;
            this.btn_removeReport.Text = "حذف گزارش";
            this.btn_removeReport.Click += new System.EventHandler(this.btn_removeReport_Click);
            // 
            // labelX8
            // 
            this.labelX8.AutoSize = true;
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX8.FontBold = true;
            this.labelX8.Location = new System.Drawing.Point(589, 498);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(115, 27);
            this.labelX8.TabIndex = 35;
            this.labelX8.Text = "تاریخ ثبت گزارش : ";
            // 
            // txt_docId
            // 
            // 
            // 
            // 
            this.txt_docId.Border.Class = "TextBoxBorder";
            this.txt_docId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_docId.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_docId.Location = new System.Drawing.Point(445, 183);
            this.txt_docId.Name = "txt_docId";
            this.txt_docId.PreventEnterBeep = true;
            this.txt_docId.ReadOnly = true;
            this.txt_docId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_docId.Size = new System.Drawing.Size(138, 32);
            this.txt_docId.TabIndex = 30;
            this.txt_docId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX7.FontBold = true;
            this.labelX7.Location = new System.Drawing.Point(589, 188);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(106, 27);
            this.labelX7.TabIndex = 29;
            this.labelX7.Text = "کد سند ماموریت : ";
            // 
            // btn_Report
            // 
            this.btn_Report.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Report.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Report.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Report.ImageTextSpacing = 2;
            this.btn_Report.Location = new System.Drawing.Point(206, 608);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_Report.Size = new System.Drawing.Size(115, 38);
            this.btn_Report.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Report.Symbol = "";
            this.btn_Report.TabIndex = 38;
            this.btn_Report.Text = "گزارش گیری";
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Cancel.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Cancel.ImageTextSpacing = 2;
            this.btn_Cancel.Location = new System.Drawing.Point(344, 608);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_Cancel.Size = new System.Drawing.Size(115, 38);
            this.btn_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Cancel.Symbol = "";
            this.btn_Cancel.TabIndex = 37;
            this.btn_Cancel.Text = "بستن";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Save.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Save.ImageTextSpacing = 2;
            this.btn_Save.Location = new System.Drawing.Point(475, 608);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_Save.Size = new System.Drawing.Size(108, 38);
            this.btn_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Save.Symbol = "";
            this.btn_Save.TabIndex = 36;
            this.btn_Save.Text = "ذخیره";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX1.FontBold = true;
            this.labelX1.Location = new System.Drawing.Point(589, 277);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(87, 27);
            this.labelX1.TabIndex = 33;
            this.labelX1.Text = "شرح گزارش : ";
            // 
            // txt_titleReport
            // 
            // 
            // 
            // 
            this.txt_titleReport.Border.Class = "TextBoxBorder";
            this.txt_titleReport.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_titleReport.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_titleReport.Location = new System.Drawing.Point(15, 227);
            this.txt_titleReport.Name = "txt_titleReport";
            this.txt_titleReport.PreventEnterBeep = true;
            this.txt_titleReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_titleReport.Size = new System.Drawing.Size(568, 32);
            this.txt_titleReport.TabIndex = 32;
            this.txt_titleReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX5.FontBold = true;
            this.labelX5.Location = new System.Drawing.Point(589, 231);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(141, 27);
            this.labelX5.TabIndex = 31;
            this.labelX5.Text = "عنوان گزارش ماموریت : ";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txt_titleMission);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.txt_dateMission);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.txt_personelName);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.txt_personelId);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupPanel1.Location = new System.Drawing.Point(15, 22);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(715, 155);
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
            this.groupPanel1.TabIndex = 40;
            this.groupPanel1.Text = "اطلاعات ماموریت";
            // 
            // txt_titleMission
            // 
            // 
            // 
            // 
            this.txt_titleMission.Border.Class = "TextBoxBorder";
            this.txt_titleMission.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_titleMission.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_titleMission.Location = new System.Drawing.Point(17, 58);
            this.txt_titleMission.Name = "txt_titleMission";
            this.txt_titleMission.PreventEnterBeep = true;
            this.txt_titleMission.ReadOnly = true;
            this.txt_titleMission.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_titleMission.Size = new System.Drawing.Size(580, 32);
            this.txt_titleMission.TabIndex = 7;
            this.txt_titleMission.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX6.FontBold = true;
            this.labelX6.Location = new System.Drawing.Point(603, 63);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(98, 27);
            this.labelX6.TabIndex = 6;
            this.labelX6.Text = "عنوان ماموریت : ";
            // 
            // txt_dateMission
            // 
            // 
            // 
            // 
            this.txt_dateMission.Border.Class = "TextBoxBorder";
            this.txt_dateMission.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_dateMission.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_dateMission.Location = new System.Drawing.Point(17, 8);
            this.txt_dateMission.Name = "txt_dateMission";
            this.txt_dateMission.PreventEnterBeep = true;
            this.txt_dateMission.ReadOnly = true;
            this.txt_dateMission.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_dateMission.Size = new System.Drawing.Size(138, 32);
            this.txt_dateMission.TabIndex = 5;
            this.txt_dateMission.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX4.FontBold = true;
            this.labelX4.Location = new System.Drawing.Point(155, 11);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(96, 27);
            this.labelX4.TabIndex = 4;
            this.labelX4.Text = "تاریخ ماموریت : ";
            // 
            // txt_personelName
            // 
            // 
            // 
            // 
            this.txt_personelName.Border.Class = "TextBoxBorder";
            this.txt_personelName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_personelName.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_personelName.Location = new System.Drawing.Point(269, 8);
            this.txt_personelName.Name = "txt_personelName";
            this.txt_personelName.PreventEnterBeep = true;
            this.txt_personelName.ReadOnly = true;
            this.txt_personelName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_personelName.Size = new System.Drawing.Size(175, 32);
            this.txt_personelName.TabIndex = 3;
            this.txt_personelName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX3.FontBold = true;
            this.labelX3.Location = new System.Drawing.Point(440, 11);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(71, 27);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "نام کارمند : ";
            // 
            // txt_personelId
            // 
            // 
            // 
            // 
            this.txt_personelId.Border.Class = "TextBoxBorder";
            this.txt_personelId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_personelId.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_personelId.Location = new System.Drawing.Point(534, 8);
            this.txt_personelId.Name = "txt_personelId";
            this.txt_personelId.PreventEnterBeep = true;
            this.txt_personelId.ReadOnly = true;
            this.txt_personelId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_personelId.Size = new System.Drawing.Size(96, 32);
            this.txt_personelId.TabIndex = 1;
            this.txt_personelId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX2.FontBold = true;
            this.labelX2.Location = new System.Drawing.Point(626, 11);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 27);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "کد پرسنلی : ";
            // 
            // Frm_ReportMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 657);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_ReportMission";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم صدور گزارش ماموریت";
            this.Load += new System.EventHandler(this.Frm_ReportMission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_extensionReport;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        public BPersianCalender.BPersianCalenderTextBox PersianCalender_DateMission;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx txt_noteReport;
        public DevComponents.DotNetBar.ButtonX btn_removeReport;
        private DevComponents.DotNetBar.LabelX labelX8;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_docId;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.ButtonX btn_Report;
        private DevComponents.DotNetBar.ButtonX btn_Cancel;
        private DevComponents.DotNetBar.ButtonX btn_Save;
        private DevComponents.DotNetBar.LabelX labelX1;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_titleReport;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_titleMission;
        private DevComponents.DotNetBar.LabelX labelX6;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_dateMission;
        private DevComponents.DotNetBar.LabelX labelX4;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_personelName;
        private DevComponents.DotNetBar.LabelX labelX3;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_personelId;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}