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
using System.Windows.Shapes;

using System.Data.SqlClient;


namespace MPGuiVersion
{
    /// <summary>
    /// Interaction logic for SignupForm.xaml
    /// </summary>
    public partial class SignupForm : Window
    {
        string connection_string;
        SqlConnection sql_conn;
        SqlCommand sql_comm;
        bool connected = false;
        public SignupForm()
        {
            InitializeComponent();
            InitializeConnections();
        }

        private void InitializeConnections()
        {
            // Try - Except Block, just in case SQL Connection Fails
            try
            {
                // Connection String based on Server Connector by Visual Studio
                this.connection_string = "Data Source=ASUS-ACE;Initial Catalog=CMSData;Integrated Security=True";

                // Creates new Connection Object based on connection string
                this.sql_conn = new SqlConnection(connection_string);

                // Opens the Connection
                this.sql_conn.Open();

                //MessageBox.Show("Connection with the CMSData was succesfully established");
                this.connected = true; // Used for testing purposes
            }
            catch (Exception ex)
            {
                // Connection Failed
                MessageBox.Show($"An Exception has occurred: \n{ex.Message}");
            }

        }


        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            string first_name = FNBox.Text;
            string middle_name = MNBox.Text;
            string last_name = LNBox.Text;
            string email_address = EmailBox.Text;
            string password_text = PassBox.Password;
            string confirm_password_text = ConfirmPassBox.Password;

            if (password_text != confirm_password_text)
            {
                MessageBox.Show("Password does not match!");
                return;
            }

            if (!connected)
            {
                MessageBox.Show("Cannot Connect to SQL Server");
                this.Close();
                return;
            }

            string search_comm = $"INSERT INTO [LogInDetails] VALUES ('{first_name}', '{middle_name}', '{last_name}', '{email_address}', '{password_text}')";


            this.sql_comm = new SqlCommand(search_comm, this.sql_conn);

            SqlDataReader sql_read = sql_comm.ExecuteReader();
            while (sql_read.Read())
            {
            }

            MessageBox.Show($"Congratulations {first_name} you have registered your account");
            //MessageBox.Show($"You have succesfully registered {email_address}\n{search_comm}");
            this.sql_conn.Close();
            this.Close();
        }

        private void Back_to_login(object sender, RoutedEventArgs e)
        {
            this.sql_conn.Close();
            this.Close();
        }

        private void Reset_fields(object sender, RoutedEventArgs e)
        {
            FNBox.Text = "";
            MNBox.Text = "";
            LNBox.Text = "";
            EmailBox.Text = "";
            PassBox.Password = "";
            ConfirmPassBox.Password = "";
        }
    }
}
