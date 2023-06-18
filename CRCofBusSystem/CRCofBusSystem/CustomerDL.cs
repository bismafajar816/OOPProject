using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace CRCofBusSystem
{
    public class CustomerDL
    {
        public static List<Customer> customersList = new List<Customer>();
        public static void AddCustomerToList(Customer customer)
        {
            customersList.Add(customer);
        }
        public static Customer GetSeatsOfCustomerByName(string name)
        {
            foreach (var x in customersList)
            {
                if (x.GetName() == name)
                {
                    return x;
                }

            }
            return null;
        }
        public static List<Customer> GetCustomersList()
        {
            return customersList;
        }
        public static Customer GetCustomerByName(string name)
        {
            foreach (var x in customersList)
            {
                if (x.GetName() == name)
                {
                    return x;
                }
            }
            return null;
        }
        public static bool CheckIfSeatIsReserved(int seat)
        {
            for (int x = 0; x < customersList.Count(); x++)
            {
                if (customersList[x].GetList()[x] == seat)
                {
                    return true;
                }
            }
            return false;
        }
        public static void ReplaceCustomer(Customer customer)
        {
            for (int x = 0; x < customersList.Count(); x++)
            {
                if (customersList[x].GetName() == customer.GetName())
                {
                    customersList[x] = customer;
                }
            }
        }
        public static void StoreData(string path, Customer customer)
        {
            StreamWriter file = new StreamWriter(path, true);
            string seats = "";
            for (int x = 0; x < customer.GetList().Count - 1; x++)
            {
                seats = seats + customer.GetList()[x] + ";";
            }
            seats = seats + customer.GetList()[customer.GetList().Count - 1];

            file.WriteLine(customer.GetName() + "," + customer.GetPassword() + "," + customer.GetRole() + "," + customer.GetContact() + "," + customer.GetAddress() + "," + customer.GetBus().GetBusNumber() + "," + customer.GetCharges() + "," + seats);

            file.Flush();
            file.Close();
        }
        public static void LoadData(string path)
        {

            if (File.Exists(path))
            {
                StreamReader f = new StreamReader(path);
                string record;
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');

                    string Name = splittedRecord[0];
                    string password = splittedRecord[1];
                    string role = splittedRecord[2];
                    string contact = splittedRecord[3];
                    string address = splittedRecord[4];
                    string serial = splittedRecord[5];
                    double charges = double.Parse(splittedRecord[6]);
                    string[] splittedRecordForSeats = splittedRecord[7].Split(';');

                    List<int> seats = new List<int>();
                    for (int x = 0; x < splittedRecordForSeats.Length; x++)
                    {
                        int seat = int.Parse(splittedRecordForSeats[x]);
                        seats.Add(seat);
                    }

                    Bus bus = BusDL.SearchBusBySerial(serial);
                    if (bus != null)
                    {
                        Customer customer = new Customer(Name, password, role, contact, address, seats, bus);
                        AddCustomerToList(customer);
                    }
                }
                f.Close();

            }

        }
        public static double GetTotalPrice()
        {
            double charges;
            foreach (var x in customersList)
            {
                charges = x.GetCharges();
                return charges;
            }
            return 0;

        }
    }
}