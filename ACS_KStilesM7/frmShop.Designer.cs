namespace ACS_KStilesM7
{
    partial class frmShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShop));
            this.dgvShop = new System.Windows.Forms.DataGridView();
            this.pbxProductImage = new System.Windows.Forms.PictureBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.clothingStoreStilesKSP24DataSet = new ACS_KStilesM7.ClothingStoreStilesKSP24DataSet();
            this.clothingStoreStilesKSP24DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreStilesKSP24DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreStilesKSP24DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShop
            // 
            this.dgvShop.AllowUserToAddRows = false;
            this.dgvShop.AllowUserToDeleteRows = false;
            this.dgvShop.AutoGenerateColumns = false;
            this.dgvShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShop.DataSource = this.clothingStoreStilesKSP24DataSetBindingSource;
            this.dgvShop.Location = new System.Drawing.Point(48, 22);
            this.dgvShop.Margin = new System.Windows.Forms.Padding(6);
            this.dgvShop.Name = "dgvShop";
            this.dgvShop.ReadOnly = true;
            this.dgvShop.Size = new System.Drawing.Size(557, 290);
            this.dgvShop.TabIndex = 0;
            this.dgvShop.TabStop = false;
            // 
            // pbxProductImage
            // 
            this.pbxProductImage.Location = new System.Drawing.Point(662, 24);
            this.pbxProductImage.Margin = new System.Windows.Forms.Padding(6);
            this.pbxProductImage.Name = "pbxProductImage";
            this.pbxProductImage.Size = new System.Drawing.Size(365, 288);
            this.pbxProductImage.TabIndex = 1;
            this.pbxProductImage.TabStop = false;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = global::ACS_KStilesM7.Properties.Settings.Default.buttonBack;
            this.btnAddToCart.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ACS_KStilesM7.Properties.Settings.Default, "buttonBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnAddToCart.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::ACS_KStilesM7.Properties.Settings.Default, "buttonText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.btnAddToCart.ForeColor = global::ACS_KStilesM7.Properties.Settings.Default.buttonText;
            this.btnAddToCart.Location = new System.Drawing.Point(308, 350);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(172, 66);
            this.btnAddToCart.TabIndex = 2;
            this.btnAddToCart.TabStop = false;
            this.btnAddToCart.Text = "&Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnCart
            // 
            this.btnCart.BackColor = global::ACS_KStilesM7.Properties.Settings.Default.buttonBack;
            this.btnCart.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ACS_KStilesM7.Properties.Settings.Default, "buttonBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnCart.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::ACS_KStilesM7.Properties.Settings.Default, "buttonText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.btnCart.ForeColor = global::ACS_KStilesM7.Properties.Settings.Default.buttonText;
            this.btnCart.Location = new System.Drawing.Point(515, 350);
            this.btnCart.Margin = new System.Windows.Forms.Padding(6);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(172, 66);
            this.btnCart.TabIndex = 3;
            this.btnCart.TabStop = false;
            this.btnCart.Text = "&Cart";
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = global::ACS_KStilesM7.Properties.Settings.Default.buttonBack;
            this.btnHome.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ACS_KStilesM7.Properties.Settings.Default, "buttonBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnHome.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::ACS_KStilesM7.Properties.Settings.Default, "buttonText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.btnHome.ForeColor = global::ACS_KStilesM7.Properties.Settings.Default.buttonText;
            this.btnHome.Location = new System.Drawing.Point(719, 350);
            this.btnHome.Margin = new System.Windows.Forms.Padding(6);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(172, 66);
            this.btnHome.TabIndex = 4;
            this.btnHome.TabStop = false;
            this.btnHome.Text = "&Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // clothingStoreStilesKSP24DataSet
            // 
            this.clothingStoreStilesKSP24DataSet.DataSetName = "ClothingStoreStilesKSP24DataSet";
            this.clothingStoreStilesKSP24DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clothingStoreStilesKSP24DataSetBindingSource
            // 
            this.clothingStoreStilesKSP24DataSetBindingSource.DataSource = this.clothingStoreStilesKSP24DataSet;
            this.clothingStoreStilesKSP24DataSetBindingSource.Position = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(48, 350);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 37);
            this.comboBox1.TabIndex = 5;
            // 
            // frmShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::ACS_KStilesM7.Properties.Settings.Default.mainBack;
            this.BackgroundImage = global::ACS_KStilesM7.Properties.Resources.backgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1074, 451);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.pbxProductImage);
            this.Controls.Add(this.dgvShop);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ACS_KStilesM7.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmShop";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.frmShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreStilesKSP24DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreStilesKSP24DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShop;
        private System.Windows.Forms.PictureBox pbxProductImage;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.BindingSource clothingStoreStilesKSP24DataSetBindingSource;
        private ClothingStoreStilesKSP24DataSet clothingStoreStilesKSP24DataSet;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}