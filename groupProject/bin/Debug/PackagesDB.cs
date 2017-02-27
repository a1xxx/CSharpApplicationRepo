//created Jan 2017 by Mike Rabatich
//This class handles database queries sent from the main form
//

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

//*******************************************************************
//*                                                                 *
//*                             MIKE                                *
//*                                                                 *
//*******************************************************************

namespace groupProject
{
    public static class PackagesDB
    {


        //the get order method returns an individual order object defined by the OrderID passed
        //by order form

        public static package GetPackage(int PackageID)
        {

            // reference to new (null) order object
            package pkg = null;

            //create connection to Northwinds database
            SqlConnection connection = TRAVELEXPERTSDB.GetConnection();

            // create select command that pulls specific values from Orders table for 1 Order
            string selectQuery = "select * " +
                                 "from Packages " +
                                 "where PackageId = @PackageId";

            //Represents a stored procedure to execute against a SQL Server database
            //info from website:   msdn.microsoft.com/en-us/library/system.data.sqlclient.sqlcommand(v=vs.110).aspx
            SqlCommand selectCommand = new SqlCommand(selectQuery, connection);

            //use the store procedure to select the order using the parameter OrderID passed from the main form
            selectCommand.Parameters.AddWithValue("@PackageId", PackageID);

            try
            {
                // open connection
                connection.Open();

                //DataReader provides a way of reading a forward-only stream of rows from a SQL Server database
                //Info from msdn.microsoft.com/en-us/library/system.data.sqlclient.sqldatareader(v=vs.110).aspx
                SqlDataReader reader = selectCommand.ExecuteReader();


                //this if statements processes one row at a time
                if (reader.Read())
                {

                    //each row is a new object during importing
                    pkg = new package();

                    //define the OrderID and CustomerID of thew new object by using the reader
                    pkg.PackageId = (int)reader["PackageId"];
                    pkg.PkgName = (string)reader["PkgName"];

                    DateTime tripEnd = (DateTime)reader["PkgEndDate"];
                    pkg.PkgEndDate = tripEnd.ToString("d");

                    DateTime tripStart = (DateTime)reader["PkgStartDate"];
                    pkg.PkgStartDate = tripStart.ToString("d");
                   
                  
                    pkg.PkgDesc = (string)reader["PkgDesc"];
                    decimal cost = (decimal)reader["PkgAgencyCommission"];
                    pkg.PkgAgencyCommission = cost.ToString("C");

                    decimal price= (decimal)reader["PkgBasePrice"];
                    pkg.PkgBasePrice = price.ToString("C");
                    //pkg.Products = (string)reader["Products"];



                }

                //this catches the null exceptions on import
            }
            catch (Exception ex)
            {
                // throw exception to the form to handle
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            //if no exceptions return the imported order object
            return pkg;
        }


        public static List<package> GetPackages()
        {
            //make empty list
            List<package> packages = new List<package>();
            //new Order object
            package pkg;
            //create connection
            SqlConnection connection = TRAVELEXPERTSDB.GetConnection();

            //create selectcommand
            string selectString = "select PackageId,PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission, Products from packages " +
                                  "order by PackageId";
            SqlCommand selectCommand = new SqlCommand(selectString, connection);
            try
            {

                connection.Open();

                //run the selectCommand and process the results adding Orders to the list
                SqlDataReader reader = selectCommand.ExecuteReader();

                //process one row at a time
                while (reader.Read())
                {
                    pkg = new package();

                    //define the OrderID and CustomerID of thew new object by using the reader
                    pkg.PackageId = (int)reader["PackageId"];
                    pkg.PkgName = (string)reader["PkgName"];

                    DateTime tripEnd = (DateTime)reader["PkgEndDate"];
                    pkg.PkgEndDate = tripEnd.ToString("d");

                    DateTime tripStart = (DateTime)reader["PkgStartDate"];
                    pkg.PkgStartDate = tripStart.ToString("d");


                    pkg.PkgDesc = (string)reader["PkgDesc"];
                    decimal cost = (decimal)reader["PkgAgencyCommission"];
                    pkg.PkgAgencyCommission = cost.ToString("C");

                    decimal price = (decimal)reader["PkgBasePrice"];
                    pkg.PkgBasePrice = price.ToString("C");

                    packages.Add(pkg);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();

            }
            return packages;
        }


        public static int AddPackage(package pkg) // returns generated customer id
        {
            int PackageId = 0;
            SqlConnection connection = TRAVELEXPERTSDB.GetConnection();

            // prepare the statement
            string insertString = "insert into packages " +
                                  "(PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission) " +
                                  "values(@PkgName, @PkgStartDate, @PkgEndDate, @PkgDesc, @PkgBasePrice, @PkgAgencyCommission)";
            SqlCommand insertCommand = new SqlCommand(insertString, connection);
            // insertCommand.Parameters.AddWithValue("@PackageId", pkg.PackageId);
            insertCommand.Parameters.AddWithValue("@PkgName", pkg.PkgName);
            insertCommand.Parameters.AddWithValue("@PkgStartDate", pkg.PkgStartDate);
            insertCommand.Parameters.AddWithValue("@PkgEndDate", pkg.PkgEndDate);
            insertCommand.Parameters.AddWithValue("@PkgDesc", pkg.PkgDesc);
            insertCommand.Parameters.AddWithValue("@PkgBasePrice", pkg.PkgBasePrice);
            insertCommand.Parameters.AddWithValue("@PkgAgencyCommission", pkg.PkgAgencyCommission);
            


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


        public static bool UpdatePackage(package oldPackage, package newPackage)
        {
            bool successful = false;
            SqlConnection connection = TRAVELEXPERTSDB.GetConnection();

            string updateString = "update packages set " +
                                  //   "PackageId = @newPackageId, " +
                                  "PkgName = @newPkgName, " +
                                  "PkgStartDate = @newPkgStartDate, " +
                                  "PkgEndDate = @newPkgEndDate, " +
                                  "PkgDesc = @newPkgDesc, " +
                                  "PkgBasePrice = @newPkgBasePrice, " +
                                  "PkgAgencyCommission = @newPkgAgencyCommission " +
                                  //"Products = @newProducts " +
                                  "where " + // update succeeds only if record not changed by other users
                                  "PackageId = @oldPackageId and " +
                                  "PkgName = @oldPkgName and " +
                                  "PkgStartDate = @oldPkgStartDate and " +
                                  "PkgEndDate = @oldPkgEndDate and " +
                                  "PkgDesc = @oldPkgDesc and " +
                                  "PkgBasePrice = @oldPkgBasePrice and " +
                                  "PkgAgencyCommission = @oldPkgAgencyCommission";
            //  "Products = @oldProducts";

            SqlCommand updateCommand = new SqlCommand(updateString, connection);
            //  updateCommand.Parameters.AddWithValue("@oldPackageId", oldPackage.PackageId);
            updateCommand.Parameters.AddWithValue("@oldPkgName", oldPackage.PkgName);
            updateCommand.Parameters.AddWithValue("@oldPkgStartDate", oldPackage.PkgStartDate);
            updateCommand.Parameters.AddWithValue("@oldPkgEndDate", oldPackage.PkgEndDate);
            updateCommand.Parameters.AddWithValue("@oldPkgDesc", oldPackage.PkgDesc);
            updateCommand.Parameters.AddWithValue("@oldPkgBasePrice", oldPackage.PkgBasePrice);
            updateCommand.Parameters.AddWithValue("@oldPkgAgencyCommission", oldPackage.PkgAgencyCommission);
            // updateCommand.Parameters.AddWithValue("@oldProducts", oldPackage.Products);

            // updateCommand.Parameters.AddWithValue("@newPackageId", newPackage.PackageId);
            updateCommand.Parameters.AddWithValue("@newPkgName", newPackage.PkgName);
            updateCommand.Parameters.AddWithValue("@newPkgStartDate", newPackage.PkgStartDate);
            updateCommand.Parameters.AddWithValue("@newPkgEndDate", newPackage.PkgEndDate);
            updateCommand.Parameters.AddWithValue("@newPkgDesc", newPackage.PkgDesc);
            updateCommand.Parameters.AddWithValue("@newPkgBasePrice", newPackage.PkgBasePrice);
            updateCommand.Parameters.AddWithValue("@newPkgAgencyCommission", newPackage.PkgAgencyCommission);
            //updateCommand.Parameters.AddWithValue("@newProducts", newPackage.Products);
            updateCommand.Parameters.AddWithValue("@OldPackageId", oldPackage.PackageId);

            //     updateCommand.Parameters.AddWithValue("@NewProductId", newProduct.ProductId);
            updateCommand.Parameters.AddWithValue("@NewPackageId", newPackage.PackageId);

            
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
                connection.Close();
            }
            return successful;
        }

        public static bool Delete(int ps)
        {
            bool successful = false;

            SqlConnection connection = TRAVELEXPERTSDB.GetConnection();
            string deleteString = "delete from Packages where PackageId =@PackageId";

            SqlCommand deleteCommand = new SqlCommand(deleteString, connection);
            deleteCommand.Parameters.AddWithValue("@PackageId", ps);

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
