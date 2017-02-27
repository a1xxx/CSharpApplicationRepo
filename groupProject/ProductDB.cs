using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using groupProject;

//*******************************************************************
//*                                                                 *
//*                             JUSTIN                              *
//*                                                                 *
//*******************************************************************

namespace groupProject
{
    public static class ProductDB
    {

        // retrieves the order with given id
        public static Product GetProduct(int ProductId)
        {
            Product prod = null; // order found

            // define the connection
            SqlConnection connection = TRAVELEXPERTSDB.GetConnection();

            // define the select query command
            string selectQuery = "select ProductId, ProdName " +
                                 "from products " +
                                 "where ProductId = @ProductId";
            SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
            selectCommand.Parameters.AddWithValue("@ProductId", ProductId);
            try
            {
                // open the connection
                connection.Open();

                // exectute the select query
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);

                // process the result if any
                if (reader.Read()) // if there is an oerder
                {
                    prod = new Product();
                    prod.ProductId = (int)reader["ProductId"];
                    prod.ProdName = reader["ProdName"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex; // let the form deal with it

            }
            finally
            {
                // close the connection not matter what
                connection.Close();
            }

            return prod;
        }

        public static List<Product> GetProducts()
        {
            List<Product> prods = new List<Product>(); // product found

            // define the connection
            SqlConnection connection = TRAVELEXPERTSDB.GetConnection();

            // define the select query command
            string selectQuery = "select ProductId, ProdName " +
                                 "from products";
            SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
            try
            {
                // open the connection
                connection.Open();

                // exectute the select query
                SqlDataReader reader = selectCommand.ExecuteReader();

                // process the result if any
                while (reader.Read()) // if there is an oerder
                {
                    Product prod = new Product();
                    prod.ProductId = Convert.ToInt32(reader["ProductId"]);
                    prod.ProdName = reader["ProdName"].ToString();
                    prods.Add(prod);
                }
            }
            catch (Exception ex)
            {
                throw ex; // let the form deal with it
            }
            finally
            {
                // close the connection not matter what
                connection.Close();
            }
            return prods;
        }

        // insert order
        public static int AddProduct(Product prod) // returns the generate order id
        {

            int prodId = 0;

            // prepare connection
            SqlConnection connection = TRAVELEXPERTSDB.GetConnection();

            // prepare the statement
            string insertString = "insert into Products " +
                                  "(ProdName) " +
                                  "values(@ProdName)";
            SqlCommand insertCommand = new SqlCommand(insertString, connection);

            insertCommand.Parameters.AddWithValue("@ProductId", prod.ProductId);
            insertCommand.Parameters.AddWithValue("@ProdName", prod.ProdName);

            try
            {
                // open connection
                connection.Open();

                // execute the statement
                int i = insertCommand.ExecuteNonQuery();

                if (i == 1) // one record is inserted
                {

                }
            }
            catch (Exception ex)
            {
                throw ex; // pass the buck
            }
            finally
            {
                connection.Close();
            }
            return prodId;
        }

        // ubdates existing orders record and returns bool success flag
        public static bool UpdateProduct(Product oldProduct, Product newProduct)
        {
            bool successful = false;
            SqlConnection connection = TRAVELEXPERTSDB.GetConnection();
            string updateString = "update Products set " +
                                 // "ProductId = @NewProductId, " +
                                  "ProdName = @NewProdName " +
                                  "where " + // update succeeds only if record not changed by other users
                                //  "ProductId = @OldProductId and " +
                                  "ProdName = @OldProdName";
            SqlCommand updateCommand = new SqlCommand(updateString, connection);
          //  updateCommand.Parameters.AddWithValue("@OldProductId", oldProduct.ProductId);
            updateCommand.Parameters.AddWithValue("@OldProdName", oldProduct.ProdName);

       //     updateCommand.Parameters.AddWithValue("@NewProductId", newProduct.ProductId);
            updateCommand.Parameters.AddWithValue("@NewProdName", newProduct.ProdName);

            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count == 1)
                {
                    successful = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return successful;
        }

        // Delete operation returns bool success flag
        static public bool DeleteProduct(Product product)
        {
            bool successful = false;

            SqlConnection connection = TRAVELEXPERTSDB.GetConnection();
            string deleteString = "delete from Products " +
                                  "where " + // checking for optimistic concurrency
                                 // "ProductId = @ProductId and " +
                                  "ProdName = @ProdName";
            SqlCommand deleteCommand = new SqlCommand(deleteString, connection);
          //  deleteCommand.Parameters.AddWithValue("@ProductId", product.ProductId);
            deleteCommand.Parameters.AddWithValue("@ProdName", product.ProdName);

            try
            {
                connection.Open();
                int count = deleteCommand.ExecuteNonQuery();
                if (count == 1)
                {
                    successful = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("the existing product is connected with packages, delete the product from packages first");
            }
            finally
            {
                connection.Close();
            }

            return successful;
        }

    }
}

