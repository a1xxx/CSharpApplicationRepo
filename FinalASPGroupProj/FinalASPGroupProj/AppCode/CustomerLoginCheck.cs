using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows.Forms;


namespace FinalASPGroupProj.AppCode
{
    public partial class CustomerLoginCheck :System.Web.UI.Page
    {

        public static bool checkcustlogin(int ID, string pass)
        {
            bool logged = true;
            //loggedin =  session [false];
            //int CustID = (int) Application ["CustID"];
           // CustIDD = (int)Application["CustID"] ;

            SqlConnection connection = TravelExpertsDB.GetConnection();

            // prepare the statement
            string PassString = "select CustomerID, CustPassword from Customers";
            SqlCommand selectCommand = new SqlCommand(PassString, connection);
            try
            {
                // open the connection
                connection.Open();

                // execute the query
                SqlDataReader reader = selectCommand.ExecuteReader();

                // process if Technician exists
                while (reader.Read())
                {

                    //define values of individual instance
                    Customer cust1 = new Customer();
                    cust1.CustPassword = (string)reader["CustPassword"];
                    cust1.CustomerID = (int)reader["CustomerID"];
                    if ((cust1.CustPassword == pass) && (cust1.CustomerID == ID))
                    {
                        //loggedin = true;
                        // Application["CustID"] = ID;
                        logged = true;
                        return logged;

                    }
                    else
                    {
                        logged = false;
                        return logged;
                    }

                   
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
            return logged;


        }
    }
}