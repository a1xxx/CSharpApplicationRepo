using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//*******************************************************************
//*                                                                 *
//*                             AYI                                 *
//*                                                                 *
//*******************************************************************

namespace groupProject
{
    class SupplierDB
    {

        // retrieves the supplier with given id
        public static Supplier GetSupplier(int SupplierId)
        {
            Supplier sup = null; // supplier found

            // define the connection
            SqlConnection connection = TRAVELEXPERTSDB.GetConnection();

            // define the select query command
            string selectQuery = "select SupplierId, SupName " +
                                 "from suppliers " +
                                 "where SupplierId = @SupplierId";
            SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
            selectCommand.Parameters.AddWithValue("@SupplierId", SupplierId);
            try
            {
                // open the connection
                connection.Open();

                // exectute the select query
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);

                // process the result if any
                if (reader.Read()) // if there is a supplier
                {
                    sup = new Supplier();
                    sup.SupplierId = (int)reader["SupplierId"];
                    sup.SupName = reader["SupName"].ToString();
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

            return sup;
        }

        public static List<Supplier> GetSuppliers()
        {
            List<Supplier> sups = new List<Supplier>(); // supplier found

            // define the connection
            SqlConnection connection = TRAVELEXPERTSDB.GetConnection();

            // define the select query command
            string selectQuery = "select SupplierId, SupName " +
                                 "from suppliers";
            SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
            try
            {
                // open the connection
                connection.Open();

                // exectute the select query
                SqlDataReader reader = selectCommand.ExecuteReader();

                // process the result if any
                while (reader.Read()) // if there is a supplier
                {
                    Supplier sup = new Supplier();
                    sup.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                    sup.SupName = reader["SupName"].ToString();
                    sups.Add(sup);
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
            return sups;
        }

        // insert supplier
        public static int AddSupplier(Supplier sup) // returns the generate supplier id
        {

            
            // prepare connection
            SqlConnection connection = TRAVELEXPERTSDB.GetConnection();

            // prepare the statement
            string insertString = "insert into Suppliers " +
                                  "(SupName, SupplierId) " +
                                  "values(@SupName, @SupplierId)";
            SqlCommand insertCommand = new SqlCommand(insertString, connection);

            insertCommand.Parameters.AddWithValue("@SupplierId", sup.SupplierId);
            insertCommand.Parameters.AddWithValue("@SupName", sup.SupName);

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
            return 3;
        }

        // updates existing suppliers record and returns bool success flag
        public static bool UpdateSupplier(Supplier oldSupplier, Supplier newSupplier)
        {
            bool successful = false;
            SqlConnection connection = TRAVELEXPERTSDB.GetConnection();
            string updateString = "update Suppliers set " +
                                  // "SupplierId = @NewSupplierId, " +
                                  "SupName = @NewSupName " +
                                  "where " + // update succeeds only if record not changed by other users
                                             //  "SupplierId = @OldSupplierId and " +
                                  "SupName = @OldSupName";
            SqlCommand updateCommand = new SqlCommand(updateString, connection);
            //  updateCommand.Parameters.AddWithValue("@OldSupplierId", oldSupplier.SupplierId);
            updateCommand.Parameters.AddWithValue("@OldSupName", oldSupplier.SupName);

            //     updateCommand.Parameters.AddWithValue("@NewSupplierId", newSupplier.SupplierId);
            updateCommand.Parameters.AddWithValue("@NewSupName", newSupplier.SupName);

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
        static public bool DeleteSupplier(Supplier supplier)
        {
            bool successful = false;

            SqlConnection connection = TRAVELEXPERTSDB.GetConnection();
            string deleteString = "delete from Suppliers " +
                                  "where " + // checking for optimistic concurrency
                                             //   "SupplierId = @SupplierId and " +
                                  "SupplierId = @SupplierId";
            SqlCommand deleteCommand = new SqlCommand(deleteString, connection);
           // deleteCommand.Parameters.AddWithValue("@SupplierId", supplier.SupplierId);
            deleteCommand.Parameters.AddWithValue("@SupplierId", supplier.SupplierId);

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
                //throw ex;
                MessageBox.Show("Delete supplier from other tables first");
            }
            finally
            {
                connection.Close();
            }

            return successful;
        }

    }
}
