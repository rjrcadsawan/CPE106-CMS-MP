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

        private void ButtonsTextMode()
        {
            SettingsBtn.Width = 180;
            PermissionsBtn.Width = 180;
            InventoryModuleBtn.Width = 180;
            EmployeeModuleBtn.Width = 180;
            BookkeepingModuleBtn.Width = 180;
            TaskModuleBtn.Width = 180;
        }

        private void ButtonsIconMode()
        {
            SettingsBtn.Width = 50;
            PermissionsBtn.Width = 50;
            InventoryModuleBtn.Width = 50;
            EmployeeModuleBtn.Width = 50;
            BookkeepingModuleBtn.Width = 50;
            TaskModuleBtn.Width = 50;
        }

        private void MITextMode(GroupBox ModuleContainer, GroupBox IconContainer)
        {
            Thickness IconAreaTextMode = new Thickness();
            Thickness ModuleAreaTextMode = new Thickness();

            IconAreaTextMode.Right = 800;
            IconAreaTextMode.Left = IconAreaTextMode.Top = IconAreaTextMode.Bottom = 0;

            ModuleAreaTextMode.Left = 200;
            ModuleAreaTextMode.Right = ModuleAreaTextMode.Top = ModuleAreaTextMode.Bottom = 0;

            ModuleContainer.Margin = ModuleAreaTextMode;
            IconContainer.Margin = IconAreaTextMode;

        }
        private void MIIconMode(GroupBox ModuleContainer, GroupBox IconContainer)
        {
            Thickness IconAreaIconMode = new Thickness();
            Thickness ModuleAreaIconMode = new Thickness();

            IconAreaIconMode.Right = 950;
            IconAreaIconMode.Left = IconAreaIconMode.Top = IconAreaIconMode.Bottom = 0;

            ModuleAreaIconMode.Left = 50;
            ModuleAreaIconMode.Right = ModuleAreaIconMode.Top = ModuleAreaIconMode.Bottom = 0;

            ModuleContainer.Margin = ModuleAreaIconMode;
            IconContainer.Margin = IconAreaIconMode;
        }



        private void GroupBox_PreviewMouseDown(object sender, RoutedEventArgs e)
        {

            if (SettingsBtn.Width == 180)
            {
                MessageBox.Show("Test Reached Here");
                ButtonsIconMode();
                MIIconMode(CMSModules, CMSIcons);
            } else
            {
                ButtonsTextMode();
                MITextMode(CMSModules, CMSIcons);
            }

            
        }
    }
}
