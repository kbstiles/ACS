namespace ACS_KStilesM7
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.btnClose = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = global::ACS_KStilesM7.Properties.Settings.Default.buttonBack;
            this.btnClose.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ACS_KStilesM7.Properties.Settings.Default, "buttonBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnClose.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::ACS_KStilesM7.Properties.Settings.Default, "buttonText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnClose.ForeColor = global::ACS_KStilesM7.Properties.Settings.Default.buttonText;
            this.btnClose.Location = new System.Drawing.Point(112, 121);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 57);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = global::ACS_KStilesM7.Properties.Settings.Default.mainBack;
            this.lblInfo.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ACS_KStilesM7.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblInfo.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::ACS_KStilesM7.Properties.Settings.Default, "secondaryMainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblInfo.ForeColor = global::ACS_KStilesM7.Properties.Settings.Default.secondaryMainText;
            this.lblInfo.Location = new System.Drawing.Point(18, 16);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(271, 92);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Programmer Name: Kade Stiles\r\nDate: \r\nVersion Number: 1.0\r\nCopyright: Full Copyri" +
    "ght?";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ACS_KStilesM7.Properties.Resources.backgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(317, 186);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblInfo);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAbout_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnClose;
    }
}