﻿using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace MPGuiVersion
{
    class BookkeepingModule
    {
        public double totalCredit = 0;
        public double totalDebit = 0;
        public void addTransaction(Transaction T)
        {
            SqlConnection conn;
            string message;
            bool state;
            DatabaseConnection.connectToSQL(out conn, out state, out message);
            DatabaseConnection.addTransaction(conn, T);
            DatabaseConnection.disconnectSQL(conn, out state);
            calculateTotal();


        }

        public void deleteTransaction()
        {

        }

        public void modifyTransaction()
        {

        }

        public void calculateTotal()
        {
            var TSC = new User_Controls.TransactionSummaryControl();
            TSC.getTotalStats(out this.totalCredit, out this.totalDebit);
        }

        public void TotalValues(out double TC, out double TD)        {
            
            TC = this.totalCredit;
            TD = this.totalDebit;
        }
    }
}