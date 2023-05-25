using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ConsoleApp3
{
    /*
    class SQLClass
    {
        public static void Main(String[] args)
        {
            // Connection string
            //string connectionString = @"Data Source=(LAPTOP-TQDHEUKU\SQLEXPRESS);Initial Catalog=Northwind;Integrated Security=True";
            //string connectionString = @"Data Source=(localhost);Initial Catalog=Northwind;Integrated Security=True";
            string connectionString = @"Data Source=LAPTOP-TQDHEUKU\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=true";

            //Define the query that is to be executed
            //string queryString = "SELECT ProductID, UnitPrice, ProductName from dbo.products " +
            //                       "WHERE UnitPrice > @parameter " + " ORDER BY UnitPrice DESC ";
            string queryString = "SELECT ProductID from dbo.products ORDER BY UnitPrice DESC ";

            Console.WriteLine(queryString);
            // mention parameter value
            //int pricepoint = 5;

            // create and open connnection in a using block. This is to ensure 
            // that all resources will be released after usage.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // create the command and parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                //command.Parameters.AddWithValue("@parameter", pricepoint);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    Console.WriteLine("inside the while loop");
                    Console.WriteLine(reader[0]);
                }
                reader.Close();
            }

            Console.ReadLine();
        }
    }
*/
}