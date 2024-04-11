using ACS_KStilesM7.ClothingStoreStilesKSP24DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ACS_KStilesM7
{
    public partial class frmShop : Form
    {
        public static ProductsTableAdapter _taProducts;

        public static ClothingStoreStilesKSP24DataSet _dsProducts;

        public frmShop()
        {
            InitializeComponent();
        }

        private void frmShop_Load(object sender, EventArgs e)
        {
            _taProducts = productsTableAdapter;
            _dsProducts = clothingStoreStilesKSP24DataSet;

            // TODO: This line of code loads data into the 'clothingStoreStilesKSP24DataSet.Types' table. You can move, or remove it, as needed.
            this.typesTableAdapter.Fill(this.clothingStoreStilesKSP24DataSet.Types);
            // TODO: This line of code loads data into the 'clothingStoreStilesKSP24DataSet.PurchaseDetails' table. You can move, or remove it, as needed.
            this.purchaseDetailsTableAdapter.Fill(this.clothingStoreStilesKSP24DataSet.PurchaseDetails);
            // TODO: This line of code loads data into the 'clothingStoreStilesKSP24DataSet.Products' table. You can move, or remove it, as needed.
            clsSQL.ProductDatabaseCommand();
            // TODO: This line of code loads data into the 'clothingStoreStilesKSP24DataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.clothingStoreStilesKSP24DataSet.Orders);
            // TODO: This line of code loads data into the 'clothingStoreStilesKSP24DataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.clothingStoreStilesKSP24DataSet.Customers);


            MessageBox.Show("Database successfully opened.");
            
            dgvShop.AutoGenerateColumns = true;
        }        

        private void dgvShop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbxQuantity.Items.Clear();
            for (int i = 0; i < Convert.ToInt32(dgvShop.Rows[e.RowIndex].Cells[6].Value) + 1; i++)
            {
                cbxQuantity.Items.Add(i);
            }
            if (e.RowIndex == 0)
            {                
                pbxProductImage.Image = ACS_KStilesM7.Properties.Resources.redHoodie;
            } else if (e.RowIndex == 1)
            {
                pbxProductImage.Image = ACS_KStilesM7.Properties.Resources.blueShirt;
            } else if (e.RowIndex == 2)
            {
                pbxProductImage.Image = ACS_KStilesM7.Properties.Resources.blackJeans;
            } else if (e.RowIndex == 3)
            {
                pbxProductImage.Image = ACS_KStilesM7.Properties.Resources.purpleJacket;
            } else if (e.RowIndex == 4)
            {
                pbxProductImage.Image = ACS_KStilesM7.Properties.Resources.pinkShorts;
            } else if (e.RowIndex == 5)
            {
                pbxProductImage.Image = ACS_KStilesM7.Properties.Resources.biegeShirt;
            } else if (e.RowIndex == 6)
            {
                pbxProductImage.Image = ACS_KStilesM7.Properties.Resources.stripedHoodie;
            } else if (e.RowIndex == 7)
            {
                pbxProductImage.Image = ACS_KStilesM7.Properties.Resources.whiteJacket;
            } else if (e.RowIndex == 8)
            {
                pbxProductImage.Image = ACS_KStilesM7.Properties.Resources.navyJeans;
            } else if (e.RowIndex == 9)
            {
                pbxProductImage.Image = ACS_KStilesM7.Properties.Resources.yellowShorts;
            } else if (e.RowIndex == 10)
            {
                pbxProductImage.Image = ACS_KStilesM7.Properties.Resources.creamCapris;
            } else if (e.RowIndex == 11)
            { 
                pbxProductImage.Image = ACS_KStilesM7.Properties.Resources.orangeHoodie;
            } else if (e.RowIndex == 12)
            {
                pbxProductImage.Image = ACS_KStilesM7.Properties.Resources.brownShirt;                
            } else if (e.RowIndex == 13)
            {
                pbxProductImage.Image = ACS_KStilesM7.Properties.Resources.greenShorts;
            } else if (e.RowIndex == 14)
            {
                pbxProductImage.Image = ACS_KStilesM7.Properties.Resources.blackJacket;
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmCart().Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmWelcome().Show();
        }
    }
}
