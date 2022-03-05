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

namespace MPGuiVersion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string msg = "Login Button was clicked\n";
            msg += $"Email Entered: {EmailBox.Text}\n";
            MessageBox.Show(msg);
            Hide();
            MainMenu MM = new MainMenu();
            MM.Show();



        }

        private void Signup_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Signup Button was clicked");
        }
    }
}
