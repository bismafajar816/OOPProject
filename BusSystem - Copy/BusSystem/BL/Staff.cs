using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusSystem.BL;
using BusSystem.DL;
namespace BusSystem.BL
{
    class Staff : Person
    {
      
        private string rank;
        private string dutyTime;
        private string ID;
      
        public Staff(string name, string password, string role, string contactNumber, string Address,string ID, string rank, string dutyTime):base(name,password,role,contactNumber,Address)
        {
            this.rank = rank;
            this.dutyTime = dutyTime;
            this.ID = ID;
        }
        public string GetRank()
        {
            return rank;
        }
        public string GetDutyTime()
        {
            return dutyTime;
        }
        public string GetID()
        {
            return ID;
        }
        public void SetRank(string rank)
        {
            if(rank != "")
            {
                this.rank = rank;
            }

        }
        public virtual double GetPay()
        {
            return 35000;
        }
        public void SetDutyTime(string dutyTime)
        {
            if (dutyTime == "night" || dutyTime == "day")
            {
                this.dutyTime = dutyTime;
            }
        }
        public void SetID(string ID)
        {
            if (ID != "")
            {
                this.ID = ID;
            }
        }

       new public virtual string GetCSV()
        {
            string line = GetName() + "," + GetPassword() + "," + GetRole() + "," + GetContact() + "," + GetAddress() + " , " + GetID() + " , " + GetRank() + " , " + GetDutyTime();
            return line;
        }

    }
}
