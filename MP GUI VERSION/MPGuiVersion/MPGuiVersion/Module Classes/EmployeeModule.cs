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
            //clears the textbox

        }

        static void addEmployee()
        {
            Employee A = new Employee();
            A.firstName = firstName.Text;
            A.middleName = middleName.Text;
            A.lastName = lastName.Text;
            A.suffix = suffix.Text;
            A.sex = sexCombo.SelectedItem.ToString();
            A.department = department.Text;
            A.position = position.Text;
            A.emailAddress = emailAddress.Text;
            A.salary = salary.Text;
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
            //need pa i-output(?) or new window?
        }

        static void deleteEmployee()
        {
            using (SqlConnection con = new SqlConnection(Global.connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM " + table + " WHERE " + columnName + " = '" + IDNumber + "'", con))
                {
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
            //eedit pa
        }

        static void searchEmployee()
        {

        }

        static void printSheet()
        {
            IsReadOnly = "True";

        }

        static void refreshDetails()
        {
            payrollSheet.Rows.Clear();
            payrollSheet.Refresh();
        }

    }
}