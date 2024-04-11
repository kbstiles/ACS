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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clothingStoreStilesKSP24DataSet = new ACS_KStilesM7.ClothingStoreStilesKSP24DataSet();
            this.clothingStoreStilesKSP24DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.productUPCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyOnHandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreStilesKSP24DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreStilesKSP24DataSetBindingSource)).BeginInit();
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
            this.dgvShop.AutoGenerateColumns = false;
            this.dgvShop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvShop.BackgroundColor = global::ACS_KStilesM7.Properties.Settings.Default.mainBack;
            this.dgvShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productUPCDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.typeIDDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.imageIDDataGridViewTextBoxColumn,
            this.qtyOnHandDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn});
            this.dgvShop.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundColor", global::ACS_KStilesM7.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dgvShop.DataMember = "Products";
            this.dgvShop.DataSource = this.clothingStoreStilesKSP24DataSetBindingSource;
            this.dgvShop.Location = new System.Drawing.Point(48, 22);
            this.dgvShop.Margin = new System.Windows.Forms.Padding(6);
            this.dgvShop.MultiSelect = false;
            this.dgvShop.Name = "dgvShop";
            this.dgvShop.ReadOnly = true;
            this.dgvShop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShop.Size = new System.Drawing.Size(557, 290);
            this.dgvShop.TabIndex = 0;
            this.dgvShop.TabStop = false;
            // 
            // pbxProductImage
            // 
            this.pbxProductImage.Image = global::ACS_KStilesM7.Properties.Resources.biegeShirt;
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
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(48, 350);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 37);
            this.comboBox1.TabIndex = 5;
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
            // productUPCDataGridViewTextBoxColumn
            // 
            this.productUPCDataGridViewTextBoxColumn.DataPropertyName = "ProductUPC";
            this.productUPCDataGridViewTextBoxColumn.HeaderText = "ProductUPC";
            this.productUPCDataGridViewTextBoxColumn.Name = "productUPCDataGridViewTextBoxColumn";
            this.productUPCDataGridViewTextBoxColumn.ReadOnly = true;
            this.productUPCDataGridViewTextBoxColumn.Width = 138;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.Width = 151;
            // 
            // typeIDDataGridViewTextBoxColumn
            // 
            this.typeIDDataGridViewTextBoxColumn.DataPropertyName = "TypeID";
            this.typeIDDataGridViewTextBoxColumn.HeaderText = "TypeID";
            this.typeIDDataGridViewTextBoxColumn.Name = "typeIDDataGridViewTextBoxColumn";
            this.typeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeIDDataGridViewTextBoxColumn.Width = 95;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            this.brandDataGridViewTextBoxColumn.Width = 85;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sizeDataGridViewTextBoxColumn.Width = 71;
            // 
            // imageIDDataGridViewTextBoxColumn
            // 
            this.imageIDDataGridViewTextBoxColumn.DataPropertyName = "ImageID";
            this.imageIDDataGridViewTextBoxColumn.HeaderText = "ImageID";
            this.imageIDDataGridViewTextBoxColumn.Name = "imageIDDataGridViewTextBoxColumn";
            this.imageIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.imageIDDataGridViewTextBoxColumn.Width = 104;
            // 
            // qtyOnHandDataGridViewTextBoxColumn
            // 
            this.qtyOnHandDataGridViewTextBoxColumn.DataPropertyName = "QtyOnHand";
            this.qtyOnHandDataGridViewTextBoxColumn.HeaderText = "QtyOnHand";
            this.qtyOnHandDataGridViewTextBoxColumn.Name = "qtyOnHandDataGridViewTextBoxColumn";
            this.qtyOnHandDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtyOnHandDataGridViewTextBoxColumn.Width = 135;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitPriceDataGridViewTextBoxColumn.Width = 110;
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource clothingStoreStilesKSP24DataSetBindingSource;
        private ClothingStoreStilesKSP24DataSet clothingStoreStilesKSP24DataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private ClothingStoreStilesKSP24DataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private ClothingStoreStilesKSP24DataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private ClothingStoreStilesKSP24DataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource purchaseDetailsBindingSource;
        private ClothingStoreStilesKSP24DataSetTableAdapters.PurchaseDetailsTableAdapter purchaseDetailsTableAdapter;
        private System.Windows.Forms.BindingSource typesBindingSource;
        private ClothingStoreStilesKSP24DataSetTableAdapters.TypesTableAdapter typesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productUPCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyOnHandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
    }
}