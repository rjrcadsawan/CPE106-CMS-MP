using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace MPGuiVersion
{
    public static class InventoryModule
    {

        public static void addItem(Item ret)
        {
            SqlConnection conn;
            string message;
            bool state;
            DatabaseConnection.connectToSQL(out conn, out state, out message);
            DatabaseConnection.addItem(conn, ret);
            DatabaseConnection.disconnectSQL(conn, out state);

        }
        public static void deleteItem()
        {
            

        }
        public static void modifyItem()
        {
           

        }
    }
}
