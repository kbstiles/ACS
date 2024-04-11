using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACS_KStilesM7
{
    internal class clsSQL
    {

        private static StringBuilder errorMessages = new StringBuilder();

        public static void ProductDatabaseCommand()
        {
            try
            {
                frmShop._taProducts.Fill(frmShop._dsProducts.Products);
            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "Line Number: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(errorMessages.ToString(), "Error on EmployeeDatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error on EmployeeDatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void AddedToCart(ComboBox quantity)
        {

        }
    }
}
