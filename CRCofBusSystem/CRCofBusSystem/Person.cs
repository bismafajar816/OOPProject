using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRCofBusSystem
{
    public class Person
    {
        protected string name;
        protected string password;
        protected string role;
        protected string contactNumber;
        protected string Address;
        public Person(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
        public Person(string name, string password, string role, string contactNumber, string Address)
        {
            SetName(name);
            SetPassword(password);
            SetRole(role);
            SetAddress(Address);
            SetContactNumber(contactNumber);

        }
        public void SetContactNumber(string contactNumber)
        {
            if (contactNumber != "")
            {
                this.contactNumber = contactNumber;
            }
        }
        public void SetAddress(string Address)
        {
            if (Address != "")
            {
                this.Address = Address;
            }
        }

        public void SetName(string name)
        {
            if (name != "")
            {
                this.name = name;
            }
        }
        public void SetPassword(string password)
        {
            if (password != "")
            {
                this.password = password;
            }
        }
        public void SetRole(string role)
        {
            if (role == "Admin" || role == "Customer" || role == "driver" || role == "Driver" || role == "Staff" || role == "staff")
            {
                this.role = role;
            }
        }

        public string GetName()
        {
            return name;
        }
        public string GetPassword()
        {
            return password;
        }
        public string GetRole()
        {
            return role;
        }
        public string GetContact()
        {
            return contactNumber;
        }
        public string GetAddress()
        {
            return Address;
        }

        public string GetCSV()
        {
            string line;
            line = GetName() + "," + GetPassword() + "," + GetRole() + "," + GetContact() + "," + GetAddress();
            return line;

        }
    }
}