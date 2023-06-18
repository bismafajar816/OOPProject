using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRCofBusSystem
{
    public class Bus
    {
        private string BusNumber;
        private string Timing;
        private string Date;
        private string route;
        public Bus(string BusNumber, string Timing, string Date, string route)
        {
            SetBusNumber(BusNumber);
            SetDate(Date);
            SetRoute(route);
            SetTiming(Timing);
        }
        public void SetBusNumber(string BusNumber)
        {
            if (BusNumber != "")
            {
                this.BusNumber = BusNumber;
            }
        }
        public void SetTiming(string Timing)
        {
            if (Timing != "")
            {
                this.Timing = Timing;
            }
        }
        public void SetDate(string Date)
        {
            if (Date != "")
            {
                this.Date = Date;
            }
        }
        public void SetRoute(string route)
        {
            if (route != "")
            {
                this.route = route;
            }
        }
        public string GetBusNumber()
        {
            return BusNumber;
        }
        public string GetDate()
        {
            return Date;
        }
        public string GetTiming()
        {
            return Timing;
        }
        public string GetRoute()
        {
            return route;
        }
        public string GetCSV()
        {
            return GetBusNumber() + " , " + GetDate() + " , " + GetRoute() + " , " + GetTiming();
        }
    }
}