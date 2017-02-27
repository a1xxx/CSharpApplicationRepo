using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace FinalASPGroupProj.AppCode
{
    public class CustomerDB
    {
        public static int Registercustomer(Customer cst) // returns generated customer id
        {
            int PackageId = 0;
            SqlConnection connection = TravelExpertsDB.GetConnection();

            // prepare the statement
            string insertString = "insert into Customers " +
                                  "(CustFirstName, CustLastName, CustPassword, CustGender, CustAddress, CustCity, CustProv, CustPostal, Custcountry, CustHomePhone, CustBusPhone, CustEmail, CustAbout ) " +
                                  "values(@CustFirstName, @CustLastName, @CustPassword, @CustGender, @CustAddress, @CustCity, @CustProv, @CustPostal, @Custcountry, @CustHomePhone, @CustBusPhone, @CustEmail, @CustAbout )";
            SqlCommand insertCommand = new SqlCommand(insertString, connection);
            // insertCommand.Parameters.AddWithValue("@PackageId", pkg.PackageId);
      
            insertCommand.Parameters.AddWithValue("@CustFirstName", cst.CustFirstName);
            insertCommand.Parameters.AddWithValue("@CustLastName", cst.CustLastName);
            insertCommand.Parameters.AddWithValue("@CustPassword", cst.CustPassword);
            insertCommand.Parameters.AddWithValue("@CustGender", cst.CustGender);
            insertCommand.Parameters.AddWithValue("@CustAddress", cst.CustAddress);
         //   insertCommand.Parameters.AddWithValue("@custAddress1", cst.custAddress1);
            insertCommand.Parameters.AddWithValue("@CustCity", cst.CustCity);
            insertCommand.Parameters.AddWithValue("@CustProv", cst.CustProv);
            insertCommand.Parameters.AddWithValue("@CustPostal", cst.CustPostal);
            insertCommand.Parameters.AddWithValue("@Custcountry", cst.Custcountry);
            insertCommand.Parameters.AddWithValue("@CustBusPhone", cst.CustBusPhone);
            insertCommand.Parameters.AddWithValue("@CustHomePhone", cst.CustHomePhone);
            insertCommand.Parameters.AddWithValue("@CustEmail", cst.CustEmail);
            insertCommand.Parameters.AddWithValue("@CustAbout", cst.CustAbout);
          


            try
            {
                // open connection
                connection.Open();

                // execute the statement
                int i = insertCommand.ExecuteNonQuery();
                if (i == 1) // one record inserted
                {
                    // retrieve customer id from the added record
                    //    string selectString = "select @PackageId " +
                    //                           "from packages";
                    //    SqlCommand selectCommand = new SqlCommand(selectString, connection);
                    //    PackageId = Convert.ToInt32(selectCommand.ExecuteScalar()); // (int) does not work!!!
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
            return PackageId;
        }

        public List<Customer> GetCustomers()
        {
        
            //instantiatae list
            List<int> custList = new List<int>();

            //define query string
            string sql = "SELECT CustomerID "
                + "FROM Customers ORDER BY CustomerID";

            //using the connection and query
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    //open the connection
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    //while the reader is valid
                    while (dr.Read())
                    {
                        //instantiate new custID
                        int custID = new int();
                        //define the 
                        custID = Convert.ToInt32(dr["CustomerID"]);

                        custList.Add(custID);
                    }
                    dr.Close();
                }
            
            return custList;
        }

    }



    }
}