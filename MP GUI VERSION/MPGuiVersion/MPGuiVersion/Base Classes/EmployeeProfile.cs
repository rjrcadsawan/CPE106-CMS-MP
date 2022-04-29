using System;
using System.Collections.Generic;
using System.Text;

namespace MPGuiVersion
{
    public class EmployeeProfile
    {
        private Name employeeName = new Name();
        private Address address = new Address();
        private int mobileNum;
        private int landline;
        private int fatherNum;
        private int motherNum;
        private string emailAddress;

        private BioInfo biographicInfo = new BioInfo();

        private EmergencyContact[] contacts = new EmergencyContact[3];

        public string[] FullName
        {
            get
            {
                string[] result = { employeeName.firstName, employeeName.middleName, employeeName.lastName };
                return result;
            }
            set
            {
                employeeName.firstName = value[0];
                employeeName.middleName = value[1];
                employeeName.lastName = value[2];
            }
        }
        public string[] Address
        {
            get
            {
                string[] result = { address.BuildingNumber, address.City, address.ZIP };
                return result;
            }
            set
            {
                address.BuildingNumber = value[0];
                address.City = value[1];
                address.ZIP = value[2];
            }
        }
        public string[] BiographicalInformation
        {
            get
            {
                string[] result = { biographicInfo.sex, biographicInfo.maritalStatus, biographicInfo.Nationality };
                return result;
            }
            set
            {
                biographicInfo.sex = value[0];
                biographicInfo.maritalStatus = value[1];
                biographicInfo.Nationality = value[2];
            }
        }
        public string[,] ContactforEmergency
        {
            get
            {
                string[,] result = new string[3,3];

                for (int i = 0; i < 3; i++)
                {
                    result[i, 0] = contacts[i].firstName;
                    result[i, 1] = contacts[i].middleName;
                    result[i, 2] = contacts[i].lastName;
                }
                return result;
            }
        }
        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }
        public int MobileNum
        {
            get { return mobileNum; }
            set { mobileNum = value; }
        }
        public int Landline
        {
            get { return landline; }
            set { landline = value; }
        }
        public int MotherNum
        {
            get { return motherNum; }
            set { motherNum = value; }
        }
        public int FatherNum
        {
            get { return fatherNum; }
            set { fatherNum = value; }
        }
     
    }

    struct EmergencyContact
    {
        public string firstName;
        public string middleName;
        public string lastName;
    }
    struct BioInfo
    {
        public string sex;
        public string maritalStatus;
        public string Nationality;
    }

    struct Name
    {
        public string firstName;
        public string middleName;
        public string lastName;
    }
    struct Address
    {
        public string BuildingNumber;
        public string City;
        public string ZIP;
    }
}
