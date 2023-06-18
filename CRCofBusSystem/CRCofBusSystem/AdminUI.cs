using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRCofBusSystem
{
    public class AdminUI
    {
        public static string AddEmployeeType()
        {
            Console.WriteLine("Enter the type of employee you want ( driver or staff)");
            string name = Console.ReadLine();
            return name;
        }
        public static bool CheckIfDriverFunction(string name)
        {
            if (name == "driver" || name == "Driver")
            {
                return true;
            }
            return false;
        }
        public static Driver TakeInputForDriver()
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Enter role: ");
            string role = Console.ReadLine();
            Console.WriteLine("Enter contact number: ");
            string contact = Console.ReadLine();
            Console.WriteLine("Enter address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter ID: ");
            string ID = Console.ReadLine();
            Console.WriteLine("Enter rank");
            string rank = Console.ReadLine();
            Console.WriteLine("Enter duty time");
            string time = Console.ReadLine();
            Console.WriteLine("Enter License number: ");
            string number = Console.ReadLine();
            Driver driver = new Driver(name, password, role, contact, address, ID, rank, time, number);
            return driver;
        }
        public static Staff TakeInputForStaff()
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Enter role: ");
            string role = Console.ReadLine();
            Console.WriteLine("Enter contact number: ");
            string contact = Console.ReadLine();
            Console.WriteLine("Enter address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter ID: ");
            string ID = Console.ReadLine();
            Console.WriteLine("Enter rank");
            string rank = Console.ReadLine();
            Console.WriteLine("Enter duty time");
            string time = Console.ReadLine();
            Staff staff = new Staff(name, password, role, contact, address, ID, rank, time);
            return staff;
        }
        public static void ViewStaff(List<Staff> staffs)
        {
            foreach (var x in staffs)
            {
                if (x is Driver)
                {
                    Console.WriteLine(x.GetCSV());
                }
            }
        }
        public static int Menu()
        {
            Console.WriteLine("You are allowed to perform the following tasks");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("1. Add Employee ");
            Console.WriteLine("2. Remove Employee");
            Console.WriteLine("3. Update Employee name");
            Console.WriteLine("4. Search Employee ");
            Console.WriteLine("5. View all Employees ");
            Console.WriteLine("6. Add Bus ");
            Console.WriteLine("7. Remove Bus");
            Console.WriteLine("8. Update Bus ");
            Console.WriteLine("9. Search Bus by route ");
            Console.WriteLine("10. Search Bus by date ");
            Console.WriteLine("11. View all buses ");
            Console.WriteLine("12. View Income.");
            Console.WriteLine("0. Exit");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Your choice");
            int option = int.Parse(Console.ReadLine());
            return option;
        }

        public static string TakeInputAsName()
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            return name;
        }
        public static string TakeInputAsUpdatedName()
        {
            Console.WriteLine("Enter updated name: ");
            string name = Console.ReadLine();
            return name;
        }
        public static void DisplayDriver(List<Driver> driversList)
        {
            Console.WriteLine("Name \t\t ID \t\t Rank \t\t Duty Time \t\tLicense Number");
            foreach (var x in driversList)
            {
                Console.WriteLine(x.GetName() + " \t\t" + x.GetID() + " \t\t" + x.GetRank() + " \t\t" + x.GetDutyTime() + "   \t\t " + x.GetLicenseNumber());
            }
        }
        public static void DisplayDriver(Driver x)
        {
            Console.WriteLine("Name \t\t ID \t\t Rank \t\t Duty Time \t\t License Number");
            Console.WriteLine(x.GetName() + "\t\t  " + x.GetID() + " \t\t " + x.GetRank() + " \t\t " + x.GetDutyTime() + " \t\t " + x.GetLicenseNumber());

        }
        public static void DisplayStaff(Staff x)
        {
            Console.WriteLine("Name \t\t ID \t\t Rank \t\t Duty Time ");
            Console.WriteLine(x.GetName() + "\t\t  " + x.GetID() + " \t\t " + x.GetRank() + " \t\t " + x.GetDutyTime());

        }
        public static void DisplayStaff(List<Staff> staffList)
        {
            Console.WriteLine("Name \t\t ID \t\t Rank \t\t Duty Time");
            foreach (var x in staffList)
            {
                Console.WriteLine(x.GetName() + " \t\t" + x.GetID() + " \t\t" + x.GetRank() + " \t\t" + x.GetDutyTime());
            }
        }
        public static void DisplayIncome(double income)
        {
            Console.WriteLine("Your income after subtracting staff pay and bus charges is " + income);
        }
    }
}