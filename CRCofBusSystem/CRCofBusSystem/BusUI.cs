using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRCofBusSystem
{
    public class BusUI
    {
        public static Bus GetInputForBus()
        {
            Console.WriteLine("Enter bus serial number");
            string serial = Console.ReadLine();
            Console.WriteLine("Enter Bus timing");
            string time = Console.ReadLine();
            Console.WriteLine("Enter route");
            string route = Console.ReadLine();
            Console.WriteLine("Enter date");
            string date = Console.ReadLine();
            Bus bus = new Bus(serial, time, date, route);
            return bus;
        }
        public static string TakeSerialNumber()
        {
            Console.WriteLine("Enter bus serial number");
            string serial = Console.ReadLine();
            return serial;
        }
        public static string TakeUpdatedRoute()
        {
            Console.WriteLine("Enter updated route  ");
            string serial = Console.ReadLine();
            return serial;
        }
        public static string TakeRoute()
        {
            Console.WriteLine("Enter  route  ");
            string serial = Console.ReadLine();
            return serial;
        }
        public static string TakeDate()
        {
            Console.WriteLine("Enter date  ");
            string serial = Console.ReadLine();
            return serial;
        }
        public static void ViewBus(Bus x)
        {
            Console.WriteLine("Serial \t\t Time \t\t Route \t\t Date");

            Console.WriteLine(x.GetBusNumber() + "\t\t" + x.GetTiming() + "\t\t" + x.GetRoute() + "\t\t" + x.GetDate());


        }
        public static void ViewBus(List<Bus> buses)
        {
            Console.WriteLine("Serial \t\t Time \t\t Route \t\t Date");
            foreach (var x in buses)
            {
                Console.WriteLine(x.GetBusNumber() + "\t\t" + x.GetTiming() + "\t\t" + x.GetRoute() + "\t\t" + x.GetDate());
            }

        }
        public static Bus SearchBusByRoute(string route, List<Bus> buses)
        {
            foreach (var x in buses)
            {
                if (x.GetRoute() == route)
                {
                    return x;
                }
            }
            return null;
        }
        public static bool SearchBusBySerial(string route, List<Bus> buses)
        {
            foreach (var x in buses)
            {
                if (x.GetBusNumber() == route)
                {
                    return true;
                }
            }
            return false;
        }

        public static Bus SelectBus(List<Bus> buses)
        {

            Console.WriteLine("Enter bus serial; ");
            string serial = Console.ReadLine();
            if (SearchBusBySerial(serial, buses))
            {
                Console.WriteLine("Enter bus route ");
                string route = Console.ReadLine();
                Bus bus = SearchBusByRoute(route, buses);
                return bus;
            }
            else
            {
                Console.WriteLine("invalid bus");
                return null;
            }
        }
        public static void NotAvial()
        {
            Console.WriteLine("Bus not available");
        }

    }
}