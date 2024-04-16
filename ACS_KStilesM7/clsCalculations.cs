using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACS_KStilesM7
{
    public class clsCalculations
    {
        decimal subTotal,
            taxAmount,
            totalDue;
        public clsCalculations(decimal subTotal, decimal taxAmount, decimal totalDue)
        {
            SetSubTotal(subTotal);
            SetTaxAmount(taxAmount);
            SetTotalDue(totalDue);
        }

        public decimal GetSubTotal()
        {
            return subTotal;
        }

        public void SetSubTotal(decimal subTotal)
        {
            this.subTotal = subTotal;
        }

        public decimal GetTaxAmount()
        {
            return taxAmount;
        }

        public void SetTaxAmount(decimal taxAmount)
        {
            this.taxAmount = taxAmount;
        }

        public decimal GetTotalDue()
        {
            return totalDue;
        }

        public void SetTotalDue(decimal totalDue)
        {
            this.totalDue = totalDue;
        }
    }
}
