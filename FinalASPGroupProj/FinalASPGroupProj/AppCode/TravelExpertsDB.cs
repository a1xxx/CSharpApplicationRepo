using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;


namespace FinalASPGroupProj.AppCode
{
    public class TravelExpertsDB
    {
        public static SqlConnection GetConnection()
        {

            //from chapter 20 page 639 of Murach's C# 2015, first identify the type of database with the datasource
            //then give the directory with attackdbfilename, this string is used by the SqlConnection 
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|\\TravelExperts.mdf; Integrated Security=True;Connect Timeout=30";
            //connect to the database with the above the string using SqlConnection
            SqlConnection conn = new SqlConnection(connString);
            return conn;//returns final connection to database
        }
    }
}