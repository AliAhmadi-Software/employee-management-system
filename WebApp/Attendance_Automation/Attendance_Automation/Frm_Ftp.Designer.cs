namespace Attendance_Automation
{
    partial class Frm_Ftp
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_Save = new DevComponents.DotNetBar.ButtonX();
            this.chk_showPassFtpLogin = new System.Windows.Forms.CheckBox();
            this.chk_showPass = new System.Windows.Forms.CheckBox();
            this.btn_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.txt_FtpLoginPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_FtpAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txt_FtpPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_ExpireDateHost = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_FtpUsername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupPanel1.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btn_Save);
            this.groupPanel1.Controls.Add(this.chk_showPassFtpLogin);
            this.groupPanel1.Controls.Add(this.chk_showPass);
            this.groupPanel1.Controls.Add(this.btn_Cancel);
            this.groupPanel1.Controls.Add(this.txt_FtpLoginPassword);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.txt_FtpAddress);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.txt_FtpPassword);
            this.groupPanel1.Controls.Add(this.txt_ExpireDateHost);
            this.groupPanel1.Controls.Add(this.txt_FtpUsername);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(706, 336);
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
            this.groupPanel1.TabIndex = 20;
            this.groupPanel1.Text = "FTP تنظیمات اطلاعات مربوط به  ";
            // 
            // btn_Save
            // 
            this.btn_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Save.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Save.ImageTextSpacing = 2;
            this.btn_Save.Location = new System.Drawing.Point(362, 262);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_Save.Size = new System.Drawing.Size(117, 38);
            this.btn_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Save.Symbol = "";
            this.btn_Save.TabIndex = 28;
            this.btn_Save.Text = "ذخیره اطلاعات";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // chk_showPassFtpLogin
            // 
            this.chk_showPassFtpLogin.AutoSize = true;
            this.chk_showPassFtpLogin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chk_showPassFtpLogin.Location = new System.Drawing.Point(29, 198);
            this.chk_showPassFtpLogin.Name = "chk_showPassFtpLogin";
            this.chk_showPassFtpLogin.Size = new System.Drawing.Size(74, 17);
            this.chk_showPassFtpLogin.TabIndex = 27;
            this.chk_showPassFtpLogin.Text = "نمایش رمز";
            this.chk_showPassFtpLogin.UseVisualStyleBackColor = true;
            this.chk_showPassFtpLogin.CheckedChanged += new System.EventHandler(this.chk_showPassFtpLogin_CheckedChanged);
            // 
            // chk_showPass
            // 
            this.chk_showPass.AutoSize = true;
            this.chk_showPass.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chk_showPass.Location = new System.Drawing.Point(610, 60);
            this.chk_showPass.Name = "chk_showPass";
            this.chk_showPass.Size = new System.Drawing.Size(74, 17);
            this.chk_showPass.TabIndex = 12;
            this.chk_showPass.Text = "نمایش رمز";
            this.chk_showPass.UseVisualStyleBackColor = true;
            this.chk_showPass.CheckedChanged += new System.EventHandler(this.chk_showPass_CheckedChanged);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Cancel.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Cancel.ImageTextSpacing = 2;
            this.btn_Cancel.Location = new System.Drawing.Point(210, 262);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_Cancel.Size = new System.Drawing.Size(115, 38);
            this.btn_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Cancel.Symbol = "";
            this.btn_Cancel.TabIndex = 16;
            this.btn_Cancel.Text = "بستن";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_FtpLoginPassword
            // 
            // 
            // 
            // 
            this.txt_FtpLoginPassword.Border.Class = "TextBoxBorder";
            this.txt_FtpLoginPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_FtpLoginPassword.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_FtpLoginPassword.Location = new System.Drawing.Point(29, 150);
            this.txt_FtpLoginPassword.Name = "txt_FtpLoginPassword";
            this.txt_FtpLoginPassword.PasswordChar = '*';
            this.txt_FtpLoginPassword.PreventEnterBeep = true;
            this.txt_FtpLoginPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_FtpLoginPassword.Size = new System.Drawing.Size(220, 32);
            this.txt_FtpLoginPassword.TabIndex = 26;
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
            this.labelX5.Location = new System.Drawing.Point(255, 154);
            this.labelX5.Name = "labelX5";
            this.labelX5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelX5.Size = new System.Drawing.Size(169, 27);
            this.labelX5.TabIndex = 25;
            this.labelX5.Text = " : FTP رمز ورود به تنظیمات ";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.FontBold = true;
            this.labelX3.Location = new System.Drawing.Point(36, 95);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelX3.Size = new System.Drawing.Size(121, 21);
            this.labelX3.TabIndex = 11;
            this.labelX3.Text = "Ftp Address : ";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.FontBold = true;
            this.labelX1.Location = new System.Drawing.Point(340, 32);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelX1.Size = new System.Drawing.Size(102, 21);
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "Password : ";
            // 
            // txt_FtpAddress
            // 
            // 
            // 
            // 
            this.txt_FtpAddress.Border.Class = "TextBoxBorder";
            this.txt_FtpAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_FtpAddress.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FtpAddress.Location = new System.Drawing.Point(154, 95);
            this.txt_FtpAddress.Name = "txt_FtpAddress";
            this.txt_FtpAddress.PreventEnterBeep = true;
            this.txt_FtpAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_FtpAddress.Size = new System.Drawing.Size(534, 26);
            this.txt_FtpAddress.TabIndex = 9;
            this.txt_FtpAddress.WatermarkText = "For Example : ftp://192.152.202.145/";
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
            this.labelX4.Location = new System.Drawing.Point(559, 155);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(129, 27);
            this.labelX4.TabIndex = 23;
            this.labelX4.Text = "تاریخ انقضای هاست : ";
            // 
            // txt_FtpPassword
            // 
            // 
            // 
            // 
            this.txt_FtpPassword.Border.Class = "TextBoxBorder";
            this.txt_FtpPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_FtpPassword.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FtpPassword.Location = new System.Drawing.Point(442, 28);
            this.txt_FtpPassword.Name = "txt_FtpPassword";
            this.txt_FtpPassword.PasswordChar = '*';
            this.txt_FtpPassword.PreventEnterBeep = true;
            this.txt_FtpPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_FtpPassword.Size = new System.Drawing.Size(246, 26);
            this.txt_FtpPassword.TabIndex = 7;
            // 
            // txt_ExpireDateHost
            // 
            // 
            // 
            // 
            this.txt_ExpireDateHost.Border.Class = "TextBoxBorder";
            this.txt_ExpireDateHost.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_ExpireDateHost.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_ExpireDateHost.Location = new System.Drawing.Point(430, 152);
            this.txt_ExpireDateHost.Name = "txt_ExpireDateHost";
            this.txt_ExpireDateHost.PreventEnterBeep = true;
            this.txt_ExpireDateHost.Size = new System.Drawing.Size(129, 32);
            this.txt_ExpireDateHost.TabIndex = 24;
            // 
            // txt_FtpUsername
            // 
            // 
            // 
            // 
            this.txt_FtpUsername.Border.Class = "TextBoxBorder";
            this.txt_FtpUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_FtpUsername.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FtpUsername.Location = new System.Drawing.Point(154, 28);
            this.txt_FtpUsername.Name = "txt_FtpUsername";
            this.txt_FtpUsername.PreventEnterBeep = true;
            this.txt_FtpUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_FtpUsername.Size = new System.Drawing.Size(171, 26);
            this.txt_FtpUsername.TabIndex = 5;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.FontBold = true;
            this.labelX2.Location = new System.Drawing.Point(50, 28);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelX2.Size = new System.Drawing.Size(107, 21);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Username : ";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(730, 363);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 8;
            // 
            // Frm_Ftp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 363);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_Ftp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت FTP";
            this.Load += new System.EventHandler(this.Frm_Ftp_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btn_Save;
        private System.Windows.Forms.CheckBox chk_showPassFtpLogin;
        private System.Windows.Forms.CheckBox chk_showPass;
        private DevComponents.DotNetBar.ButtonX btn_Cancel;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_FtpLoginPassword;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_FtpAddress;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_FtpPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_ExpireDateHost;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_FtpUsername;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.PanelEx panelEx1;
    }
}