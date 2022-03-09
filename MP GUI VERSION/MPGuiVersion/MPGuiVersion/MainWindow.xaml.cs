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
        

        public MainWindow()
        {
            

            InitializeComponent();
        }

        private void InitializeConnections()
        {

            try
            {
                this.connection_string = "Data Source=ASUS-ACE;Initial Catalog=CMSData;Integrated Security=True";
                this.sql_conn = new SqlConnection(connection_string);
                this.sql_conn.Open();
                MessageBox.Show("Connection with the CMSData was succesfully established");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Exception has occurred: \n{ex}");
            }
            
        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            InitializeConnections();
            string msg = "Login Button was clicked\n";
            string email_text = EmailBox.Text;
            string pass_text = PassBox.Password;
            //string search_comm = "SELECT * FROM LogInDetails WHERE EmailAddress = '@email'";
            string search_comm = $"SELECT * FROM LogInDetails WHERE EmailAddress = '{email_text}'";

            msg += $"Email Entered: {EmailBox.Text}\n";
            msg += $"Password Entered: {PassBox.Password}";
            MessageBox.Show(msg);

            //SQL Command and data retrieval


            try
            {
                sql_comm = new SqlCommand(search_comm, this.sql_conn);
                //sql_comm.Parameters.AddWithValue("@email", email_text);
                SqlDataReader sql_read = sql_comm.ExecuteReader();
                bool email_found = false;


                while (sql_read.Read())
                {

                    email_found = true;
                    if (sql_read["PasswordText"].ToString() == pass_text)
                    {

                        MessageBox.Show($"Entered Correct password, proceeding to main menu\n{sql_read["PasswordText"].ToString()} == {pass_text}");
                        Hide();
                        
                        this.sql_conn.Close();
                        MainMenu MM = new MainMenu();
                        // Blocking Main Loop of MM
                        
                        MM.Show();
                        Close();
                        break;
                        
                        
                        // Exits the program (since window was just hidden, this one closes it)
                        


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
                MessageBox.Show($"Exception: {ex}");
            }
           
            

            



        }

        private void Signup_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Signup Button was clicked");
            SignupForm SF = new SignupForm();
            SF.Show();
        }
    }
}
