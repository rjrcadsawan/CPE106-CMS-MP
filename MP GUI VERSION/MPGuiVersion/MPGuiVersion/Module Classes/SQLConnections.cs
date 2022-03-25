using System;
using System.Collections.Generic;
using System.Text;

using System.Data.SqlClient;

namespace MPGuiVersion
{
    static class SQLConnections
    {
        static void connectToSQL(out SqlConnection sql_conn, out bool connected, out string message)
        {
            // Try - Except Block, just in case SQL Connection Fails
            try
            {
                // Connection String based on Server Connector by Visual Studio
                string connection_string = "Data Source=ASUS-ACE;Initial Catalog=CMSData;Integrated Security=True";

                // Creates new Connection Object based on connection string
                sql_conn = new SqlConnection(connection_string);

                // Opens the Connection
                sql_conn.Open();

                //MessageBox.Show("Connection with the CMSData was succesfully established");
                connected = true; // Used for testing purposes
                message = "Connected";
            }
            catch (Exception ex)
            {
                // Connection Failed
                sql_conn = null;
                message = $"An Exception has occurred: \n{ex.Message}";
                connected = false;

            }

        }

        static void getData(bool connected, string table, string column, string new_data, out SqlDataReader results)
        {
            results = null; // temporary
        }

        static void removeData(bool connected, string table, string column, string new_data, out string exception)
        {
            try
            {
                exception = "";
            } catch (Exception ex) {
                exception = ex.Message;

            }
                
        }

        static void updateData(bool connected, string table, string column, string new_data, out string exception)
        {
            try
            {
                exception = "";
            }
            catch (Exception ex)
            {
                exception = ex.Message;
            }
        }

        static void tableInspection(string[] tables)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        static void checkIfTableExists(string table)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }
    }
}
