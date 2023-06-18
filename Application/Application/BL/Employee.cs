using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BL
{
    class Employee: Admin
    {
        private string rank;
        private string dutyTime;
        public Employee(string name, string contact, string address, string rank, string dutyTime):base(name, contact, address)
        {
            this.rank = rank;
            this.dutyTime = dutyTime;
        }

    }
}
