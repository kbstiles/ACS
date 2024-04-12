using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACS_KStilesM7
{
    public partial class frmCart : Form
    {
        decimal subTotal,
            taxAmount,
            tax,
            totalDue;
        public frmCart()
        {
            InitializeComponent();
        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            PopulateData();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmShop().Show();
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            frmShop.Orders.Clear();
            lbxCart.Items.Clear();
            PopulateData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            frmShop.Orders.RemoveAt(lbxCart.SelectedIndex);
            lbxCart.Items.RemoveAt(lbxCart.SelectedIndex);
            PopulateData();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

        }

        private void lbxCart_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 100;
        }

        private void lbxCart_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.DrawString(lbxCart.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            e.DrawFocusRectangle();
        }

        private void frmCart_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void PopulateData()
        {
            subTotal = 0;
            taxAmount = 0;
            tax = .0825M;
            totalDue = 0;

            lbxCart.Items.Clear();
            foreach (clsOrderDetails order in frmShop.Orders)
            {
                string productName = order.GetProductName();
                int quantity = order.GetQuantity();
                decimal unitPrice = order.GetUnitPrice(),
                    totalPrice = unitPrice * quantity;

                lbxCart.Items.Add(
                    "Product Name: " + productName +
                    "\nPrice Per Unit: " + unitPrice.ToString("C", CultureInfo.CurrentCulture) +
                    "\nQuantity: " + quantity.ToString() +
                    "\nTotal Price for Product Line: " + totalPrice.ToString("C", CultureInfo.CurrentCulture) +
                    "\n-----------------------------------------------------------"
                );

                subTotal += totalPrice;
            }
            lbxCart.DrawMode = DrawMode.OwnerDrawVariable;
            lbxCart.MeasureItem += lbxCart_MeasureItem;
            lbxCart.DrawItem += lbxCart_DrawItem;

            lblSubtotalActual.Text = subTotal.ToString("C", CultureInfo.CurrentCulture);
            taxAmount = subTotal * tax;
            lblTaxActual.Text = taxAmount.ToString("C", CultureInfo.CurrentCulture);
            totalDue = subTotal + taxAmount;
            lblTotalActual.Text = totalDue.ToString("C", CultureInfo.CurrentCulture);
        }
    }
}
