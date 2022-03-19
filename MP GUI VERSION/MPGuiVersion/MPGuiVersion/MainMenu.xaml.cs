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

namespace MPGuiVersion
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Open_Email_Manager(object sender, RoutedEventArgs e)
        {
            EmailWindow EM = new EmailWindow();
            EM.Show();
        }

        private void Add_Employee_Profile (object sender, RoutedEventArgs e)
        {
            EmployeeProfileWindow EPW = new EmployeeProfileWindow();
            EPW.Show();
             
        }

        private void Add_Health_Record(object sender, RoutedEventArgs e)
        {
            MedicalRecordWindow MRW = new MedicalRecordWindow();
            MRW.Show();
        }
    }
}
