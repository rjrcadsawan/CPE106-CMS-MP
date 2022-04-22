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
    /// Interaction logic for MainMenuv2.xaml
    /// </summary>
    public partial class MainMenuv2 : Window
    {
        public MainMenuv2()
        {
            InitializeComponent();
        }

        private void EmployeeModuleBtn_Click(object sender, RoutedEventArgs e)
        {
            Reset_Button_Pannel();
            EmployeeModuleBtn.Height = 100;
            AddEmployees.Visibility = Visibility.Visible;
            ManageEmployees.Visibility = Visibility.Visible;
            PayrollSheet.Visibility = Visibility.Visible;
        }

        private void BookkeepingModuleBtn_Click(object sender, RoutedEventArgs e)
        {
            Reset_Button_Pannel();
            BookkeepingModuleBtn.Height = 100;
            AddTransaction.Visibility = Visibility.Visible;
            TransactionSummary.Visibility = Visibility.Visible;
        }

        private void InventoryModuleBtn_Click(object sender, RoutedEventArgs e)
        {
            Reset_Button_Pannel();
            InventoryModuleBtn.Height = 100;
            AddItems.Visibility = Visibility.Visible;
            ManageItems.Visibility = Visibility.Visible;
            ItemSummary.Visibility = Visibility.Visible;
        }

        private void TaskModuleBtn_Click(object sender, RoutedEventArgs e)
        {
            Reset_Button_Pannel();
            TaskModuleBtn.Height = 100;
            AddTask.Visibility = Visibility.Visible;
            ManageTask.Visibility = Visibility.Visible;
            TaskSummary.Visibility = Visibility.Visible;
        }

        private void Reset_Button_Pannel()
        {
            int ButtonDefaultHeight = 60;

            // Employee Module
            AddEmployees.Visibility = Visibility.Collapsed;
            ManageEmployees.Visibility = Visibility.Collapsed;
            PayrollSheet.Visibility = Visibility.Collapsed;

            // Bookkeeping Module
            AddTransaction.Visibility = Visibility.Collapsed;
            TransactionSummary.Visibility = Visibility.Collapsed;

            // Inventory Module
            AddItems.Visibility = Visibility.Collapsed;
            ManageItems.Visibility = Visibility.Collapsed;
            ItemSummary.Visibility = Visibility.Collapsed;

            // Task Module
            AddTask.Visibility = Visibility.Collapsed;
            ManageTask.Visibility = Visibility.Collapsed;
            TaskSummary.Visibility = Visibility.Collapsed;

            EmployeeModuleBtn.Height = ButtonDefaultHeight;
            BookkeepingModuleBtn.Height = ButtonDefaultHeight;
            InventoryModuleBtn.Height = ButtonDefaultHeight;
            TaskModuleBtn.Height = ButtonDefaultHeight;

        }

        private void SettingsBtn_Click(object sender, RoutedEventArgs e)
        {
            Reset_Button_Pannel();
        }

        private void PermissionsBtn_Click(object sender, RoutedEventArgs e)
        {
            Reset_Button_Pannel();
        }

        private void AddItems_Click(object sender, RoutedEventArgs e)
        {
            var AIC = new User_Controls.AddItemsControl();
            CMSModules.Content = AIC;
        }

        private void ManageItems_Click(object sender, RoutedEventArgs e)
        {
            var MIC = new User_Controls.ManageItemsControl();
            CMSModules.Content = MIC;

        }


    }
}
