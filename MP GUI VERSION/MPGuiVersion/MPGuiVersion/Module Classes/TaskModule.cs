using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MPGuiVersion
{
    public static class TaskModule
    {
        public static void addTask(Task T)
        {
            SqlConnection conn;
            string message;
            bool state;
            DatabaseConnection.connectToSQL(out conn, out state, out message);
            DatabaseConnection.addTask(conn, T);
            DatabaseConnection.disconnectSQL(conn, out state);
        }

        public static void deleteTask(int target_id)
        {
            SqlConnection conn;
            bool status;
            string output;

            DatabaseConnection.connectToSQL(out conn, out status, out output);
            DatabaseConnection.deleteTask(conn, target_id);
            DatabaseConnection.disconnectSQL(conn, out status);
        }
        public static void modifyItem()
        {

        }

        public static void updateTask()
        {

        }

        public static void assignTask()
        {

        }



    }
}
