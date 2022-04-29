using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace MPGuiVersion
{
    public static class EmployeeModule
    {
        public static void addHealthRecord()
        {
            MedicalRecordWindow MRW = new MedicalRecordWindow();
            MRW.Show();
        }

        public static void addEmployeeProfile()
        {
            EmployeeProfileWindow EPW = new EmployeeProfileWindow();
            EPW.Show();
        }

        public static void addEmployee(Employee ret)
        {
            SqlConnection conn;
            string message;
            bool state;
            DatabaseConnection.connectToSQL(out conn, out state, out message);
            DatabaseConnection.addEmployees(conn, ret);
            DatabaseConnection.disconnectSQL(conn, out state);
        }

        public static void manageEmails()
        {
            EmailWindow EM = new EmailWindow();
            EM.Show();
        }

        public static void generatePayslip()
        {
            Employee A = new Employee();
            double basicPay, overtimePay, grossPay;
            overtimePay = 1500;
            double sssContrib = 0.13;
            double phContrib = 0.02;
            double payslip;
            basicPay = A.Salary;
            grossPay = basicPay + overtimePay;
            payslip = grossPay * (sssContrib + phContrib);
        }

        public static void deleteEmployee(int target_id)
        {
            SqlConnection conn;
            bool status;
            string output;

            DatabaseConnection.connectToSQL(out conn, out status, out output);
            DatabaseConnection.deleteEmployee(conn, target_id);
            DatabaseConnection.disconnectSQL(conn, out status);

        }

        


    }
}