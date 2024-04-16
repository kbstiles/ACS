using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Globalization;

namespace ACS_KStilesM7
{
    internal class clsReports
    {
        private static StringBuilder html = new StringBuilder();
        private static StringBuilder css = new StringBuilder();

        public static StringBuilder GenerateReport(string title, string col)
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
            int count = 1;

            html.AppendLine("<table>");
            html.AppendLine("<tr><td>Order ID</td><td>Product UPC</td><td>Product Name</td><td>Price Per Unit</td><td>Quantity</td><td>Total Per Line</td></tr>");
            html.AppendLine("<tr><td colspan=><hr/></td></tr>");
            for (int i = 0; i < frmShop.Orders.Count; i++)
            {
                frmShop.Orders[i].SetOrderID(clsSQL.CreateOrderID() + count);

                html.Append("<tr>");
                html.AppendLine($"<td>{frmShop.Orders[i].GetOrderID()}</td>");
                html.AppendLine($"<td>{frmShop.Orders[i].GetProductUPC()}</td>");
                html.AppendLine($"<td>{frmShop.Orders[i].GetProductName()}</td>");                
                html.AppendLine($"<td>{frmShop.Orders[i].GetUnitPrice()}</td>");
                html.AppendLine($"<td>{frmShop.Orders[i].GetQuantity()}</td>");                
                html.AppendLine($"<td>{frmShop.Orders[i].GetTotalPerLine()}</td>");
                html.Append("</tr>");
                html.AppendLine("<tr><td colspan=6><hr/></td></tr>");
                count++;
            }
            html.AppendLine("</table>");

            html.AppendLine("<table>");
            html.AppendLine("<tr><td>Subtotal</td><td>Tax Amount</td><td>Totale Due</td></tr>");
            html.AppendLine("<tr><td colspan=3><hr/></td></tr>");
            html.AppendLine("<tr>");
            html.AppendLine($"<td>{frmCart.cal.GetSubTotal().ToString("C", CultureInfo.CurrentCulture)}</td>");
            html.AppendLine($"<td>{frmCart.cal.GetTaxAmount().ToString("C", CultureInfo.CurrentCulture)}</td>");
            html.AppendLine($"<td>{frmCart.cal.GetTotalDue().ToString("C", CultureInfo.CurrentCulture)}</td>");
            html.AppendLine("</tr>");
            html.AppendLine("</table>");
        }

        public static void PrintReport(StringBuilder html)
        {
            try
            {
                //DateTime today = DateTime.Now;
                //using (StreamWriter writer = new StreamWriter($"{today.ToString("yyyy-MM-dd-HHmmss")} - Report.html"))
                using (StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Report.html"))
                {
                    writer.WriteLine(html);
                }
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Report.html");

            }
            catch (Exception)
            {
                MessageBox.Show("You currently do not have write permissions for this feature.", "Error with System Permissions",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
