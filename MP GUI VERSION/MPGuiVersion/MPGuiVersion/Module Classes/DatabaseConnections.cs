using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace MPGuiVersion
{
    public static class DatabaseConnection
    {
        public static void connectToSQL(out SqlConnection sql_conn, out bool connected, out string message)
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

        public static void disconnectSQL(SqlConnection sql_conn, out bool closed)
        {
            try
            {
                sql_conn.Close();
                closed = true;
            }                
            catch 
            {
                closed = false;
            }
        }

        public static DataView getDatas(SqlConnection conn, string type)
        {
            SqlCommand SP_getCommand = null;

            switch(type){
                case "Employees":
                    SP_getCommand = new SqlCommand("getAllEmployees", conn);
                    break;
                case "Items":
                    SP_getCommand = new SqlCommand("getAllItems", conn);
                    break;
                case "Tasks":
                    SP_getCommand = new SqlCommand("getAllTasks", conn);
                    break;
                case "Transactions":
                    SP_getCommand = new SqlCommand("getAllTransactions", conn);
                    break;
                default:
                    break;
            }

            SP_getCommand.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter SDA = new SqlDataAdapter(SP_getCommand);
            DataTable DT = new DataTable();
            SDA.Fill(DT);
            return DT.DefaultView;

        }


        public static DataView getPermissions(SqlConnection conn)
        {
            SqlCommand SP_getCommand = new SqlCommand("SELECT * FROM PRIVILEGE", conn);
            SqlDataAdapter SDA = new SqlDataAdapter(SP_getCommand);
            DataTable DT = new DataTable();
            SDA.Fill(DT);
            return DT.DefaultView;
        }


        public static void deleteEmployee(SqlConnection conn, int EID)
        {
            SqlCommand SP_deleteEmployee = new SqlCommand("deleteEmployee", conn);
            SP_deleteEmployee.CommandType = CommandType.StoredProcedure;

            SP_deleteEmployee.Parameters.AddWithValue("@EmployeeID", EID);
            SP_deleteEmployee.ExecuteNonQuery();
        }
        public static void addEmployees(SqlConnection conn, Employee E)
        {
            //EXECUTE [createEmployee] 1, 'Rence Joseph', 'Romero', 'Cadsawan', '', 1, 'Software', 'Senior Dev', 'rjrcadsawan@mymail.mapua.edu.ph', '200000'
            //@EmployeeID @FirstName @MiddleName @LastName @Suffix @Sex @Department @Position @EmailAddress @Salary

 
            SqlCommand SP_addemployees = new SqlCommand("createEmployee", conn);
            SP_addemployees.CommandType = CommandType.StoredProcedure;

            SP_addemployees.Parameters.AddWithValue("@employeeID", E.EmployeeID);
            SP_addemployees.Parameters.AddWithValue("@FirstName", E.FirstName);
            SP_addemployees.Parameters.AddWithValue("@MiddleName", E.MiddleName);
            SP_addemployees.Parameters.AddWithValue("@LastName", E.LastName);
            SP_addemployees.Parameters.AddWithValue("@Suffix", E.Suffix);

            int gender = 0;

            if (E.Sex == "Male"){
                gender = 1;
            } else if (E.Sex == "Female")
            {
                gender = 2;
            }

            SP_addemployees.Parameters.AddWithValue("@Sex", gender);
            SP_addemployees.Parameters.AddWithValue("@Department", E.Department);
            SP_addemployees.Parameters.AddWithValue("@Position", E.Position);
            SP_addemployees.Parameters.AddWithValue("@EmailAddress", E.EmailAddress);
            SP_addemployees.Parameters.AddWithValue("@Salary", E.Salary);
            SP_addemployees.ExecuteNonQuery();

        }

        public static void addItem(SqlConnection conn, Item I)
        {
            SqlCommand SP_addemployees = new SqlCommand("createItems", conn);
            SP_addemployees.CommandType = CommandType.StoredProcedure;

            SP_addemployees.Parameters.AddWithValue("@itemID", I.ItemID);
            SP_addemployees.Parameters.AddWithValue("@itemName", I.ItemName);
            SP_addemployees.Parameters.AddWithValue("@quantity", I.Quantity);
            SP_addemployees.Parameters.AddWithValue("@unitPrice", I.UnitPrice);
            SP_addemployees.Parameters.AddWithValue("@totalPrice", I.TotalPrice);
            SP_addemployees.Parameters.AddWithValue("@description", I.Description);

            SP_addemployees.ExecuteNonQuery();
        }

        public static void addTransaction(SqlConnection conn, Transaction T)
        {
            SqlCommand SP_addTransaction = new SqlCommand("createTransaction", conn);
            SP_addTransaction.CommandType = CommandType.StoredProcedure;

            SP_addTransaction.Parameters.AddWithValue("@TransactionID", T.TransactionID);
            SP_addTransaction.Parameters.AddWithValue("@fullName", T.Name);
            SP_addTransaction.Parameters.AddWithValue("@isCredit", T.TransactionC);
            SP_addTransaction.Parameters.AddWithValue("@isDebit", T.TransactionD);
            SP_addTransaction.Parameters.AddWithValue("@amount", T.Amount);
            SP_addTransaction.Parameters.AddWithValue("@Description", T.Summary);

            SP_addTransaction.ExecuteNonQuery();
        }

        public static void deleteTransaction(SqlConnection conn, int T)
        {
            SqlCommand SP_deleteTransaction = new SqlCommand("deleteTransaction", conn);
            SP_deleteTransaction.CommandType = CommandType.StoredProcedure;

            SP_deleteTransaction.Parameters.AddWithValue("@TransactionID", T);
            SP_deleteTransaction.ExecuteNonQuery();
        }

        public static void deleteTask(SqlConnection conn, int TID)
        {
            SqlCommand SP_deleteTask = new SqlCommand("deleteTask", conn);
            SP_deleteTask.CommandType = CommandType.StoredProcedure;

            SP_deleteTask.Parameters.AddWithValue("@TaskID", TID);
            SP_deleteTask.ExecuteNonQuery();
        }


        public static void addTask(SqlConnection conn, Task T)
        {
            SqlCommand SP_addTask = new SqlCommand("createItems", conn);
            SP_addTask.CommandType = CommandType.StoredProcedure;

            SP_addTask.Parameters.AddWithValue("@taskName", T.TaskName);
            SP_addTask.Parameters.AddWithValue("@dueDate", T.DueDate);
            SP_addTask.Parameters.AddWithValue("@isDone", T.IsDone);
            SP_addTask.Parameters.AddWithValue("@budget", T.Budget);
            SP_addTask.Parameters.AddWithValue("@employeesNeeded", T.EmployeesNeeded);
            SP_addTask.Parameters.AddWithValue("@description", T.Description);
            SP_addTask.Parameters.AddWithValue("@materialsNeeded", T.MaterialsNeeded);

            SP_addTask.ExecuteNonQuery();
        }


        public static void deleteItem(SqlConnection conn, int target_id)
        {
            SqlCommand SP_deleteItem = new SqlCommand("deleteItem", conn);
            SP_deleteItem.CommandType = CommandType.StoredProcedure;

            SP_deleteItem.Parameters.AddWithValue("@ItemID", target_id);
            SP_deleteItem.ExecuteNonQuery();
        }




    }
}
