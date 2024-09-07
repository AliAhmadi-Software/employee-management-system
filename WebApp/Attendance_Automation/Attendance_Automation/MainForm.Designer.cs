namespace Attendance_Automation
{
    partial class MainForm
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbl_cntMission = new DevComponents.DotNetBar.LabelX();
            this.lbl_cntHourLeaves = new DevComponents.DotNetBar.LabelX();
            this.lbl_cntLeaves = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_dayOfWeek = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_today = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_currentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_lastLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btn_ManageUsers = new DevComponents.DotNetBar.ButtonItem();
            this.btn_ManagePersonels = new DevComponents.DotNetBar.ButtonItem();
            this.btn_Missions = new DevComponents.DotNetBar.ButtonItem();
            this.btn_Leaves = new DevComponents.DotNetBar.ButtonItem();
            this.btn_LeavesTime = new DevComponents.DotNetBar.ButtonItem();
            this.btn_Attendance = new DevComponents.DotNetBar.ButtonItem();
            this.btn_AppExit = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.btn_ManageHost = new DevComponents.DotNetBar.ButtonItem();
            this.btn_ManageFtp = new DevComponents.DotNetBar.ButtonItem();
            this.btn_Optimization = new DevComponents.DotNetBar.ButtonItem();
            this.btn_BackupDb = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem2 = new DevComponents.DotNetBar.RibbonTabItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.lbl_cntMission);
            this.groupPanel1.Controls.Add(this.lbl_cntHourLeaves);
            this.groupPanel1.Controls.Add(this.lbl_cntLeaves);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupPanel1.Location = new System.Drawing.Point(620, 232);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Padding = new System.Windows.Forms.Padding(30);
            this.groupPanel1.Size = new System.Drawing.Size(370, 285);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText;
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
            this.groupPanel1.TabIndex = 8;
            this.groupPanel1.Text = "اطلاعات امروز ";
            // 
            // lbl_cntMission
            // 
            this.lbl_cntMission.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_cntMission.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_cntMission.Location = new System.Drawing.Point(22, 192);
            this.lbl_cntMission.Name = "lbl_cntMission";
            this.lbl_cntMission.Size = new System.Drawing.Size(49, 23);
            this.lbl_cntMission.TabIndex = 6;
            this.lbl_cntMission.Text = "---";
            // 
            // lbl_cntHourLeaves
            // 
            this.lbl_cntHourLeaves.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_cntHourLeaves.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_cntHourLeaves.Location = new System.Drawing.Point(22, 120);
            this.lbl_cntHourLeaves.Name = "lbl_cntHourLeaves";
            this.lbl_cntHourLeaves.Size = new System.Drawing.Size(49, 23);
            this.lbl_cntHourLeaves.TabIndex = 5;
            this.lbl_cntHourLeaves.Text = "---";
            // 
            // lbl_cntLeaves
            // 
            this.lbl_cntLeaves.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_cntLeaves.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_cntLeaves.Location = new System.Drawing.Point(22, 48);
            this.lbl_cntLeaves.Name = "lbl_cntLeaves";
            this.lbl_cntLeaves.Size = new System.Drawing.Size(49, 23);
            this.lbl_cntLeaves.TabIndex = 4;
            this.lbl_cntLeaves.Text = "---";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(122, 192);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(220, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "تعداد کارمندانی که امروز ماموریت رفته اند : ";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(101, 120);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(241, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "تعداد کارمندانی که امروز مرخصی ساعتی رفته اند : ";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(122, 48);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(220, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "تعداد کارمندانی که امروز مرخصی رفته اند : ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbl_time,
            this.toolStripStatusLabel3,
            this.lbl_dayOfWeek,
            this.toolStripStatusLabel2,
            this.lbl_today,
            this.toolStripStatusLabel4,
            this.lbl_currentUser,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel5,
            this.lbl_lastLogin});
            this.statusStrip1.Location = new System.Drawing.Point(0, 553);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1002, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabel1.Text = "ساعت : ";
            // 
            // lbl_time
            // 
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(19, 17);
            this.lbl_time.Text = "---";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(40, 17);
            this.toolStripStatusLabel3.Text = "امروز : ";
            // 
            // lbl_dayOfWeek
            // 
            this.lbl_dayOfWeek.Name = "lbl_dayOfWeek";
            this.lbl_dayOfWeek.Size = new System.Drawing.Size(19, 17);
            this.lbl_dayOfWeek.Text = "---";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel2.Text = "تاریخ : ";
            // 
            // lbl_today
            // 
            this.lbl_today.Name = "lbl_today";
            this.lbl_today.Size = new System.Drawing.Size(19, 17);
            this.lbl_today.Text = "---";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel4.Text = "|";
            // 
            // lbl_currentUser
            // 
            this.lbl_currentUser.Name = "lbl_currentUser";
            this.lbl_currentUser.Size = new System.Drawing.Size(94, 17);
            this.lbl_currentUser.Text = "اطلاعات کاربر جاری";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel6.Text = "|";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(112, 17);
            this.toolStripStatusLabel5.Text = "آخرین زمان ورود شما : ";
            // 
            // lbl_lastLogin
            // 
            this.lbl_lastLogin.Name = "lbl_lastLogin";
            this.lbl_lastLogin.Size = new System.Drawing.Size(19, 17);
            this.lbl_lastLogin.Text = "---";
            // 
            // ribbonControl1
            // 
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem1,
            this.ribbonTabItem2});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ribbonControl1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1});
            this.ribbonControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ribbonControl1.Size = new System.Drawing.Size(1002, 173);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl1.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 6;
            this.ribbonControl1.Text = "مدیریت";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 65);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ribbonPanel1.Size = new System.Drawing.Size(1002, 105);
            // 
            // 
            // 
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 1;
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.DragDropSupport = true;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_ManageUsers,
            this.btn_ManagePersonels,
            this.btn_Missions,
            this.btn_Leaves,
            this.btn_LeavesTime,
            this.btn_Attendance,
            this.btn_AppExit});
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(703, 102);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 0;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btn_ManageUsers
            // 
            this.btn_ManageUsers.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_ManageUsers.Image = global::Attendance_Automation.Properties.Resources.user_login;
            this.btn_ManageUsers.ImageFixedSize = new System.Drawing.Size(90, 65);
            this.btn_ManageUsers.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_ManageUsers.Name = "btn_ManageUsers";
            this.btn_ManageUsers.Stretch = true;
            this.btn_ManageUsers.SubItemsExpandWidth = 14;
            this.btn_ManageUsers.Text = "مدیریت کاربران";
            this.btn_ManageUsers.Click += new System.EventHandler(this.btn_ManageUsers_Click);
            // 
            // btn_ManagePersonels
            // 
            this.btn_ManagePersonels.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_ManagePersonels.Image = global::Attendance_Automation.Properties.Resources.Personels;
            this.btn_ManagePersonels.ImageFixedSize = new System.Drawing.Size(90, 65);
            this.btn_ManagePersonels.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_ManagePersonels.Name = "btn_ManagePersonels";
            this.btn_ManagePersonels.Stretch = true;
            this.btn_ManagePersonels.SubItemsExpandWidth = 14;
            this.btn_ManagePersonels.Text = "مدیریت کارمندان";
            this.btn_ManagePersonels.Click += new System.EventHandler(this.btn_ManagePersonels_Click);
            // 
            // btn_Missions
            // 
            this.btn_Missions.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_Missions.Image = global::Attendance_Automation.Properties.Resources.user;
            this.btn_Missions.ImageFixedSize = new System.Drawing.Size(90, 65);
            this.btn_Missions.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_Missions.Name = "btn_Missions";
            this.btn_Missions.Stretch = true;
            this.btn_Missions.SubItemsExpandWidth = 14;
            this.btn_Missions.Text = "ماموریت ها";
            this.btn_Missions.Click += new System.EventHandler(this.btn_Missions_Click);
            // 
            // btn_Leaves
            // 
            this.btn_Leaves.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_Leaves.Image = global::Attendance_Automation.Properties.Resources.travel_1;
            this.btn_Leaves.ImageFixedSize = new System.Drawing.Size(90, 65);
            this.btn_Leaves.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_Leaves.Name = "btn_Leaves";
            this.btn_Leaves.Stretch = true;
            this.btn_Leaves.SubItemsExpandWidth = 14;
            this.btn_Leaves.Text = "مرخصی روزانه";
            this.btn_Leaves.Click += new System.EventHandler(this.btn_Leaves_Click);
            // 
            // btn_LeavesTime
            // 
            this.btn_LeavesTime.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_LeavesTime.Image = global::Attendance_Automation.Properties.Resources.mission_user;
            this.btn_LeavesTime.ImageFixedSize = new System.Drawing.Size(90, 65);
            this.btn_LeavesTime.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_LeavesTime.Name = "btn_LeavesTime";
            this.btn_LeavesTime.Stretch = true;
            this.btn_LeavesTime.SubItemsExpandWidth = 14;
            this.btn_LeavesTime.Text = "مرخصی ساعتی";
            this.btn_LeavesTime.Click += new System.EventHandler(this.btn_LeavesTime_Click);
            // 
            // btn_Attendance
            // 
            this.btn_Attendance.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_Attendance.Image = global::Attendance_Automation.Properties.Resources.attendance_list_icon;
            this.btn_Attendance.ImageFixedSize = new System.Drawing.Size(90, 65);
            this.btn_Attendance.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_Attendance.Name = "btn_Attendance";
            this.btn_Attendance.Stretch = true;
            this.btn_Attendance.SubItemsExpandWidth = 14;
            this.btn_Attendance.Text = "ورود و خروج";
            this.btn_Attendance.Click += new System.EventHandler(this.btn_Attendance_Click);
            // 
            // btn_AppExit
            // 
            this.btn_AppExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_AppExit.Image = global::Attendance_Automation.Properties.Resources.exit;
            this.btn_AppExit.ImageFixedSize = new System.Drawing.Size(90, 65);
            this.btn_AppExit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_AppExit.Name = "btn_AppExit";
            this.btn_AppExit.Stretch = true;
            this.btn_AppExit.SubItemsExpandWidth = 14;
            this.btn_AppExit.Text = "خروج از نرم افزار";
            this.btn_AppExit.Click += new System.EventHandler(this.btn_AppExit_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel2.Controls.Add(this.ribbonBar2);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 65);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(1002, 105);
            // 
            // 
            // 
            this.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel2.TabIndex = 2;
            this.ribbonPanel2.Visible = false;
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.DragDropSupport = true;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_ManageHost,
            this.btn_ManageFtp,
            this.btn_Optimization,
            this.btn_BackupDb});
            this.ribbonBar2.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(400, 102);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar2.TabIndex = 0;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btn_ManageHost
            // 
            this.btn_ManageHost.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_ManageHost.Image = global::Attendance_Automation.Properties.Resources.server_12;
            this.btn_ManageHost.ImageFixedSize = new System.Drawing.Size(90, 65);
            this.btn_ManageHost.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_ManageHost.Name = "btn_ManageHost";
            this.btn_ManageHost.Stretch = true;
            this.btn_ManageHost.SubItemsExpandWidth = 14;
            this.btn_ManageHost.Text = "مدیریت هاست";
            this.btn_ManageHost.Click += new System.EventHandler(this.btn_ManageHost_Click);
            // 
            // btn_ManageFtp
            // 
            this.btn_ManageFtp.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_ManageFtp.Image = global::Attendance_Automation.Properties.Resources.ftp;
            this.btn_ManageFtp.ImageFixedSize = new System.Drawing.Size(90, 65);
            this.btn_ManageFtp.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_ManageFtp.Name = "btn_ManageFtp";
            this.btn_ManageFtp.Stretch = true;
            this.btn_ManageFtp.SubItemsExpandWidth = 14;
            this.btn_ManageFtp.Text = "تنظیمات FTP";
            this.btn_ManageFtp.Click += new System.EventHandler(this.btn_ManageFtp_Click);
            // 
            // btn_Optimization
            // 
            this.btn_Optimization.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_Optimization.Image = global::Attendance_Automation.Properties.Resources.optimization;
            this.btn_Optimization.ImageFixedSize = new System.Drawing.Size(90, 65);
            this.btn_Optimization.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_Optimization.Name = "btn_Optimization";
            this.btn_Optimization.Stretch = true;
            this.btn_Optimization.SubItemsExpandWidth = 14;
            this.btn_Optimization.Text = "بهینه سازی ";
            this.btn_Optimization.Click += new System.EventHandler(this.btn_Optimization_Click);
            // 
            // btn_BackupDb
            // 
            this.btn_BackupDb.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_BackupDb.Image = global::Attendance_Automation.Properties.Resources.Green_Backup;
            this.btn_BackupDb.ImageFixedSize = new System.Drawing.Size(90, 65);
            this.btn_BackupDb.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_BackupDb.Name = "btn_BackupDb";
            this.btn_BackupDb.Stretch = true;
            this.btn_BackupDb.SubItemsExpandWidth = 14;
            this.btn_BackupDb.Text = "پشتیبان گیری";
            this.btn_BackupDb.Click += new System.EventHandler(this.btn_BackupDb_Click);
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "مدیریت";
            // 
            // ribbonTabItem2
            // 
            this.ribbonTabItem2.Name = "ribbonTabItem2";
            this.ribbonTabItem2.Panel = this.ribbonPanel2;
            this.ribbonTabItem2.Text = "امکانات";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "نرم افزار جامع مدیریت حضور و غیاب کارمندان";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 575);
            this.ControlBox = false;
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX lbl_cntMission;
        private DevComponents.DotNetBar.LabelX lbl_cntHourLeaves;
        private DevComponents.DotNetBar.LabelX lbl_cntLeaves;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_time;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lbl_dayOfWeek;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lbl_today;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel lbl_currentUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        public System.Windows.Forms.ToolStripStatusLabel lbl_lastLogin;
        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem btn_ManageUsers;
        private DevComponents.DotNetBar.ButtonItem btn_ManagePersonels;
        private DevComponents.DotNetBar.ButtonItem btn_Missions;
        private DevComponents.DotNetBar.ButtonItem btn_Leaves;
        private DevComponents.DotNetBar.ButtonItem btn_LeavesTime;
        private DevComponents.DotNetBar.ButtonItem btn_Attendance;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ButtonItem btn_ManageHost;
        private DevComponents.DotNetBar.ButtonItem btn_ManageFtp;
        private DevComponents.DotNetBar.ButtonItem btn_Optimization;
        private DevComponents.DotNetBar.ButtonItem btn_BackupDb;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem btn_AppExit;
        private System.Windows.Forms.Timer timer1;
    }
}