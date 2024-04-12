using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACS_KStilesM7
{
    public class clsOrderDetails
    {
        string productName;

        decimal unitPrice;

        int quantity,
            productUPC;

        public int GetProductUPC()
        {
            return productUPC;
        }

        public void SetProductUPC(int productUPC)
        {
            this.productUPC = productUPC;
        }

        public string GetProductName()
        {
            return productName;
        }

        public void SetProductName(string productName)
        {
            this.productName = productName;
        }

        public decimal GetUnitPrice()
        {
            return unitPrice;
        }

        public void SetUnitPrice(decimal unitPrice)
        {
            this.unitPrice = unitPrice;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public void SetQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public clsOrderDetails(int productUPC, string productName, decimal unitPrice, int orderQuantity)
        {
            SetProductUPC(productUPC);
            SetProductName(productName);
            SetUnitPrice(unitPrice);
            SetQuantity(orderQuantity);
        }
    }
}
