using System;
using System.Collections.Generic;
using System.Text;

namespace MPGuiVersion
{
    static class EmployeeModule
    {
        static void addHealthRecord()
        {
            MedicalRecordWindow MRW = new MedicalRecordWindow();
            MRW.Show();
        }

        static void addEmployeeProfile()
        {
            EmployeeProfileWindow EPW = new EmployeeProfileWindow();
            EPW.Show();
        }

        static void resetFields()
        {
            firstName.Text = "";
            middleName.Text = "";
            lastName.Text = "";
            suffix.Text = "";
            sexCombo.Items.Clear();
            department.Text = "";
            position.Text = "";
            emailAddress.Text = "";
            salary.Text = "";
        }

        static void addEmployee()
        {
            Employee A = new Employee;
            A.firstName = firstName.Text;
            A. = middleName.Text;
            A. = lastName.Text;
            A. = suffix.Text;
            A. = sexCombo.SelectedItem.ToString();
            A. = department.Text;
            A. = position.Text;
            A. = emailAddress.Text;
            A. = salary.Text;
        }

        static void manageEmails()
        {
            EmailWindow EM = new EmailWindow();
            EM.Show();
        }

        static void generatePayslip()
        {
            Employee A = new Employee;
            double basicPay, overtimePay, grossPay;
            overtimePay = 1500;
            double sssContrib = 0.13;
            double phContrib = 0.02;
            double payslip;
            basicPay = A.Salary;
            grossPay = basicPay + overtimePay;
            payslip = grossPay * (sssContrib + phContrib);
        }

        static void deleteEmployee()
        {

        }

        static void searchEmployee()
        {

        }

        static void printSheet()
        {

        }

        static void refreshDetails()
        {

        }
    }
