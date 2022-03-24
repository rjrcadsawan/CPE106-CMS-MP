using System;
using System.Collections.Generic;
using System.Text;

namespace MPGuiVersion
{
    class Employee
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string suffix;
        private string sex;
        private string department;
        private string position;
        private string emailAddress;
        private double salary;
        private int employeeID;
        private EmployeeHealthRecord employeeHR;
        private EmployeePermissions employeePerms;
        private EmployeeProfile employeeProf;

        public string FirstName { get => firstName; set => firstName = value; }
        public string MiddleName { get => middleName; set => middleName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Suffix { get => suffix; set => suffix = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Department { get => department; set => department = value; }
        public string Position { get => position; set => position = value; }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public double Salary { get => salary; set => salary = value; }
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public EmployeeHealthRecord EmployeeHR { get => employeeHR; set => employeeHR = value; }
        public EmployeePermissions EmployeePerms { get => employeePerms; set => employeePerms = value; }
        public EmployeeProfile EmployeeProf { get => employeeProf; set => employeeProf = value; }
    }
}
