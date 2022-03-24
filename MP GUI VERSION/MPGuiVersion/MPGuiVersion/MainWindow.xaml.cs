using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Data.SqlClient;

namespace MPGuiVersion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string connection_string;
        SqlConnection sql_conn;
        SqlCommand sql_comm;
        bool connected = false;

        public MainWindow()
        {
            

            InitializeComponent();
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
        
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            InitializeConnections();

            // SQL Command Setup
            string email_text = EmailBox.Text;
            string pass_text = PassBox.Password;
            string search_comm = $"SELECT * FROM LogInDetails WHERE EmailAddress = '{email_text}'";

            // Email Finding Setup
            bool email_found = false;

            //string msg = "Login Button was clicked\n";
            //msg += $"Email Entered: {EmailBox.Text}\n";
            //msg += $"Password Entered: {PassBox.Password}";
            //MessageBox.Show(msg);

            //SQL Command and data retrieval
            try
            {
                sql_comm = new SqlCommand(search_comm, this.sql_conn);
                SqlDataReader sql_read = sql_comm.ExecuteReader();
                
                // Would only execute upon reading
                while (sql_read.Read())
                {
                    email_found = true;
                    if (sql_read["PasswordText"].ToString() == pass_text)
                    {

                        //MessageBox.Show($"Entered Correct password, proceeding to main menu\n{sql_read["PasswordText"].ToString()} == {pass_text}");
                        this.showMainMenu();
                        break; // Stops loop

                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password");
                    }

                }
                
                if (!email_found) {
                    MessageBox.Show("Email Not Found");
                }
           


            } catch (Exception ex)
            {
                if (!connected)
                {
                    MessageBox.Show($"No connection to SQL Server, for previewing purposes only");
                    this.showMainMenu();

                } else
                {
                    MessageBox.Show($"An Exception has occured: {ex.Message}");
                }
            }
        }

        private void Signup_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Signup Button was clicked");
            SignupForm SF = new SignupForm();
            SF.Show();
        }

        private void showMainMenu()
        {
            this.Hide(); // Hide This login window
            this.sql_conn.Close(); // Closes SQL Connection
            // MainMenu MM = new MainMenu(); // Old Main Menu
            MainMenuv2 MM = new MainMenuv2();
            MM.Show(); // Shows Main Menu
            this.Close(); // Closes Upon Close of Main Menu
        }

    }
}
