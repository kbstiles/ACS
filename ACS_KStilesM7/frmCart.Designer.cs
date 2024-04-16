namespace ACS_KStilesM7
{
    partial class frmCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCart));
            this.lbxCart = new System.Windows.Forms.ListBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblTotalActual = new System.Windows.Forms.Label();
            this.lblTotalDueLabel = new System.Windows.Forms.Label();
            this.lblTaxActual = new System.Windows.Forms.Label();
            this.lblTaxLabel = new System.Windows.Forms.Label();
            this.lblSubtotalActual = new System.Windows.Forms.Label();
            this.lblSubtotalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxCart
            // 
            this.lbxCart.FormattingEnabled = true;
            this.lbxCart.ItemHeight = 23;
            this.lbxCart.Location = new System.Drawing.Point(13, 14);
            this.lbxCart.Margin = new System.Windows.Forms.Padding(4);
            this.lbxCart.Name = "lbxCart";
            this.lbxCart.Size = new System.Drawing.Size(347, 165);
            this.lbxCart.TabIndex = 0;
            this.lbxCart.TabStop = false;
            this.lbxCart.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbxCart_DrawItem);
            this.lbxCart.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lbxCart_MeasureItem);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = global::ACS_KStilesM7.Properties.Settings.Default.buttonBack;
            this.btnCheckOut.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ACS_KStilesM7.Properties.Settings.Default, "buttonBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnCheckOut.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::ACS_KStilesM7.Properties.Settings.Default, "buttonText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.btnCheckOut.ForeColor = global::ACS_KStilesM7.Properties.Settings.Default.buttonText;
            this.btnCheckOut.Location = new System.Drawing.Point(203, 389);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(6);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(134, 54);
            this.btnCheckOut.TabIndex = 10;
            this.btnCheckOut.TabStop = false;
            this.btnCheckOut.Text = "Chec&k Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = global::ACS_KStilesM7.Properties.Settings.Default.buttonBack;
            this.btnRemove.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ACS_KStilesM7.Properties.Settings.Default, "buttonBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnRemove.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::ACS_KStilesM7.Properties.Settings.Default, "buttonText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.btnRemove.ForeColor = global::ACS_KStilesM7.Properties.Settings.Default.buttonText;
            this.btnRemove.Location = new System.Drawing.Point(35, 389);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(6);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(134, 54);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.TabStop = false;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.BackColor = global::ACS_KStilesM7.Properties.Settings.Default.buttonBack;
            this.btnClearCart.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ACS_KStilesM7.Properties.Settings.Default, "buttonBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnClearCart.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::ACS_KStilesM7.Properties.Settings.Default, "buttonText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnClearCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.btnClearCart.ForeColor = global::ACS_KStilesM7.Properties.Settings.Default.buttonText;
            this.btnClearCart.Location = new System.Drawing.Point(203, 324);
            this.btnClearCart.Margin = new System.Windows.Forms.Padding(6);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(134, 54);
            this.btnClearCart.TabIndex = 8;
            this.btnClearCart.TabStop = false;
            this.btnClearCart.Text = "C&lear Cart";
            this.btnClearCart.UseVisualStyleBackColor = false;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = global::ACS_KStilesM7.Properties.Settings.Default.buttonBack;
            this.btnContinue.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ACS_KStilesM7.Properties.Settings.Default, "buttonBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnContinue.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::ACS_KStilesM7.Properties.Settings.Default, "buttonText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.btnContinue.ForeColor = global::ACS_KStilesM7.Properties.Settings.Default.buttonText;
            this.btnContinue.Location = new System.Drawing.Point(35, 324);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(6);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(134, 54);
            this.btnContinue.TabIndex = 7;
            this.btnContinue.TabStop = false;
            this.btnContinue.Text = "&Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblTotalActual
            // 
            this.lblTotalActual.AutoSize = true;
            this.lblTotalActual.BackColor = global::ACS_KStilesM7.Properties.Settings.Default.buttonBack;
            this.lblTotalActual.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::ACS_KStilesM7.Properties.Settings.Default, "buttonText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblTotalActual.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ACS_KStilesM7.Properties.Settings.Default, "buttonBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblTotalActual.ForeColor = global::ACS_KStilesM7.Properties.Settings.Default.buttonText;
            this.lblTotalActual.Location = new System.Drawing.Point(127, 279);
            this.lblTotalActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalActual.Name = "lblTotalActual";
            this.lblTotalActual.Size = new System.Drawing.Size(97, 23);
            this.lblTotalActual.TabIndex = 6;
            this.lblTotalActual.Text = "Total Here";
            // 
            // lblTotalDueLabel
            // 
            this.lblTotalDueLabel.AutoSize = true;
            this.lblTotalDueLabel.BackColor = global::ACS_KStilesM7.Properties.Settings.Default.buttonBack;
            this.lblTotalDueLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::ACS_KStilesM7.Properties.Settings.Default, "buttonText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblTotalDueLabel.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ACS_KStilesM7.Properties.Settings.Default, "buttonBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblTotalDueLabel.ForeColor = global::ACS_KStilesM7.Properties.Settings.Default.buttonText;
            this.lblTotalDueLabel.Location = new System.Drawing.Point(23, 279);
            this.lblTotalDueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDueLabel.Name = "lblTotalDueLabel";
            this.lblTotalDueLabel.Size = new System.Drawing.Size(95, 23);
            this.lblTotalDueLabel.TabIndex = 5;
            this.lblTotalDueLabel.Text = "Total Due:";
            // 
            // lblTaxActual
            // 
            this.lblTaxActual.AutoSize = true;
            this.lblTaxActual.BackColor = global::ACS_KStilesM7.Properties.Settings.Default.buttonBack;
            this.lblTaxActual.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::ACS_KStilesM7.Properties.Settings.Default, "buttonText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblTaxActual.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ACS_KStilesM7.Properties.Settings.Default, "buttonBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblTaxActual.ForeColor = global::ACS_KStilesM7.Properties.Settings.Default.buttonText;
            this.lblTaxActual.Location = new System.Drawing.Point(216, 236);
            this.lblTaxActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaxActual.Name = "lblTaxActual";
            this.lblTaxActual.Size = new System.Drawing.Size(84, 23);
            this.lblTaxActual.TabIndex = 4;
            this.lblTaxActual.Text = "Tax Here";
            // 
            // lblTaxLabel
            // 
            this.lblTaxLabel.AutoSize = true;
            this.lblTaxLabel.BackColor = global::ACS_KStilesM7.Properties.Settings.Default.buttonBack;
            this.lblTaxLabel.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ACS_KStilesM7.Properties.Settings.Default, "buttonBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblTaxLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::ACS_KStilesM7.Properties.Settings.Default, "buttonText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblTaxLabel.ForeColor = global::ACS_KStilesM7.Properties.Settings.Default.buttonText;
            this.lblTaxLabel.Location = new System.Drawing.Point(23, 236);
            this.lblTaxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaxLabel.Name = "lblTaxLabel";
            this.lblTaxLabel.Size = new System.Drawing.Size(182, 23);
            this.lblTaxLabel.TabIndex = 3;
            this.lblTaxLabel.Text = "Tax Amount (8.25%):";
            // 
            // lblSubtotalActual
            // 
            this.lblSubtotalActual.AutoSize = true;
            this.lblSubtotalActual.BackColor = global::ACS_KStilesM7.Properties.Settings.Default.buttonBack;
            this.lblSubtotalActual.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::ACS_KStilesM7.Properties.Settings.Default, "buttonText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSubtotalActual.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ACS_KStilesM7.Properties.Settings.Default, "buttonBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSubtotalActual.ForeColor = global::ACS_KStilesM7.Properties.Settings.Default.buttonText;
            this.lblSubtotalActual.Location = new System.Drawing.Point(113, 193);
            this.lblSubtotalActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotalActual.Name = "lblSubtotalActual";
            this.lblSubtotalActual.Size = new System.Drawing.Size(125, 23);
            this.lblSubtotalActual.TabIndex = 2;
            this.lblSubtotalActual.Text = "Subtotal Here";
            // 
            // lblSubtotalLabel
            // 
            this.lblSubtotalLabel.AutoSize = true;
            this.lblSubtotalLabel.BackColor = global::ACS_KStilesM7.Properties.Settings.Default.buttonBack;
            this.lblSubtotalLabel.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ACS_KStilesM7.Properties.Settings.Default, "buttonBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSubtotalLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::ACS_KStilesM7.Properties.Settings.Default, "buttonText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSubtotalLabel.ForeColor = global::ACS_KStilesM7.Properties.Settings.Default.buttonText;
            this.lblSubtotalLabel.Location = new System.Drawing.Point(23, 193);
            this.lblSubtotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotalLabel.Name = "lblSubtotalLabel";
            this.lblSubtotalLabel.Size = new System.Drawing.Size(84, 23);
            this.lblSubtotalLabel.TabIndex = 1;
            this.lblSubtotalLabel.Text = "Subtotal:";
            // 
            // frmCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ACS_KStilesM7.Properties.Resources.backgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(373, 463);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lblTotalActual);
            this.Controls.Add(this.lblTotalDueLabel);
            this.Controls.Add(this.lblTaxActual);
            this.Controls.Add(this.lblTaxLabel);
            this.Controls.Add(this.lblSubtotalActual);
            this.Controls.Add(this.lblSubtotalLabel);
            this.Controls.Add(this.lbxCart);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCart_FormClosing);
            this.Load += new System.EventHandler(this.frmCart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCart;
        private System.Windows.Forms.Label lblSubtotalLabel;
        private System.Windows.Forms.Label lblSubtotalActual;
        private System.Windows.Forms.Label lblTaxActual;
        private System.Windows.Forms.Label lblTaxLabel;
        private System.Windows.Forms.Label lblTotalActual;
        private System.Windows.Forms.Label lblTotalDueLabel;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCheckOut;
    }
}