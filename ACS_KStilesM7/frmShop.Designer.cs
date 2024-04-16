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
            this.clothingStoreStilesKSP24DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clothingStoreStilesKSP24DataSet = new ACS_KStilesM7.ClothingStoreStilesKSP24DataSet();
            this.pbxProductImage = new System.Windows.Forms.PictureBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.cbxQuantity = new System.Windows.Forms.ComboBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new ACS_KStilesM7.ClothingStoreStilesKSP24DataSetTableAdapters.CustomersTableAdapter();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new ACS_KStilesM7.ClothingStoreStilesKSP24DataSetTableAdapters.OrdersTableAdapter();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new ACS_KStilesM7.ClothingStoreStilesKSP24DataSetTableAdapters.ProductsTableAdapter();
            this.purchaseDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseDetailsTableAdapter = new ACS_KStilesM7.ClothingStoreStilesKSP24DataSetTableAdapters.PurchaseDetailsTableAdapter();
            this.typesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typesTableAdapter = new ACS_KStilesM7.ClothingStoreStilesKSP24DataSetTableAdapters.TypesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreStilesKSP24DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreStilesKSP24DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShop
            // 
            this.dgvShop.AllowUserToAddRows = false;
            this.dgvShop.AllowUserToDeleteRows = false;
            this.dgvShop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvShop.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShop.BackgroundColor = global::ACS_KStilesM7.Properties.Settings.Default.mainBack;
            this.dgvShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShop.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundColor", global::ACS_KStilesM7.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dgvShop.Location = new System.Drawing.Point(48, 21);
            this.dgvShop.Margin = new System.Windows.Forms.Padding(6);
            this.dgvShop.MultiSelect = false;
            this.dgvShop.Name = "dgvShop";
            this.dgvShop.ReadOnly = true;
            this.dgvShop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShop.Size = new System.Drawing.Size(557, 278);
            this.dgvShop.TabIndex = 4;
            this.dgvShop.TabStop = false;
            this.dgvShop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShop_CellClick);
            this.dgvShop.SelectionChanged += new System.EventHandler(this.dgvShop_SelectionChanged);
            // 
            // clothingStoreStilesKSP24DataSetBindingSource
            // 
            this.clothingStoreStilesKSP24DataSetBindingSource.DataSource = this.clothingStoreStilesKSP24DataSet;
            this.clothingStoreStilesKSP24DataSetBindingSource.Position = 0;
            // 
            // clothingStoreStilesKSP24DataSet
            // 
            this.clothingStoreStilesKSP24DataSet.DataSetName = "ClothingStoreStilesKSP24DataSet";
            this.clothingStoreStilesKSP24DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pbxProductImage
            // 
            this.pbxProductImage.Location = new System.Drawing.Point(662, 23);
            this.pbxProductImage.Margin = new System.Windows.Forms.Padding(6);
            this.pbxProductImage.Name = "pbxProductImage";
            this.pbxProductImage.Size = new System.Drawing.Size(365, 276);
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
            this.btnAddToCart.Location = new System.Drawing.Point(308, 335);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(172, 63);
            this.btnAddToCart.TabIndex = 1;
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
            this.btnCart.Location = new System.Drawing.Point(515, 335);
            this.btnCart.Margin = new System.Windows.Forms.Padding(6);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(172, 63);
            this.btnCart.TabIndex = 2;
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
            this.btnHome.Location = new System.Drawing.Point(719, 335);
            this.btnHome.Margin = new System.Windows.Forms.Padding(6);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(172, 63);
            this.btnHome.TabIndex = 3;
            this.btnHome.TabStop = false;
            this.btnHome.Text = "&Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // cbxQuantity
            // 
            this.cbxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.cbxQuantity.FormattingEnabled = true;
            this.cbxQuantity.Location = new System.Drawing.Point(48, 308);
            this.cbxQuantity.Name = "cbxQuantity";
            this.cbxQuantity.Size = new System.Drawing.Size(212, 37);
            this.cbxQuantity.TabIndex = 0;
            this.cbxQuantity.Text = "Quantity on Hand";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.clothingStoreStilesKSP24DataSetBindingSource;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.clothingStoreStilesKSP24DataSetBindingSource;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.clothingStoreStilesKSP24DataSetBindingSource;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // purchaseDetailsBindingSource
            // 
            this.purchaseDetailsBindingSource.DataMember = "PurchaseDetails";
            this.purchaseDetailsBindingSource.DataSource = this.clothingStoreStilesKSP24DataSetBindingSource;
            // 
            // purchaseDetailsTableAdapter
            // 
            this.purchaseDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // typesBindingSource
            // 
            this.typesBindingSource.DataMember = "Types";
            this.typesBindingSource.DataSource = this.clothingStoreStilesKSP24DataSetBindingSource;
            // 
            // typesTableAdapter
            // 
            this.typesTableAdapter.ClearBeforeFill = true;
            // 
            // frmShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::ACS_KStilesM7.Properties.Settings.Default.mainBack;
            this.BackgroundImage = global::ACS_KStilesM7.Properties.Resources.backgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1074, 432);
            this.Controls.Add(this.cbxQuantity);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.pbxProductImage);
            this.Controls.Add(this.dgvShop);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ACS_KStilesM7.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmShop_FormClosing);
            this.Load += new System.EventHandler(this.frmShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreStilesKSP24DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreStilesKSP24DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShop;
        private System.Windows.Forms.PictureBox pbxProductImage;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ComboBox cbxQuantity;
        private System.Windows.Forms.BindingSource clothingStoreStilesKSP24DataSetBindingSource;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private ClothingStoreStilesKSP24DataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private ClothingStoreStilesKSP24DataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource purchaseDetailsBindingSource;
        private ClothingStoreStilesKSP24DataSetTableAdapters.PurchaseDetailsTableAdapter purchaseDetailsTableAdapter;
        private System.Windows.Forms.BindingSource typesBindingSource;
        private ClothingStoreStilesKSP24DataSetTableAdapters.TypesTableAdapter typesTableAdapter;
        public System.Windows.Forms.BindingSource productsBindingSource;
        public ClothingStoreStilesKSP24DataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        public ClothingStoreStilesKSP24DataSet clothingStoreStilesKSP24DataSet;
    }
}