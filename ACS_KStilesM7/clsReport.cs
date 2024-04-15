using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ACS_KStilesM7
{
    internal class clsReport
    {
        private static StringBuilder html = new StringBuilder();
        private static StringBuilder css = new StringBuilder();

        public static StringBuilder GenerateReport(string title, int orderNum, string col, 
            string productUPC, string productName, string pricePerUnit, string Quantity, string totalPerLine, 
            string subTotal, string taxAmount, string totalDue)
        {
            css.AppendLine("<styles>");
            css.AppendLine("td {padding: 5px; text-align:center; font-weight:bold;");
            css.AppendLine("h1 {color: " + col + ";}");
            css.AppendLine("</styles>");

            html.AppendLine("<html>");
            html.AppendLine($"<head>{css}<title>{title}</title></head>");
            html.AppendLine("<body>");
            html.AppendLine($"<h1>{title}</h1>");

            ReportDetailsReceipt();
            html.AppendLine("</body></html>");

            return html;
        }

        public static void ReportDetailsReceipt()
        {
            html.AppendLine("<table>");
            html.AppendLine("<tr><td>Order ID</td><td>Product UPC</td><td>Product Name</td><td>Price Per Unit</td><td>Quantity</td><td>Total Per Line</td></tr>");
            html.AppendLine("<tr><td colspan=6><hr/></td></tr>");
            for (int i = 0; i < frmShop.Orders.Count; i++)
            {
                //first one needs to be order ID,
                //try using another sql statement in the database
                //grab MAX OrderID and add it to i ^^^
                html.AppendLine($"<td>{frmShop.Orders[i].GetProductName()}</td>");
                html.AppendLine($"<td>{frmShop.Orders[i].GetProductUPC()}</td>");
                html.AppendLine($"<td>{frmShop.Orders[i].GetProductName()}</td>");
                html.AppendLine($"<td>{frmShop.Orders[i].GetUnitPrice()}</td>");
                html.AppendLine($"<td>{frmShop.Orders[i].GetQuantity()}</td>");                
                html.AppendLine($"<td>{frmShop.Orders[i].GetTotalPerLine()}</td>");
            }
        }
    }
}
