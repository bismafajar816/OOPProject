using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusSystem.UI
{
    class DisplayUI
    {
         public static int Menu()
        {
            Console.WriteLine("1. Sign Up");
            Console.WriteLine("2. Sign In");
            Console.WriteLine("3. Forgot your password");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter choice");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        public static void ClearScreen()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        public static void MainHeader()
        {

            Console.WriteLine("      >>        >=>              >=======>                                              >=>       >=>              >=>                              ");
            Console.WriteLine("     >>=>       >=>              >=>                      >=>                           >> >=>   >>=>              >=>                              ");
            Console.WriteLine("    >> >=>      >=>              >=>          >=> >=>            >=> >=>  >> >==>       >=> >=> > >=>    >=>     >=>>==>    >=>     >> >==>  >===>  ");
            Console.WriteLine("   >=>  >=>     >=> >====>       >=====>    >=>   >=>     >=>  >=>   >=>   >=>          >=>  >=>  >=>  >=>  >=>    >=>    >=>  >=>   >=>    >=>     ");
            Console.WriteLine("  >=====>>=>    >=>              >=>       >=>    >=>     >=> >=>    >=>   >=>          >=>   >>  >=> >=>    >=>   >=>   >=>    >=>  >=>      >==>  ");
            Console.WriteLine(" >=>      >=>   >=>              >=>        >=>   >=>     >=>  >=>   >=>   >=>          >=>       >=>  >=>  >=>    >=>    >=>  >=>   >=>        >=> ");
            Console.WriteLine(">=>        >=> >==>              >=>         >==>>>==>    >=>   >==>>>==> >==>          >=>       >=>    >=>        >=>     >=>     >==>    >=> >=> ");
            Console.WriteLine("                                                       >==>                                                                                         ");
            Console.WriteLine("");
            Console.WriteLine("");
        }
        public static void AdminHeader()
        {
            Console.Clear();
            Console.WriteLine("   _   _   _   _   _   _   _     _   _   _   _     _   _   _   _   _  ");
            Console.WriteLine("  / \\ / \\ / \\ / \\ / \\ / \\ / \\   / \\ / \\ / \\ / \\   / \\ / \\ / \\ / \\ / \\ ");
            Console.WriteLine(" ( W | e | l | c | o | m | e ) ( D | e | a | r ) ( A | d | m | i | n )");
            Console.WriteLine("  \\_/ \\_/ \\_/ \\_/ \\_/ \\_/ \\_/   \\_/ \\_/ \\_/ \\_/   \\_/ \\_/ \\_/ \\_/ \\_/ ");


        }
        public static void CustomerHeader()
        {
            Console.Clear();
            Console.WriteLine("   _   _   _   _   _   _   _     _   _   _   _     _   _   _   _   _   _   _   _  ");
            Console.WriteLine("  / \\ / \\ / \\ / \\ / \\ / \\ / \\   / \\ / \\ / \\ / \\   / \\ / \\ / \\ / \\ / \\ / \\ / \\ ");
            Console.WriteLine(" ( W | e | l | c | o | m | e ) ( D | e | a | r ) ( C | u | s | t | o | m | e | r )");
            Console.WriteLine("  \\_/ \\_/ \\_/ \\_/ \\_/ \\_/ \\_/   \\_/ \\_/ \\_/ \\_/   \\_/ \\_/ \\_/ \\_/ \\_/ \\_/ \\_/ ");
        }

    }
}
