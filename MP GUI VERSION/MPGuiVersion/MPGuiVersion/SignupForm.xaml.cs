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

        public SignupForm()
        {
            InitializeComponent();
            InitializeConnections();
        }

        private void InitializeConnections()
        {
            try
            {
                this.connection_string = "Data Source=ASUS-ACE;Initial Catalog=CMSData;Integrated Security=True";
                this.sql_conn = new SqlConnection(connection_string);
                this.sql_conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Exception has occurred: \n{ex}");
            }

        }

        private void BackToLogin_Click(object sender, RoutedEventArgs e)
        {
            this.sql_conn.Close();
            this.Close();
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            string first_name = FNBox.Text;
            string middle_name = MNBox.Text;
            string last_name = LNBox.Text;
            string email_address = EmailBox.Text;
            string password_text = PassBox.Text;
            string search_comm = $"INSERT INTO [LogInDetails] VALUES ('{first_name}', '{middle_name}', '{last_name}', '{email_address}', '{password_text}')";


            this.sql_comm = new SqlCommand(search_comm, this.sql_conn);
            /*
            sql_comm.Parameters.AddWithValue("@first_name", first_name);
            sql_comm.Parameters.AddWithValue("@middle_nam", middle_name);
            sql_comm.Parameters.AddWithValue("@last_name", last_name);
            sql_comm.Parameters.AddWithValue("@email_address", email_address);
            sql_comm.Parameters.AddWithValue("@password_text", password_text);
            */
            
            SqlDataReader sql_read = sql_comm.ExecuteReader();
            while (sql_read.Read())
            {
            }


            MessageBox.Show($"You have succesfully registered {email_address}\n{search_comm}");
            this.sql_conn.Close();
            this.Close();
        }

        private void ResetFields_Click(object sender, RoutedEventArgs e)
        {
            FNBox.Text = "";
            MNBox.Text = "";
            LNBox.Text = "";
            EmailBox.Text = "";
            PassBox.Text = "";
        }
    }
}
