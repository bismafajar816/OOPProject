using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRCofBusSystem
{
    public class CustomerUI
    {
        public static int Menu()
        {
            Console.WriteLine("                You are allowed to perform the following tasks");
            Console.WriteLine("                ---------------------------------------------------------------");
            Console.WriteLine("                1. Search bus by route");
            Console.WriteLine("                2. View all buses");
            Console.WriteLine("                3. Select bus");
            Console.WriteLine("                4. Enter personal details");
            Console.WriteLine("                5. Update seat");
            Console.WriteLine("                6. Pay for your seats");
            Console.WriteLine("                7. Cancel seat");
            Console.WriteLine("                8. Get a refund");
            Console.WriteLine("                9. View Reserved tickets");
            Console.WriteLine("                0. Exit");
            Console.WriteLine("                ----------------------------------------------------------------\n\n");
            Console.Write("                Your option: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        public static int TakeSeatToCancel()
        {
            Console.WriteLine("Enter seat number to cancel: ");
            int seat = int.Parse(Console.ReadLine());
            return seat;
        }
        public static void DisplayRefund(double refund, bool flag)
        {
            if (flag == true)
            {
                Console.WriteLine("Refund done 50 % " + refund + " rupees");

            }
            else
            {
                Console.WriteLine("No refund done");
            }

        }
        public static string TakePaymentMethod()
        {
            Console.WriteLine("Cash or Card");
            Console.WriteLine("5 % discount on card");
            Console.WriteLine("Enter your choice");
            string choice = Console.ReadLine();
            choice = choice.ToLower();
            return choice;
        }
        public static List<int> TakeSeats()
        {
            List<int> seats = new List<int>();
            Console.WriteLine("Enter how many seats you want to reserve");
            int number = int.Parse(Console.ReadLine());
            for (int x = 1; x <= number; x++)
            {
                Console.WriteLine("Enter seat number: ");
                int seat = int.Parse(Console.ReadLine());
                seats.Add(seat);

            }
            return seats;
        }
        public static void DisplayWrongSeat(bool flag, Customer customer, List<Customer> customers)
        {
            if (flag == true)
            {
                Console.WriteLine("Can not select this seat ");
            }
            else
            {
                Console.WriteLine("Seats selected");
                customers.Add(customer);
            }
        }
        public static string TakeName()
        {
            Console.WriteLine("Enter name of customer: ");
            string name = Console.ReadLine();
            return name;
        }
        public static string TakePassword()
        {
            Console.WriteLine("Enter password of customer: ");
            string name = Console.ReadLine();
            return name;
        }
        public static string TakeContact()
        {
            Console.WriteLine("Enter contact number of customer: ");
            string name = Console.ReadLine();
            return name;
        }
        public static string TakeAddress()
        {
            Console.WriteLine("Enter address of customer: ");
            string name = Console.ReadLine();
            return name;
        }

        public static void DisplaySelected()
        {
            Console.WriteLine("Your bus is selected");
        }
        public static void DisplayWrongInput()
        {
            Console.WriteLine("Can not select this bus");
        }
        public static int TakeUnchangedSeat()
        {
            Console.WriteLine("Enter unchanged seat number: ");
            int seat = int.Parse(Console.ReadLine());
            return seat;
        }
        public static int TakechangedSeat()
        {
            Console.WriteLine("Enter updated seat number: ");
            int seat = int.Parse(Console.ReadLine());
            return seat;
        }
        public static void DisplayCharges(double charges)
        {
            Console.WriteLine("You Payable Amount is: " + charges);
        }
        public static void DisplayTickets(List<Customer> customers)
        {
            Console.WriteLine("Bus Number\t\tSeat Numbers (downward)");
            foreach (var customer in customers)
            {
                Console.Write(customer.GetBus().GetBusNumber());

                var seatNumbers = customer.GetList();
                foreach (var seatNumber in seatNumbers)
                {
                    Console.Write("\t\t" + seatNumber);
                }

                Console.WriteLine(); // Add a line break after each customer's data
            }
        }
    }
}