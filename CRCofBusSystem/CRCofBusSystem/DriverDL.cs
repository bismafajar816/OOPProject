using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRCofBusSystem
{
    public class DriverDL
    {
        public static List<Driver> driversList = new List<Driver>();
        public static void LoadDriversData(string path)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line;
                while ((line = file.ReadLine()) != null)
                {

                    string name = dataParse(line, 1);
                    string password = dataParse(line, 2);
                    string Role = dataParse(line, 3);
                    string contact = dataParse(line, 4);
                    string address = dataParse(line, 5);
                    string ID = dataParse(line, 6);
                    string Rank = dataParse(line, 7);
                    string DutyTime = dataParse(line, 8);
                    string License = dataParse(line, 9);
                    Driver person = new Driver(name, password, Role, contact, address, ID, Rank, DutyTime, License);
                    DriverDL.AddToList(person);
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
        public static void StoreData(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (var x in driversList)
            {
                file.WriteLine(x.GetName() + "," + x.GetPassword() + "," + x.GetRole() + "," + x.GetContact() + "," + x.GetAddress() + "," + x.GetID() + "," + x.GetRank() + "," + x.GetDutyTime() + "," + x.GetLicenseNumber());
            }
            file.Flush();
            file.Close();
        }
        public static void AddToList(Driver p)
        {
            if (p.GetName() != "" && p.GetPassword() != "" && p.GetRole() != "")
            {
                driversList.Add(p);
            }

        }
        public static Driver SearchEmployee(string name)
        {
            foreach (var x in driversList)
            {
                if (x.GetName() == name)
                {
                    return x;
                }
            }
            return null;
        }
        public static void RemoveEmployee(string name, string rank)
        {

            for (int x = 0; x < driversList.Count(); x++)
            {
                if (driversList[x].GetName() == name && driversList[x].GetRank() == rank)
                {
                    driversList.RemoveAt(x);
                }
            }
        }
        public static void UpdateEmployee(string name, string updatedName, string rank, string ID)
        {
            for (int x = 0; x < driversList.Count; x++)
            {
                if (driversList[x].GetName() == name && driversList[x].GetRank() == rank && driversList[x].GetID() == ID)
                {
                    driversList[x].SetName(updatedName);
                }
            }
        }
        public static List<Driver> GetDriversList()
        {
            return driversList;
        }
        public static double GetTotalIncome()
        {
            double charges = 0;
            foreach (var x in driversList)
            {
                charges = x.GetPay();
            }
            foreach (var x in StaffDL.EmployeesList)
            {
                charges = x.GetPay();
            }
            return charges;
        }
    }
}