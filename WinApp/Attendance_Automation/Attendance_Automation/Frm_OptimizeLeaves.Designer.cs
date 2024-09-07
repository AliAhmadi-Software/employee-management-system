namespace Attendance_Automation
{
    partial class Frm_OptimizeLeaves
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_OptimizeLeaves));
            this.persianDate_Until = new FreeControls.PersianDateTimePicker();
            this.persianDate_From = new FreeControls.PersianDateTimePicker();
            this.btn_Close = new DevComponents.DotNetBar.ButtonX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btn_StartOptimize = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // persianDate_Until
            // 
            this.persianDate_Until.BackColor = System.Drawing.Color.White;
            this.persianDate_Until.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.persianDate_Until.Location = new System.Drawing.Point(110, 95);
            this.persianDate_Until.Name = "persianDate_Until";
            this.persianDate_Until.ShowTime = false;
            this.persianDate_Until.Size = new System.Drawing.Size(211, 30);
            this.persianDate_Until.TabIndex = 39;
            this.persianDate_Until.Text = "persianDateTimePicker2";
            this.persianDate_Until.Value = ((FreeControls.PersianDate)(resources.GetObject("persianDate_Until.Value")));
            // 
            // persianDate_From
            // 
            this.persianDate_From.BackColor = System.Drawing.Color.White;
            this.persianDate_From.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.persianDate_From.Location = new System.Drawing.Point(110, 36);
            this.persianDate_From.Name = "persianDate_From";
            this.persianDate_From.ShowTime = false;
            this.persianDate_From.Size = new System.Drawing.Size(211, 30);
            this.persianDate_From.TabIndex = 38;
            this.persianDate_From.Text = "persianDateTimePicker1";
            this.persianDate_From.Value = ((FreeControls.PersianDate)(resources.GetObject("persianDate_From.Value")));
            // 
            // btn_Close
            // 
            this.btn_Close.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btn_Close.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Close.ImageTextSpacing = 2;
            this.btn_Close.Location = new System.Drawing.Point(65, 153);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_Close.Size = new System.Drawing.Size(129, 38);
            this.btn_Close.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Close.TabIndex = 37;
            this.btn_Close.Text = "بستن پنجره";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
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
            this.labelX7.Location = new System.Drawing.Point(327, 86);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(59, 27);
            this.labelX7.TabIndex = 36;
            this.labelX7.Text = "تا تاریخ : ";
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
            this.labelX3.Location = new System.Drawing.Point(327, 36);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(59, 27);
            this.labelX3.TabIndex = 35;
            this.labelX3.Text = "از تاریخ : ";
            // 
            // btn_StartOptimize
            // 
            this.btn_StartOptimize.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_StartOptimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_StartOptimize.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btn_StartOptimize.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_StartOptimize.ImageTextSpacing = 2;
            this.btn_StartOptimize.Location = new System.Drawing.Point(211, 153);
            this.btn_StartOptimize.Name = "btn_StartOptimize";
            this.btn_StartOptimize.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_StartOptimize.Size = new System.Drawing.Size(129, 38);
            this.btn_StartOptimize.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_StartOptimize.TabIndex = 34;
            this.btn_StartOptimize.Text = "شروع بهینه سازی";
            this.btn_StartOptimize.Click += new System.EventHandler(this.btn_StartOptimize_Click);
            // 
            // Frm_OptimizeLeaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 226);
            this.Controls.Add(this.persianDate_Until);
            this.Controls.Add(this.persianDate_From);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.btn_StartOptimize);
            this.Name = "Frm_OptimizeLeaves";
            this.Text = "بهینه سازی اطلاعات مرخصی روزانه";
            this.Controls.SetChildIndex(this.btn_StartOptimize, 0);
            this.Controls.SetChildIndex(this.labelX3, 0);
            this.Controls.SetChildIndex(this.labelX7, 0);
            this.Controls.SetChildIndex(this.btn_Close, 0);
            this.Controls.SetChildIndex(this.persianDate_From, 0);
            this.Controls.SetChildIndex(this.persianDate_Until, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FreeControls.PersianDateTimePicker persianDate_Until;
        private FreeControls.PersianDateTimePicker persianDate_From;
        private DevComponents.DotNetBar.ButtonX btn_Close;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX btn_StartOptimize;
    }
}