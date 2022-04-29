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
    /// Interaction logic for PermissionsControl.xaml
    /// </summary>
    public partial class PermissionsControl : UserControl
    {
        SqlConnection conn;
        public PermissionsControl()
        {
            InitializeComponent();
        }

        private void getDataFromServer()
        {
            bool status;
            string output;

            DatabaseConnection.connectToSQL(out this.conn, out status, out output);

            DataView PermissionsData = DatabaseConnection.getPermissions(this.conn);
            PermissionList.ItemsSource = null;
            PermissionList.ItemsSource = PermissionsData;

            DatabaseConnection.disconnectSQL(this.conn, out status);
        }

    }
}
