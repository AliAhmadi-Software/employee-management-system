namespace Attendance_Automation
{
    partial class Frm_Users
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
            this.grd_Users = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.col_radif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_roleid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_lastlogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctm_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctm_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.chk_Attendance = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chk_LeavesTime = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chk_Leaves = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chk_Personels = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chk_Missions = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chk_Users = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btn_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.btn_EditFinal = new DevComponents.DotNetBar.ButtonX();
            this.btn_AddUser = new DevComponents.DotNetBar.ButtonX();
            this.cmb_Access = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txt_Family = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txt_Name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txt_Pass2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txt_Pass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_Username = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.lbl_userid = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Users)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_Users
            // 
            this.grd_Users.AllowUserToAddRows = false;
            this.grd_Users.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grd_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_radif,
            this.col_userid,
            this.col_username,
            this.col_name,
            this.col_family,
            this.col_roleid,
            this.col_lastlogin});
            this.grd_Users.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_Users.DefaultCellStyle = dataGridViewCellStyle6;
            this.grd_Users.EnableHeadersVisualStyles = false;
            this.grd_Users.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grd_Users.Location = new System.Drawing.Point(12, 307);
            this.grd_Users.MultiSelect = false;
            this.grd_Users.Name = "grd_Users";
            this.grd_Users.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Users.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grd_Users.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.grd_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_Users.Size = new System.Drawing.Size(832, 279);
            this.grd_Users.TabIndex = 0;
            // 
            // col_radif
            // 
            this.col_radif.HeaderText = "ردیف";
            this.col_radif.Name = "col_radif";
            this.col_radif.ReadOnly = true;
            this.col_radif.Width = 70;
            // 
            // col_userid
            // 
            this.col_userid.DataPropertyName = "UserId";
            this.col_userid.HeaderText = "کد کاربری ";
            this.col_userid.Name = "col_userid";
            this.col_userid.ReadOnly = true;
            this.col_userid.Visible = false;
            this.col_userid.Width = 110;
            // 
            // col_username
            // 
            this.col_username.DataPropertyName = "Username";
            this.col_username.HeaderText = "نام کاربری";
            this.col_username.Name = "col_username";
            this.col_username.ReadOnly = true;
            this.col_username.Width = 130;
            // 
            // col_name
            // 
            this.col_name.DataPropertyName = "Name";
            this.col_name.HeaderText = "نام";
            this.col_name.Name = "col_name";
            this.col_name.ReadOnly = true;
            this.col_name.Width = 110;
            // 
            // col_family
            // 
            this.col_family.DataPropertyName = "Family";
            this.col_family.HeaderText = "نام خانوادگی";
            this.col_family.Name = "col_family";
            this.col_family.ReadOnly = true;
            this.col_family.Width = 130;
            // 
            // col_roleid
            // 
            this.col_roleid.HeaderText = "سطح دسترسی";
            this.col_roleid.Name = "col_roleid";
            this.col_roleid.ReadOnly = true;
            this.col_roleid.Width = 150;
            // 
            // col_lastlogin
            // 
            this.col_lastlogin.DataPropertyName = "LastLogin";
            this.col_lastlogin.HeaderText = "اخرین ورود";
            this.col_lastlogin.Name = "col_lastlogin";
            this.col_lastlogin.ReadOnly = true;
            this.col_lastlogin.Width = 195;
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
            this.ctm_edit.Size = new System.Drawing.Size(152, 24);
            this.ctm_edit.Text = "ویرایش";
            this.ctm_edit.Click += new System.EventHandler(this.ctm_edit_Click);
            // 
            // ctm_delete
            // 
            this.ctm_delete.Image = global::Attendance_Automation.Properties.Resources.DeleteRed;
            this.ctm_delete.Name = "ctm_delete";
            this.ctm_delete.Size = new System.Drawing.Size(152, 24);
            this.ctm_delete.Text = "حذف";
            this.ctm_delete.Click += new System.EventHandler(this.ctm_delete_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.groupPanel2);
            this.groupPanel1.Controls.Add(this.btn_Cancel);
            this.groupPanel1.Controls.Add(this.btn_EditFinal);
            this.groupPanel1.Controls.Add(this.btn_AddUser);
            this.groupPanel1.Controls.Add(this.cmb_Access);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.txt_Family);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.txt_Name);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.txt_Pass2);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.txt_Pass);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.txt_Username);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(832, 260);
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
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "تعریف کاربر جدید";
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.chk_Attendance);
            this.groupPanel2.Controls.Add(this.chk_LeavesTime);
            this.groupPanel2.Controls.Add(this.chk_Leaves);
            this.groupPanel2.Controls.Add(this.chk_Personels);
            this.groupPanel2.Controls.Add(this.chk_Missions);
            this.groupPanel2.Controls.Add(this.chk_Users);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(11, 3);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(253, 217);
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
            this.groupPanel2.TabIndex = 6;
            this.groupPanel2.Text = "تعیین سطح دسترسی کاربر";
            // 
            // chk_Attendance
            // 
            // 
            // 
            // 
            this.chk_Attendance.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_Attendance.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chk_Attendance.Location = new System.Drawing.Point(5, 117);
            this.chk_Attendance.Name = "chk_Attendance";
            this.chk_Attendance.Size = new System.Drawing.Size(100, 23);
            this.chk_Attendance.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_Attendance.TabIndex = 5;
            this.chk_Attendance.Text = "حضور و غیاب";
            // 
            // chk_LeavesTime
            // 
            // 
            // 
            // 
            this.chk_LeavesTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_LeavesTime.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chk_LeavesTime.Location = new System.Drawing.Point(5, 66);
            this.chk_LeavesTime.Name = "chk_LeavesTime";
            this.chk_LeavesTime.Size = new System.Drawing.Size(100, 23);
            this.chk_LeavesTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_LeavesTime.TabIndex = 3;
            this.chk_LeavesTime.Text = "مرخصی ساعتی";
            // 
            // chk_Leaves
            // 
            // 
            // 
            // 
            this.chk_Leaves.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_Leaves.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chk_Leaves.Location = new System.Drawing.Point(5, 20);
            this.chk_Leaves.Name = "chk_Leaves";
            this.chk_Leaves.Size = new System.Drawing.Size(100, 23);
            this.chk_Leaves.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_Leaves.TabIndex = 1;
            this.chk_Leaves.Text = "مرخصی رورانه";
            // 
            // chk_Personels
            // 
            // 
            // 
            // 
            this.chk_Personels.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_Personels.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chk_Personels.Location = new System.Drawing.Point(123, 117);
            this.chk_Personels.Name = "chk_Personels";
            this.chk_Personels.Size = new System.Drawing.Size(100, 23);
            this.chk_Personels.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_Personels.TabIndex = 4;
            this.chk_Personels.Text = "کارمندان";
            // 
            // chk_Missions
            // 
            // 
            // 
            // 
            this.chk_Missions.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_Missions.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chk_Missions.Location = new System.Drawing.Point(115, 66);
            this.chk_Missions.Name = "chk_Missions";
            this.chk_Missions.Size = new System.Drawing.Size(108, 23);
            this.chk_Missions.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_Missions.TabIndex = 2;
            this.chk_Missions.Text = "ماموریت ها";
            // 
            // chk_Users
            // 
            // 
            // 
            // 
            this.chk_Users.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_Users.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chk_Users.Location = new System.Drawing.Point(123, 20);
            this.chk_Users.Name = "chk_Users";
            this.chk_Users.Size = new System.Drawing.Size(100, 23);
            this.chk_Users.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_Users.TabIndex = 0;
            this.chk_Users.Text = "کاربران";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Cancel.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Cancel.ImageTextSpacing = 2;
            this.btn_Cancel.Location = new System.Drawing.Point(324, 182);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_Cancel.Size = new System.Drawing.Size(115, 38);
            this.btn_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Cancel.Symbol = "";
            this.btn_Cancel.TabIndex = 9;
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
            this.btn_EditFinal.Location = new System.Drawing.Point(464, 182);
            this.btn_EditFinal.Name = "btn_EditFinal";
            this.btn_EditFinal.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_EditFinal.Size = new System.Drawing.Size(115, 38);
            this.btn_EditFinal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_EditFinal.Symbol = "";
            this.btn_EditFinal.TabIndex = 8;
            this.btn_EditFinal.Text = "ویرایش نهایی";
            this.btn_EditFinal.Click += new System.EventHandler(this.btn_EditFinal_Click);
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_AddUser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_AddUser.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_AddUser.ImageTextSpacing = 2;
            this.btn_AddUser.Location = new System.Drawing.Point(604, 182);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_AddUser.Size = new System.Drawing.Size(108, 38);
            this.btn_AddUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_AddUser.Symbol = "";
            this.btn_AddUser.TabIndex = 7;
            this.btn_AddUser.Text = "ثبت";
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // cmb_Access
            // 
            this.cmb_Access.DisplayMember = "Text";
            this.cmb_Access.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Access.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Access.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb_Access.FormattingEnabled = true;
            this.cmb_Access.ItemHeight = 26;
            this.cmb_Access.Location = new System.Drawing.Point(550, 13);
            this.cmb_Access.Name = "cmb_Access";
            this.cmb_Access.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Access.Size = new System.Drawing.Size(162, 32);
            this.cmb_Access.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_Access.TabIndex = 0;
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
            this.labelX6.Location = new System.Drawing.Point(710, 13);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(99, 27);
            this.labelX6.TabIndex = 14;
            this.labelX6.Text = "سطح دسترسی : ";
            // 
            // txt_Family
            // 
            // 
            // 
            // 
            this.txt_Family.Border.Class = "TextBoxBorder";
            this.txt_Family.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Family.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Family.Location = new System.Drawing.Point(275, 110);
            this.txt_Family.Name = "txt_Family";
            this.txt_Family.PreventEnterBeep = true;
            this.txt_Family.Size = new System.Drawing.Size(162, 28);
            this.txt_Family.TabIndex = 5;
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
            this.labelX5.Location = new System.Drawing.Point(443, 111);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(86, 27);
            this.labelX5.TabIndex = 12;
            this.labelX5.Text = "نام خانوادگی : ";
            // 
            // txt_Name
            // 
            // 
            // 
            // 
            this.txt_Name.Border.Class = "TextBoxBorder";
            this.txt_Name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Name.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Name.Location = new System.Drawing.Point(550, 111);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PreventEnterBeep = true;
            this.txt_Name.Size = new System.Drawing.Size(162, 28);
            this.txt_Name.TabIndex = 4;
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
            this.labelX4.Location = new System.Drawing.Point(710, 114);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(33, 27);
            this.labelX4.TabIndex = 10;
            this.labelX4.Text = "نام : ";
            // 
            // txt_Pass2
            // 
            // 
            // 
            // 
            this.txt_Pass2.Border.Class = "TextBoxBorder";
            this.txt_Pass2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Pass2.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Pass2.Location = new System.Drawing.Point(277, 61);
            this.txt_Pass2.Name = "txt_Pass2";
            this.txt_Pass2.PasswordChar = '*';
            this.txt_Pass2.PreventEnterBeep = true;
            this.txt_Pass2.Size = new System.Drawing.Size(162, 28);
            this.txt_Pass2.TabIndex = 3;
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
            this.labelX3.Location = new System.Drawing.Point(443, 63);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(101, 27);
            this.labelX3.TabIndex = 8;
            this.labelX3.Text = "تکرار کلمه عبور : ";
            // 
            // txt_Pass
            // 
            // 
            // 
            // 
            this.txt_Pass.Border.Class = "TextBoxBorder";
            this.txt_Pass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Pass.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Pass.Location = new System.Drawing.Point(550, 62);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '*';
            this.txt_Pass.PreventEnterBeep = true;
            this.txt_Pass.Size = new System.Drawing.Size(162, 28);
            this.txt_Pass.TabIndex = 2;
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
            this.labelX1.Location = new System.Drawing.Point(710, 62);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(68, 27);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "کلمه عبور : ";
            // 
            // txt_Username
            // 
            // 
            // 
            // 
            this.txt_Username.Border.Class = "TextBoxBorder";
            this.txt_Username.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Username.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Username.Location = new System.Drawing.Point(277, 14);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.PreventEnterBeep = true;
            this.txt_Username.Size = new System.Drawing.Size(162, 28);
            this.txt_Username.TabIndex = 1;
            this.txt_Username.Leave += new System.EventHandler(this.txt_Username_Leave);
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
            this.labelX2.Location = new System.Drawing.Point(445, 14);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 27);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "نام کاربری : ";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.lbl_userid);
            this.panelEx1.Controls.Add(this.grd_Users);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelEx1.Size = new System.Drawing.Size(861, 611);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 4;
            // 
            // lbl_userid
            // 
            this.lbl_userid.AutoSize = true;
            this.lbl_userid.Location = new System.Drawing.Point(945, 34);
            this.lbl_userid.Name = "lbl_userid";
            this.lbl_userid.Size = new System.Drawing.Size(35, 13);
            this.lbl_userid.TabIndex = 4;
            this.lbl_userid.Text = "label1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Frm_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 611);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_Users";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت کاربران";
            this.Load += new System.EventHandler(this.Frm_Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Users)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.groupPanel2.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX grd_Users;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_Attendance;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_LeavesTime;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_Leaves;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_Personels;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_Missions;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_Users;
        private DevComponents.DotNetBar.ButtonX btn_Cancel;
        private DevComponents.DotNetBar.ButtonX btn_EditFinal;
        private DevComponents.DotNetBar.ButtonX btn_AddUser;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_Access;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Family;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Name;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Pass2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Pass;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Username;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Label lbl_userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_radif;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_family;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_roleid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_lastlogin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctm_edit;
        private System.Windows.Forms.ToolStripMenuItem ctm_delete;
    }
}