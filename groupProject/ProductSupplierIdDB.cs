using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//*******************************************************************
//*                                                                 *
//*                             ALEX                                *
//*                                                                 *
//*******************************************************************

namespace groupProject
{
    public static class ProductSupplierIdDB
    {
        public static List<ProductsSuppliers> GetProductsSupplierId()
        {
            List<ProductsSuppliers> productssupplierid = new List<ProductsSuppliers>();
            SqlConnection connection = TRAVELEXPERTSDB.GetConnection();
            string selectStatement = "select ProductSupplierId, ProductId, SupplierId "
                                   + "from Products_Suppliers  "
                                   + "ORDER BY ProductSupplierId";
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    ProductsSuppliers p = new ProductsSuppliers();
                    p.ProductSupplierId = Convert.ToInt32(reader["ProductSupplierId"]);
                    p.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                    p.ProductId = Convert.ToInt32(reader["ProductId"]);
                    productssupplierid.Add(p);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return productssupplierid;

        }

        public static ProductsSuppliers GetSelected(int pId)
        {
            ProductsSuppliers selected = new ProductsSuppliers();
            SqlConnection connection = TRAVELEXPERTSDB.GetConnection(); 
            string selectStatement = "select p.ProductId, ProdName, ProductSupplierId, ps.SupplierId, s.SupName "+
                                        "from Products p, Products_Suppliers ps, suppliers s "+
                                       "where p.ProductId = ps.ProductId and ps.SupplierId = s.SupplierId and ProductSupplierId = @ProductSupplierId";
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@ProductSupplierId", pId);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.Read())
                {
                    
                    selected.ProductSupplierId = Convert.ToInt32(reader["ProductSupplierId"]);
                    selected.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                    selected.ProductId = Convert.ToInt32(reader["ProductId"]);
                    selected.SupName = reader["SupName"].ToString();
                    selected.ProdName= reader["ProdName"].ToString();

                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return selected;

        }

        public static List<ProductsSuppliers> GetSupplierName(int selectedprodid)
        {
            List<ProductsSuppliers> productssupplierid = new List<ProductsSuppliers>();
            SqlConnection connection = TRAVELEXPERTSDB.GetConnection();
            string selectStatement = "select SupName, ps.SupplierId "+
                                       "from Products_Suppliers ps, Suppliers s "+
                                        "where ps.SupplierId = s.SupplierId and ProductId = @ProductId " +
                                        "order by SupName";
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@ProductId", selectedprodid);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    ProductsSuppliers p = new ProductsSuppliers();
                    p.SupName= reader["SupName"].ToString();
                    p.SupplierId = Convert.ToInt32(reader["SupplierId"]);                    
                    productssupplierid.Add(p);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return productssupplierid;

        }

        public static List<ProductsSuppliers> GetProductSupplierId2Inputs(int selectedprodid, int? selectedsupplier)
        {
            List<ProductsSuppliers> productssupplierid = new List<ProductsSuppliers>();
            SqlConnection connection = TRAVELEXPERTSDB.GetConnection();
            string selectStatement = "select ProductSupplierId  from Products_Suppliers "+
                                     "where ProductId= @ProductId and SupplierId=@SupplierId";
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@ProductId", selectedprodid);
            selectCommand.Parameters.AddWithValue("@SupplierId", selectedsupplier);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    ProductsSuppliers p = new ProductsSuppliers();                    
                    p.ProductSupplierId = Convert.ToInt32(reader["ProductSupplierId"]);
                    productssupplierid.Add(p);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return productssupplierid;
        }

        public static int AddProductSupplier(ProductsSuppliers productsupplier)
        {
            int prodID = 0;
            // prepare connection
            SqlConnection connection = TRAVELEXPERTSDB.GetConnection();

            // prepare the statement
            string insertString = "insert into Products_Suppliers(ProductId, SupplierId) Values(@ProductId, @SupplierId)";
            SqlCommand insertCommand = new SqlCommand(insertString, connection);
            insertCommand.Parameters.AddWithValue("@ProductId", productsupplier.ProductId);
            insertCommand.Parameters.AddWithValue("@SupplierId", productsupplier.SupplierId);
            try
            {
                // open connection
                connection.Open();

                // execute the statement
                int i = insertCommand.ExecuteNonQuery();
                if (i == 1) // one record inserted
                {
                    // retrieve customer id from the added record
                    string selectString = "select ident_current('Products_Suppliers') from Products_Suppliers";
                    SqlCommand selectCommand = new SqlCommand(selectString, connection);
                    prodID = Convert.ToInt32(selectCommand.ExecuteScalar()); // (int) does not work!!!
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
            return prodID;
        }

        public static List<ProductsSuppliers> GetUniqueProSupId(string logic)
        {
            List<ProductsSuppliers> productssupplierid = new List<ProductsSuppliers>();
            SqlConnection connection = TRAVELEXPERTSDB.GetConnection();
            string selectStatement;
            if (logic == "p")
            {
                selectStatement = "select ProductId, ProdName from Products ";
            }
            else
            {
                selectStatement = "select SupplierId, SupName from Suppliers ";
            }
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    ProductsSuppliers p = new ProductsSuppliers();
                    if (logic == "p")
                    {
                        p.ProductId = Convert.ToInt32(reader["ProductId"]);
                        p.ProdName = reader["ProdName"].ToString();
                    }
                    else
                    {
                        p.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                        p.SupName = reader["SupName"].ToString();
                    }
                    productssupplierid.Add(p);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return productssupplierid;

        }
        public static bool UpdateProductSupplier(ProductsSuppliers oldProd, ProductsSuppliers newProd)
        {
            bool successful = false;
            SqlConnection connection = TRAVELEXPERTSDB.GetConnection();
            string updateString = "update Products_Suppliers set ProductId = @newProd, SupplierId = @newSup " +
                                    "where ProductSupplierId = @oldProdSupId and ProductId = @oldProdId and SupplierId = @oldSupId";

            SqlCommand updateCommand = new SqlCommand(updateString, connection);
            updateCommand.Parameters.AddWithValue("@newProd", newProd.ProductId);
            updateCommand.Parameters.AddWithValue("@newSup", newProd.SupplierId);
            updateCommand.Parameters.AddWithValue("@oldProdSupId", oldProd.ProductSupplierId);
            updateCommand.Parameters.AddWithValue("@oldProdId", oldProd.ProductId);
            updateCommand.Parameters.AddWithValue("@oldSupId", oldProd.SupplierId);

            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count == 1)
                    successful = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //connection.Close();
            }
            return successful;
        }

        public static bool Delete(int ps)
        {
            bool successful = false;

            SqlConnection connection = TRAVELEXPERTSDB.GetConnection();
            string deleteString = "delete from Products_Suppliers where ProductSupplierId=@ProductSupplierId"; 

            SqlCommand deleteCommand = new SqlCommand(deleteString, connection);
            deleteCommand.Parameters.AddWithValue("@ProductSupplierId", ps);          

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

            }
            finally
            {
                connection.Close();
            }

            return successful;
        }

    }
    
}
