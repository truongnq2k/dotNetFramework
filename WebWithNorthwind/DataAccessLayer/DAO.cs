using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class DAO
    {
        //Get connection string from App.config
        static string ConnectionStr = ConfigurationManager.ConnectionStrings["NorthWind"].ConnectionString;

        /**
         * Method get data table no parameters
         */
        static public DataTable GetDataTable(string sqlSelect)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionStr);
                
                SqlCommand sqlCommand = new SqlCommand(sqlSelect);
                sqlCommand.Connection = sqlConnection;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlSelect, sqlConnection);
                sqlDataAdapter.SelectCommand = sqlCommand;

                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /**
         * Method get data table with parameters
         */
        static public DataTable GetDataTable(SqlCommand sqlCommand)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionStr);

                sqlCommand.Connection = sqlConnection;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = sqlCommand;

                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /**
        * Method update data table
        */
        static public bool UpdateDataTable(SqlCommand sqlCommand)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionStr);

                sqlCommand.Connection = sqlConnection;

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                return true; 
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
