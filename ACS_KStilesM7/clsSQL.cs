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
        ////connection string
        //private const string CONNECT_STRING =
        //        @"Server=3.130.26.194;" +
        //        "Database=ClothingStoreStilesKSP24;" +
        //        "User Id=kstilessp242353;" +
        //        "password=z4dKYwm3G!";

        ////build a connection to the books db
        //private static SqlConnection _cntDatabase = new SqlConnection(CONNECT_STRING);

        ////add the command object
        //private static SqlCommand _sqlProductCommand,
        //    _sqlOrderCommand,
        //    _sqlPurchaseDetailsCommand;

        ////data adapter
        //private static SqlDataAdapter _daProduct = new SqlDataAdapter(),
        //    _daOrder = new SqlDataAdapter(),
        //    _daPurchaseDetails = new SqlDataAdapter();

        ////data tables
        //private static DataTable _dtProductTable = new DataTable(),
        //    _dtOrderTable = new DataTable(),
        //    _dtPurchaseDetailsTable = new DataTable();

        private static StringBuilder errorMessages = new StringBuilder();
        public static void TypesDatabaseCommand()
        {
            try
            {
                frmShop._taTypes.Fill(frmShop._dsTypes.Types);
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
                    MessageBox.Show(errorMessages.ToString(), "Error on TypeDatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error on TypeDatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static void PurchaseDatabaseCommand()
        {
            try
            {
                frmShop._taPurchases.Fill(frmShop._dsPurchases.PurchaseDetails);
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
                    MessageBox.Show(errorMessages.ToString(), "Error on PurchaseDatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error on PurchaseDatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
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
                    MessageBox.Show(errorMessages.ToString(), "Error on ProductDatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error on ProductDatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void OrderDatabaseCommand()
        {
            try
            {
                frmShop._taOrders.Fill(frmShop._dsOrders.Orders);
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
                    MessageBox.Show(errorMessages.ToString(), "Error on OrderDatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error on OrderDatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void CustomerDatabaseCommand()
        {
            try
            {
                frmShop._taCustomers.Fill(frmShop._dsCustomers.Customers);
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
                    MessageBox.Show(errorMessages.ToString(), "Error on CustomerDatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error on CustomerDatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void AddedToCart(int productUPC, int Quantity)
        {
            try
            {
                
                frmShop._taProducts.AddToCart(Quantity, productUPC);
                frmShop._taProducts.Update(frmShop._dsProducts.Products);
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
                    MessageBox.Show(errorMessages.ToString(), "Error on AddedToCart", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error on AddedToCart", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void RemovedFromCart(int productUPC, int Quantity)
        {
            try
            {

                frmShop._taProducts.RemovedFromCart(Quantity, productUPC);
                frmShop._taProducts.Update(frmShop._dsProducts.Products);
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
                    MessageBox.Show(errorMessages.ToString(), "Error on RemovedFromCartd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error on RemovedFromCart", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static int CreateOrderID()
        {
            int maxOrderID = 0;
            try
            {

                maxOrderID = (int)frmShop._taOrders.GetMaxOrderID();
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
                    MessageBox.Show(errorMessages.ToString(), "Error on CreateOrderID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error on CreateOrderID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return maxOrderID;
        }

        public static void CreateOrder(int orderID, int productUPC)
        {
            try
            {

                frmShop._taOrders.CreateOrder(orderID, productUPC, 2);
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
                    MessageBox.Show(errorMessages.ToString(), "Error on CreateOrder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error on CreateOrder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void CreatePurchase(int orderID, int productUPC, int Quantity)
        {
            try
            {
                frmShop._taPurchases.CreatePurchase(orderID, productUPC, Quantity);
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
                    MessageBox.Show(errorMessages.ToString(), "Error on CreatePurchase", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error on CreatePurchase", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }       
    }
}
