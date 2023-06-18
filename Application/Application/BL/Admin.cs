using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BL
{
    class Admin 
    {
        protected string name;
        protected string contact;
        protected string address;
        
        public Admin(string name, string contact, string address) 
        {
            this.name = name;
            this.contact = contact;
            this.address = address;
        }
        public virtual double CalculatePay()
        {
          
            return 20000;
        }

    }
}
