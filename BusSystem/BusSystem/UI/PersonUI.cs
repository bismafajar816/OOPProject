using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusSystem.BL;
using BusSystem.DL;
namespace BusSystem.UI
{
    class PersonUI
    {
        public static Person GetInputForSignUp()
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Enter role  (Admin or Customer) : ");
            string role = Console.ReadLine();
            Console.WriteLine("Enter contact number: ");
            string contact = Console.ReadLine();
            Console.WriteLine("Enter address: ");
            string address = Console.ReadLine();
            Person person = new Person(name, password, role,contact,address);
            return person;
        }
        public static Person GetInputForSignIn()
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();
            Person person = new Person(name, password);
            return person;
        }
        public static string TakeInputAsName()
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            return name;
        }
        public static void DisplayWrongInput()
        {
            Console.WriteLine("Wrong input try another name");
        }
        public static void DisplayPassword(string password)
        {
            Console.WriteLine("Your Password is " + password);
        }

    }
}
