using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusSystem.BL;
using BusSystem.DL;
using System.IO;
namespace BusSystem.DL
{
    class BusDL
    {
      public static  List<Bus> busesList = new List<Bus>();
        public static void AddBusToList(Bus bus)
        {
            busesList.Add(bus);
        }
        public static Bus SearchBusBySerial(string serial)
        {
            foreach (var x in busesList)
            {
                if (x.GetBusNumber() == serial)
                {
                    return x;
                }
            }
            return null;
        }
        public static Bus SearchBusByRoute(string route)
        {
            foreach(var x in busesList)
            {
                if(x.GetRoute() == route)
                {
                    return x;
                }
            }
            return null;
        }
        public static Bus SearchBusByDate(string date)
        {
            foreach (var x in busesList)
            {
                if (x.GetDate() == date)
                {
                    return x;
                }
            }
            return null;
        }
        public static void RemoveBus(string BusNumber)
        {
           for(int x = 0; x< busesList.Count() ; x++)
            {
                if(busesList[x].GetBusNumber() == BusNumber)
                {
                    busesList.RemoveAt(x);
                }
            }
        }
        public static void UpdateBus(string busNumber, string route, string UpdatedRoute)
        {
            foreach(var x in busesList)
            {
                if(x.GetBusNumber() == busNumber && x.GetRoute() == route)
                {
                    x.SetRoute(UpdatedRoute);
                }
            }
        }
        public static void StoreData(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (var x in busesList)
            {
                file.WriteLine(x.GetBusNumber() + "," + x.GetTiming() + "," + x.GetDate() + "," + x.GetRoute() );
            }
            file.Flush();
            file.Close();
        }
        public static void LoadData(string path)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line;
                while ((line = file.ReadLine()) != null)
                {

                    string serial = dataParse(line, 1);
                    string timing = dataParse(line, 2);
                    string date = dataParse(line, 3);
                    string route = dataParse(line, 4);
                    Bus bus = new Bus(serial, timing, date, route);
                    AddBusToList(bus);
                    
                }
                file.Close();
            }
            else
            {
                Console.WriteLine("File does not exists");
            }
        }
        public static string dataParse(string line, int field)
        {
            string item = "";
            int commacount = 1;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == ',')
                {
                    commacount++;
                }
                else if (commacount == field)
                {
                    item = item + line[i];
                }
            }
            return item;
        }
        public static double GetPetrolPrice()
        {
          return  busesList.Count() * 5000.0;
        }

    }
}
