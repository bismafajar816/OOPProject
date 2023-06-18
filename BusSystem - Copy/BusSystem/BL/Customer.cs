using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusSystem.BL
{
    class Customer:Person
    {
        private  List<int> SeatNumbers = new List<int>();
        private Bus reservedBus;
        private double charges;
        public Customer(string name, string password, string role, string contactNumber, string Address, List<int> SeatNumbers, Bus reservedBus) : base(name, password, role, contactNumber, Address)
        {
            this.SeatNumbers = SeatNumbers;
            this.reservedBus = reservedBus;
        }
        public void AddSeatToList(int seat)
        {
            SeatNumbers.Add(seat);
        }
        public List<int> GetList()
        {
            List<int> temp = new List<int>();
            temp = SeatNumbers;
            return temp;
        }
        public double GetCharges(string paymentType)
        {
            if (paymentType == "cash" || paymentType == "Cash")
            {
                charges = SeatNumbers.Count() * 1500.0;
                return charges;
            }
            else if(paymentType == "card" || paymentType == "Card")
            {
                charges = SeatNumbers.Count() * 1425.0;
                return charges ;
            }
            return 0;
        }
        public double GetCharges()
        {
            return charges;
        }
        public bool UpdateSeatNumber(int unChanged , int changed)
        {
           for(int x = 0; x < SeatNumbers.Count(); x++ )
            {
                if( SeatNumbers[x] == unChanged)
                {
                    SeatNumbers[x] = changed;
                    return true;
                }
            }
            return false;
        }
        public bool CheckIfReserved(List<int> seatNumber)
        {
            for (int x = 0; x < SeatNumbers.Count(); x++)
            {
                for (int y = 0; y < seatNumber.Count(); x++)
                {
                    if (SeatNumbers[x] == seatNumber[y])
                    {
                        return false;
                    }
                }
            }
           
            return true;
        }
        public bool CancelSeat(int seatNumber)
        {
            for (int x = 0; x < SeatNumbers.Count(); x++)
            {
                if (SeatNumbers[x] == seatNumber)
                {
                    SeatNumbers.RemoveAt(x);
                    return true;
                }
            }
            return false;
        }
        public double GetRefund(bool flag)
        {
            if(flag == true)
            {
                charges = charges - 750;
                return 750;
            }
            return 0;
        }
        public Bus GetBus()
        {
            return reservedBus;
        }

    }
}
