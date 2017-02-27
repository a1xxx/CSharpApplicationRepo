//Created by Alex January 22

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groupProject
{
    class Packages_Products_SuppliersDB
    {
        //method to add product supplier Alex
        public static void AddProductSupplier(int PackageId, int ProductSupplierId)
        {
            //int prodID = 0;
            // prepare connection
            SqlConnection connection = TRAVELEXPERTSDB.GetConnection();

            // prepare the statement
            string insertString = " insert into Packages_Products_Suppliers(PackageId, ProductSupplierId) Values(@PackageId, @ProductSupplierId)";
            SqlCommand insertCommand = new SqlCommand(insertString, connection);
            insertCommand.Parameters.AddWithValue("@PackageId", PackageId);
            insertCommand.Parameters.AddWithValue("@ProductSupplierId", ProductSupplierId);
            try
            {
                // open connection
                connection.Open();

                // execute the statement
                int i = insertCommand.ExecuteNonQuery();
                if (i == 1) // one record inserted
                {
                    // retrieve customer id from the added record

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The selected PackageId and Products Suppliers Id already exists!"); // pass the buck
            }
            finally
            {
                connection.Close();
            }
          
        }
        //method to delete Alex
        public static bool Delete(package psup, ProductsSuppliers pps)
        {
            bool successful = false;

            SqlConnection connection = TRAVELEXPERTSDB.GetConnection();
            string deleteString = "delete from Packages_Products_Suppliers where PackageId = @PackageId and ProductSupplierId=@ProductSupplierId";

            SqlCommand deleteCommand = new SqlCommand(deleteString, connection);            
            deleteCommand.Parameters.AddWithValue("@PackageId", psup.PackageId);
            deleteCommand.Parameters.AddWithValue("@ProductSupplierId", pps.ProductSupplierId);

            try
            {
                connection.Open();
                int count = deleteCommand.ExecuteNonQuery();
                if (count == 1)
                {
                    successful = true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show("Delete supplier from other tables first");
            }
            finally
            {
                connection.Close();
            }

            return successful;
        }

        
        public static List<Packages_Products_Suppliers> GetPackages_Products_Supplierss()
        {
            List< Packages_Products_Suppliers > prods = new List<Packages_Products_Suppliers>(); // product found

            // define the connection
            SqlConnection connection = TRAVELEXPERTSDB.GetConnection();

            // define the select query command
            string selectQuery = "select  PackageId, ps.ProductId, ProdName,pps.ProductSupplierId, SupplierId " +
                                "from Packages_Products_Suppliers pps, Products_Suppliers ps, Products p " +
                                "where pps.ProductSupplierId = ps.ProductSupplierId and ps.ProductId = p.ProductId " +
                                "order by PackageId, ProductSupplierId";
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
                    Packages_Products_Suppliers prod = new Packages_Products_Suppliers();
                    prod.PackageId = Convert.ToInt32(reader["PackageId"]);
                    prod.ProductId = Convert.ToInt32(reader["ProductId"]);
                    prod.ProductName = Convert.ToString(reader["ProdName"]);
                    prod.ProductSupplierId = Convert.ToInt32(reader["ProductSupplierId"]);                    
                    prod.SupplierId = Convert.ToInt32(reader["SupplierId"]);
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

       
    }
}
