using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Data;
using System.Data.SqlClient;


namespace MPGuiVersion.User_Controls
{
    /// <summary>
    /// Interaction logic for TransactionSummaryControl.xaml
    /// </summary>
    public partial class TransactionSummaryControl : UserControl
    {
        SqlConnection conn;
        public TransactionSummaryControl()
        {
            InitializeComponent();
            getDataFromServer();
        }

        private void getDataFromServer()
        {
            bool status;
            string output;

            DatabaseConnection.connectToSQL(out this.conn, out status, out output);

            DataView TransactionData = DatabaseConnection.getDatas(this.conn, "Transactions");
            TransactionList.ItemsSource = null;
            TransactionList.ItemsSource = TransactionData;

            DatabaseConnection.disconnectSQL(this.conn, out status);
        }

    }
}
