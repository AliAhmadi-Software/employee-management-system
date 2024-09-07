namespace Attendance_Automation
{
    partial class Frm_Missions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.PersianCalander_DateMission = new BPersianCalender.BPersianCalenderTextBox();
            this.btn_ShowOptimizationForm = new DevComponents.DotNetBar.ButtonX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txt_UnitlHours = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.picbox_personel = new System.Windows.Forms.PictureBox();
            this.cmb_Personels = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btn_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.btn_EditFinal = new DevComponents.DotNetBar.ButtonX();
            this.btn_AddMission = new DevComponents.DotNetBar.ButtonX();
            this.txt_Destination = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txt_Description = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txt_FromHours = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txt_Personelid = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.cmb_SearchByPersonel = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btn_Search = new System.Windows.Forms.PictureBox();
            this.persianUntilDate_Search = new BPersianCalender.BPersianCalenderTextBox();
            this.persianFromDate_Search = new BPersianCalender.BPersianCalenderTextBox();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.txtSearchByFamily = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSearchByID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.grd_Missions = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctm_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctm_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.ctm_printMission = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_missionId = new System.Windows.Forms.Label();
            this.chk_multiSelect = new System.Windows.Forms.CheckBox();
            this.btn_FinalDeleteData = new DevComponents.DotNetBar.ButtonX();
            this.col_missionid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_radif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_personelid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_datemission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fromhours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_untilhours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_datesumbit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_personel)).BeginInit();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Missions)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.PersianCalander_DateMission);
            this.groupPanel1.Controls.Add(this.btn_ShowOptimizationForm);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.txt_UnitlHours);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.picbox_personel);
            this.groupPanel1.Controls.Add(this.cmb_Personels);
            this.groupPanel1.Controls.Add(this.btn_Cancel);
            this.groupPanel1.Controls.Add(this.btn_EditFinal);
            this.groupPanel1.Controls.Add(this.btn_AddMission);
            this.groupPanel1.Controls.Add(this.txt_Destination);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.txt_Description);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.txt_FromHours);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.txt_Personelid);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(13, 13);
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
            this.groupPanel1.TabIndex = 4;
            // 
            // PersianCalander_DateMission
            // 
            this.PersianCalander_DateMission.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PersianCalander_DateMission.Location = new System.Drawing.Point(721, 118);
            this.PersianCalander_DateMission.Miladi = new System.DateTime(((long)(0)));
            this.PersianCalander_DateMission.Name = "PersianCalander_DateMission";
            this.PersianCalander_DateMission.NowDateSelected = false;
            this.PersianCalander_DateMission.ReadOnly = true;
            this.PersianCalander_DateMission.SelectedDate = null;
            this.PersianCalander_DateMission.Shamsi = null;
            this.PersianCalander_DateMission.Size = new System.Drawing.Size(156, 32);
            this.PersianCalander_DateMission.TabIndex = 19;
            // 
            // btn_ShowOptimizationForm
            // 
            this.btn_ShowOptimizationForm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ShowOptimizationForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ShowOptimizationForm.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btn_ShowOptimizationForm.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_ShowOptimizationForm.ImageTextSpacing = 2;
            this.btn_ShowOptimizationForm.Location = new System.Drawing.Point(329, 168);
            this.btn_ShowOptimizationForm.Name = "btn_ShowOptimizationForm";
            this.btn_ShowOptimizationForm.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_ShowOptimizationForm.Size = new System.Drawing.Size(167, 38);
            this.btn_ShowOptimizationForm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ShowOptimizationForm.TabIndex = 17;
            this.btn_ShowOptimizationForm.Text = "بهینه سازی پایگاه داده";
            this.btn_ShowOptimizationForm.Click += new System.EventHandler(this.btn_ShowOptimizationForm_Click);
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
            this.labelX8.Location = new System.Drawing.Point(880, 118);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(96, 27);
            this.labelX8.TabIndex = 12;
            this.labelX8.Text = "تاریخ ماموریت : ";
            // 
            // txt_UnitlHours
            // 
            // 
            // 
            // 
            this.txt_UnitlHours.Border.Class = "TextBoxBorder";
            this.txt_UnitlHours.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_UnitlHours.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_UnitlHours.Location = new System.Drawing.Point(159, 16);
            this.txt_UnitlHours.MaxLength = 5;
            this.txt_UnitlHours.Name = "txt_UnitlHours";
            this.txt_UnitlHours.PreventEnterBeep = true;
            this.txt_UnitlHours.Size = new System.Drawing.Size(92, 32);
            this.txt_UnitlHours.TabIndex = 7;
            this.txt_UnitlHours.WatermarkText = "00:00";
            this.txt_UnitlHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_UnitlHours_KeyPress);
            this.txt_UnitlHours.Leave += new System.EventHandler(this.txt_UnitlHours_Leave);
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
            this.labelX7.Location = new System.Drawing.Point(248, 21);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(65, 27);
            this.labelX7.TabIndex = 6;
            this.labelX7.Text = "تا ساعت : ";
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
            this.labelX6.Location = new System.Drawing.Point(32, 15);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 27);
            this.labelX6.TabIndex = 18;
            this.labelX6.Text = "تصویر کارمند";
            // 
            // picbox_personel
            // 
            this.picbox_personel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbox_personel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox_personel.Location = new System.Drawing.Point(12, 63);
            this.picbox_personel.Name = "picbox_personel";
            this.picbox_personel.Size = new System.Drawing.Size(125, 130);
            this.picbox_personel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_personel.TabIndex = 18;
            this.picbox_personel.TabStop = false;
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
            this.btn_Cancel.Location = new System.Drawing.Point(516, 168);
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
            this.btn_EditFinal.Location = new System.Drawing.Point(642, 168);
            this.btn_EditFinal.Name = "btn_EditFinal";
            this.btn_EditFinal.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_EditFinal.Size = new System.Drawing.Size(115, 38);
            this.btn_EditFinal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_EditFinal.Symbol = "";
            this.btn_EditFinal.TabIndex = 15;
            this.btn_EditFinal.Text = "ویرایش نهایی";
            this.btn_EditFinal.Click += new System.EventHandler(this.btn_EditFinal_Click);
            // 
            // btn_AddMission
            // 
            this.btn_AddMission.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_AddMission.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_AddMission.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_AddMission.ImageTextSpacing = 2;
            this.btn_AddMission.Location = new System.Drawing.Point(772, 168);
            this.btn_AddMission.Name = "btn_AddMission";
            this.btn_AddMission.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_AddMission.Size = new System.Drawing.Size(105, 38);
            this.btn_AddMission.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_AddMission.Symbol = "";
            this.btn_AddMission.TabIndex = 14;
            this.btn_AddMission.Text = "ثبت";
            this.btn_AddMission.Click += new System.EventHandler(this.btn_AddMission_Click);
            // 
            // txt_Destination
            // 
            // 
            // 
            // 
            this.txt_Destination.Border.Class = "TextBoxBorder";
            this.txt_Destination.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Destination.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Destination.Location = new System.Drawing.Point(721, 63);
            this.txt_Destination.Name = "txt_Destination";
            this.txt_Destination.PreventEnterBeep = true;
            this.txt_Destination.Size = new System.Drawing.Size(156, 32);
            this.txt_Destination.TabIndex = 9;
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
            this.labelX5.Location = new System.Drawing.Point(880, 64);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(48, 27);
            this.labelX5.TabIndex = 8;
            this.labelX5.Text = "مقصد : ";
            // 
            // txt_Description
            // 
            // 
            // 
            // 
            this.txt_Description.Border.Class = "TextBoxBorder";
            this.txt_Description.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Description.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Description.Location = new System.Drawing.Point(159, 64);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.PreventEnterBeep = true;
            this.txt_Description.Size = new System.Drawing.Size(469, 32);
            this.txt_Description.TabIndex = 11;
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
            this.labelX4.Location = new System.Drawing.Point(626, 64);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(62, 27);
            this.labelX4.TabIndex = 10;
            this.labelX4.Text = "به منظور : ";
            // 
            // txt_FromHours
            // 
            // 
            // 
            // 
            this.txt_FromHours.Border.Class = "TextBoxBorder";
            this.txt_FromHours.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_FromHours.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_FromHours.Location = new System.Drawing.Point(321, 16);
            this.txt_FromHours.MaxLength = 5;
            this.txt_FromHours.Name = "txt_FromHours";
            this.txt_FromHours.PreventEnterBeep = true;
            this.txt_FromHours.Size = new System.Drawing.Size(92, 32);
            this.txt_FromHours.TabIndex = 5;
            this.txt_FromHours.WatermarkText = "00:00";
            this.txt_FromHours.TextChanged += new System.EventHandler(this.txt_FromHours_TextChanged);
            this.txt_FromHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_FromHours_KeyPress);
            this.txt_FromHours.Leave += new System.EventHandler(this.txt_FromHours_Leave);
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
            this.labelX3.Location = new System.Drawing.Point(415, 21);
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
            this.txt_Personelid.Location = new System.Drawing.Point(517, 16);
            this.txt_Personelid.Name = "txt_Personelid";
            this.txt_Personelid.PreventEnterBeep = true;
            this.txt_Personelid.ReadOnly = true;
            this.txt_Personelid.Size = new System.Drawing.Size(111, 32);
            this.txt_Personelid.TabIndex = 3;
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
            this.labelX2.Location = new System.Drawing.Point(626, 21);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 27);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "کد پرسنلی : ";
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
            this.labelX1.Location = new System.Drawing.Point(880, 21);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(93, 27);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "انتخاب کارمند : ";
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
            this.groupPanel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupPanel2.Location = new System.Drawing.Point(13, 248);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(989, 91);
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
            this.groupPanel2.TabIndex = 5;
            this.groupPanel2.Text = "فرم جست و جو";
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.Transparent;
            this.line1.Location = new System.Drawing.Point(704, -18);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(23, 81);
            this.line1.TabIndex = 31;
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
            this.cmb_SearchByPersonel.Location = new System.Drawing.Point(552, 18);
            this.cmb_SearchByPersonel.Name = "cmb_SearchByPersonel";
            this.cmb_SearchByPersonel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_SearchByPersonel.Size = new System.Drawing.Size(156, 32);
            this.cmb_SearchByPersonel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_SearchByPersonel.TabIndex = 25;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Image = global::Attendance_Automation.Properties.Resources.search_icon;
            this.btn_Search.Location = new System.Drawing.Point(13, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(55, 50);
            this.btn_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Search.TabIndex = 30;
            this.btn_Search.TabStop = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // persianUntilDate_Search
            // 
            this.persianUntilDate_Search.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.persianUntilDate_Search.Location = new System.Drawing.Point(98, 18);
            this.persianUntilDate_Search.Miladi = new System.DateTime(((long)(0)));
            this.persianUntilDate_Search.Name = "persianUntilDate_Search";
            this.persianUntilDate_Search.NowDateSelected = false;
            this.persianUntilDate_Search.ReadOnly = true;
            this.persianUntilDate_Search.SelectedDate = null;
            this.persianUntilDate_Search.Shamsi = null;
            this.persianUntilDate_Search.Size = new System.Drawing.Size(156, 32);
            this.persianUntilDate_Search.TabIndex = 27;
            // 
            // persianFromDate_Search
            // 
            this.persianFromDate_Search.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.persianFromDate_Search.Location = new System.Drawing.Point(330, 18);
            this.persianFromDate_Search.Miladi = new System.DateTime(((long)(0)));
            this.persianFromDate_Search.Name = "persianFromDate_Search";
            this.persianFromDate_Search.NowDateSelected = false;
            this.persianFromDate_Search.ReadOnly = true;
            this.persianFromDate_Search.SelectedDate = null;
            this.persianFromDate_Search.Shamsi = null;
            this.persianFromDate_Search.Size = new System.Drawing.Size(150, 32);
            this.persianFromDate_Search.TabIndex = 26;
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX9.Location = new System.Drawing.Point(241, 23);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(75, 23);
            this.labelX9.TabIndex = 29;
            this.labelX9.Text = "تا تاریخ : ";
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX10.Location = new System.Drawing.Point(462, 22);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(75, 23);
            this.labelX10.TabIndex = 28;
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
            this.txtSearchByFamily.Location = new System.Drawing.Point(733, 18);
            this.txtSearchByFamily.Name = "txtSearchByFamily";
            this.txtSearchByFamily.PreventEnterBeep = true;
            this.txtSearchByFamily.Size = new System.Drawing.Size(141, 32);
            this.txtSearchByFamily.TabIndex = 24;
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
            this.txtSearchByID.Location = new System.Drawing.Point(880, 18);
            this.txtSearchByID.Name = "txtSearchByID";
            this.txtSearchByID.PreventEnterBeep = true;
            this.txtSearchByID.Size = new System.Drawing.Size(92, 32);
            this.txtSearchByID.TabIndex = 23;
            this.txtSearchByID.WatermarkText = "کد پرسنلی";
            this.txtSearchByID.TextChanged += new System.EventHandler(this.txtSearchByID_TextChanged);
            // 
            // grd_Missions
            // 
            this.grd_Missions.AllowUserToAddRows = false;
            this.grd_Missions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Missions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grd_Missions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Missions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_missionid,
            this.col_radif,
            this.col_select,
            this.col_personelid,
            this.col_fullname,
            this.col_datemission,
            this.col_fromhours,
            this.col_untilhours,
            this.col_description,
            this.col_destination,
            this.col_datesumbit});
            this.grd_Missions.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_Missions.DefaultCellStyle = dataGridViewCellStyle6;
            this.grd_Missions.EnableHeadersVisualStyles = false;
            this.grd_Missions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grd_Missions.Location = new System.Drawing.Point(13, 416);
            this.grd_Missions.MultiSelect = false;
            this.grd_Missions.Name = "grd_Missions";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Missions.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grd_Missions.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.grd_Missions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_Missions.Size = new System.Drawing.Size(986, 291);
            this.grd_Missions.TabIndex = 6;
            this.grd_Missions.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grd_Missions_CellFormatting);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctm_edit,
            this.ctm_delete,
            this.ctm_printMission});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(189, 76);
            // 
            // ctm_edit
            // 
            this.ctm_edit.Image = global::Attendance_Automation.Properties.Resources.Edit;
            this.ctm_edit.Name = "ctm_edit";
            this.ctm_edit.Size = new System.Drawing.Size(188, 24);
            this.ctm_edit.Text = "ویرایش";
            this.ctm_edit.Click += new System.EventHandler(this.ctm_edit_Click);
            // 
            // ctm_delete
            // 
            this.ctm_delete.Image = global::Attendance_Automation.Properties.Resources.DeleteRed;
            this.ctm_delete.Name = "ctm_delete";
            this.ctm_delete.Size = new System.Drawing.Size(188, 24);
            this.ctm_delete.Text = "حذف";
            this.ctm_delete.Click += new System.EventHandler(this.ctm_delete_Click);
            // 
            // ctm_printMission
            // 
            this.ctm_printMission.Image = global::Attendance_Automation.Properties.Resources.write_mission;
            this.ctm_printMission.Name = "ctm_printMission";
            this.ctm_printMission.Size = new System.Drawing.Size(188, 24);
            this.ctm_printMission.Text = "صدور گزارش ماموریت";
            this.ctm_printMission.Click += new System.EventHandler(this.ctm_printMission_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // lbl_missionId
            // 
            this.lbl_missionId.AutoSize = true;
            this.lbl_missionId.Location = new System.Drawing.Point(1092, 30);
            this.lbl_missionId.Name = "lbl_missionId";
            this.lbl_missionId.Size = new System.Drawing.Size(69, 13);
            this.lbl_missionId.TabIndex = 7;
            this.lbl_missionId.Text = "label_mission";
            // 
            // chk_multiSelect
            // 
            this.chk_multiSelect.AutoSize = true;
            this.chk_multiSelect.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chk_multiSelect.Location = new System.Drawing.Point(776, 362);
            this.chk_multiSelect.Name = "chk_multiSelect";
            this.chk_multiSelect.Size = new System.Drawing.Size(188, 28);
            this.chk_multiSelect.TabIndex = 8;
            this.chk_multiSelect.Text = "فعال سازی حذف چند انتخابی";
            this.chk_multiSelect.UseVisualStyleBackColor = true;
            this.chk_multiSelect.CheckedChanged += new System.EventHandler(this.chk_multiSelect_CheckedChanged);
            // 
            // btn_FinalDeleteData
            // 
            this.btn_FinalDeleteData.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_FinalDeleteData.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_FinalDeleteData.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_FinalDeleteData.ImageTextSpacing = 2;
            this.btn_FinalDeleteData.Location = new System.Drawing.Point(598, 362);
            this.btn_FinalDeleteData.Name = "btn_FinalDeleteData";
            this.btn_FinalDeleteData.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_FinalDeleteData.Size = new System.Drawing.Size(138, 30);
            this.btn_FinalDeleteData.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.btn_FinalDeleteData.TabIndex = 15;
            this.btn_FinalDeleteData.Text = "حذف نهایی داده ها";
            this.btn_FinalDeleteData.Visible = false;
            this.btn_FinalDeleteData.Click += new System.EventHandler(this.btn_FinalDeleteData_Click);
            // 
            // col_missionid
            // 
            this.col_missionid.DataPropertyName = "MissionID";
            this.col_missionid.HeaderText = "missionid";
            this.col_missionid.Name = "col_missionid";
            this.col_missionid.Visible = false;
            // 
            // col_radif
            // 
            this.col_radif.HeaderText = "ردیف";
            this.col_radif.Name = "col_radif";
            this.col_radif.Width = 50;
            // 
            // col_select
            // 
            this.col_select.HeaderText = "انتخاب سطرها";
            this.col_select.Name = "col_select";
            this.col_select.Visible = false;
            // 
            // col_personelid
            // 
            this.col_personelid.DataPropertyName = "PersonelId_FK";
            this.col_personelid.HeaderText = "کد پرسنلی";
            this.col_personelid.Name = "col_personelid";
            this.col_personelid.Width = 80;
            // 
            // col_fullname
            // 
            this.col_fullname.DataPropertyName = "FullName";
            this.col_fullname.HeaderText = "کارمند";
            this.col_fullname.Name = "col_fullname";
            this.col_fullname.Width = 140;
            // 
            // col_datemission
            // 
            this.col_datemission.DataPropertyName = "Date_Mission";
            this.col_datemission.HeaderText = "تاریخ ماموریت";
            this.col_datemission.Name = "col_datemission";
            this.col_datemission.Width = 110;
            // 
            // col_fromhours
            // 
            this.col_fromhours.DataPropertyName = "From_Hours";
            this.col_fromhours.HeaderText = "از ساعت";
            this.col_fromhours.Name = "col_fromhours";
            this.col_fromhours.Width = 80;
            // 
            // col_untilhours
            // 
            this.col_untilhours.DataPropertyName = "Until_Hours";
            this.col_untilhours.HeaderText = "تا ساعت";
            this.col_untilhours.Name = "col_untilhours";
            this.col_untilhours.Width = 80;
            // 
            // col_description
            // 
            this.col_description.DataPropertyName = "Description";
            this.col_description.HeaderText = "عنوان ماموریت";
            this.col_description.Name = "col_description";
            this.col_description.Width = 160;
            // 
            // col_destination
            // 
            this.col_destination.DataPropertyName = "Destination";
            this.col_destination.HeaderText = "مقصد";
            this.col_destination.Name = "col_destination";
            // 
            // col_datesumbit
            // 
            this.col_datesumbit.DataPropertyName = "Date_Sumbit";
            this.col_datesumbit.HeaderText = "تاریخ ثبت";
            this.col_datesumbit.Name = "col_datesumbit";
            this.col_datesumbit.Width = 130;
            // 
            // Frm_Missions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 721);
            this.Controls.Add(this.btn_FinalDeleteData);
            this.Controls.Add(this.chk_multiSelect);
            this.Controls.Add(this.lbl_missionId);
            this.Controls.Add(this.grd_Missions);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Name = "Frm_Missions";
            this.Text = "ماموریت ها";
            this.Load += new System.EventHandler(this.Frm_Missions_Load);
            this.Controls.SetChildIndex(this.groupPanel1, 0);
            this.Controls.SetChildIndex(this.groupPanel2, 0);
            this.Controls.SetChildIndex(this.grd_Missions, 0);
            this.Controls.SetChildIndex(this.lbl_missionId, 0);
            this.Controls.SetChildIndex(this.chk_multiSelect, 0);
            this.Controls.SetChildIndex(this.btn_FinalDeleteData, 0);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_personel)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Missions)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private BPersianCalender.BPersianCalenderTextBox PersianCalander_DateMission;
        private DevComponents.DotNetBar.ButtonX btn_ShowOptimizationForm;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_UnitlHours;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.PictureBox picbox_personel;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_Personels;
        private DevComponents.DotNetBar.ButtonX btn_Cancel;
        private DevComponents.DotNetBar.ButtonX btn_EditFinal;
        private DevComponents.DotNetBar.ButtonX btn_AddMission;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Destination;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Description;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_FromHours;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Personelid;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
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
        private DevComponents.DotNetBar.Controls.DataGridViewX grd_Missions;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctm_edit;
        private System.Windows.Forms.ToolStripMenuItem ctm_delete;
        private System.Windows.Forms.ToolStripMenuItem ctm_printMission;
        private System.Windows.Forms.Label lbl_missionId;
        private DevComponents.DotNetBar.ButtonX btn_FinalDeleteData;
        private System.Windows.Forms.CheckBox chk_multiSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_missionid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_radif;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_select;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_personelid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_datemission;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fromhours;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_untilhours;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_datesumbit;
    }
}