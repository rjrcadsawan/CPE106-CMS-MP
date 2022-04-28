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
    /// Interaction logic for ManageEmployees.xaml
    /// </summary>
    public partial class ManageEmployeesControl : UserControl
    {
        SqlConnection conn;
        public ManageEmployeesControl()
        {
            InitializeComponent();
            getDataFromServer();
        }

        private void getDataFromServer()
        {
            bool connected;
            string output;
            DatabaseConnection.connectToSQL(out this.conn, out connected, out output);

            DataView EmployeeData = DatabaseConnection.getEmployees(this.conn);
            EmployeeList.ItemsSource = null;
            EmployeeList.ItemsSource = EmployeeData;
        }

        private void ManageEmailsBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteEmployeeBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GeneratePayslipBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchEmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            int EID = Convert.ToInt32(EID_TextBox.Text);
            foreach (DataRowView row in EmployeeList.ItemsSource)
            {
                var str = row["employeeID"].ToString();
                MessageBox.Show(str);
                bool check = (EID == Convert.ToInt32(str));
                if (check)
                {
                    EmployeeList.SelectedItem = row;
                    break;
                }
            }
        }
    }

    
}
