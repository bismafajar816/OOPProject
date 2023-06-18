using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BL
{
    class Driver:Admin
    {
        private string ID;
        private string licenseNumber;
        public Driver(string name, string contact, string address, string ID, string licenseNumber):base(name,contact,address)
        {
            this.ID = ID;
            this.licenseNumber = licenseNumber;
        }



    }
}
