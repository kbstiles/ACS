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
        public frmShop()
        {
            InitializeComponent();
        }

        private void frmShop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clothingStoreStilesKSP24DataSet.Types' table. You can move, or remove it, as needed.
            this.typesTableAdapter.Fill(this.clothingStoreStilesKSP24DataSet.Types);
            // TODO: This line of code loads data into the 'clothingStoreStilesKSP24DataSet.PurchaseDetails' table. You can move, or remove it, as needed.
            this.purchaseDetailsTableAdapter.Fill(this.clothingStoreStilesKSP24DataSet.PurchaseDetails);
            // TODO: This line of code loads data into the 'clothingStoreStilesKSP24DataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.clothingStoreStilesKSP24DataSet.Products);
            // TODO: This line of code loads data into the 'clothingStoreStilesKSP24DataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.clothingStoreStilesKSP24DataSet.Orders);
            // TODO: This line of code loads data into the 'clothingStoreStilesKSP24DataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.clothingStoreStilesKSP24DataSet.Customers);


            MessageBox.Show("Database successfully opened.");

            dgvShop.AutoGenerateColumns = true;
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
