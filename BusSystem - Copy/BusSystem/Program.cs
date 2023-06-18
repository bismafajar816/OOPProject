using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusSystem.BL;
using BusSystem.DL;
using BusSystem.UI;
namespace BusSystem
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int option = 0;
            string credentials = "Enteries.txt";
            string drivers = "Drivers.txt";
            string Employees = "otherStaff.txt";
            string BusesData = "bus.txt";
            string CustomerData = "Customer.txt";
            Console.Clear();
            do
            {
                Bus busInput = new Bus("abc", "abc", "abc", "abc");
                Customer customerInput = new Customer("abc", "abc", "Customer", "abc", "abc", null, null);
                StaffDL.LoadData(Employees);
                DriverDL.LoadDriversData(drivers);
                BusDL.LoadData(BusesData);
                PersonDL.LoadData(credentials);
                CustomerDL.LoadData(CustomerData);
                DisplayUI.MainHeader();
                option = DisplayUI.Menu();
                if (option == 1)
                {
                    Person input = PersonUI.GetInputForSignUp();
                    if (PersonDL.CheckIFNameIsPresent(input.GetName()))
                    {
                        PersonUI.DisplayWrongInput();
                    }
                    else
                    {
                        PersonDL.AddToList(input);
                        PersonDL.StoreData(credentials);
                    }

                    DisplayUI.ClearScreen();
                }
                else if (option == 2)
                {
                    Person person = PersonUI.GetInputForSignIn();
                    if (PersonDL.SearchInList(person.GetName(), person.GetPassword()))
                    {
                        if (PersonDL.SearchRoleInList(person.GetName(), person.GetPassword()) == "Admin")
                        {
                            int choice = 0;
                            do
                            {
                                DisplayUI.AdminHeader();
                                choice = AdminUI.Menu();
                                if (choice == 1)
                                {
                                    string type = AdminUI.AddEmployeeType();
                                    if (AdminUI.CheckIfDriverFunction(type))
                                    {
                                        Driver driver = AdminUI.TakeInputForDriver();
                                        DriverDL.AddToList(driver);
                                        DriverDL.StoreData(drivers);
                                        DisplayUI.ClearScreen();
                                    }
                                    else
                                    {
                                        Staff staff = AdminUI.TakeInputForStaff();
                                        StaffDL.AddToList(staff);
                                        StaffDL.StoreData(Employees);
                                        DisplayUI.ClearScreen();

                                    }
                                }
                                else if (choice == 2)
                                {
                                    string type = AdminUI.AddEmployeeType();
                                    if (AdminUI.CheckIfDriverFunction(type))
                                    {
                                        string name = AdminUI.TakeInputAsName();
                                        Driver driver = DriverDL.SearchEmployee(name);
                                        DriverDL.RemoveEmployee(driver.GetName(), driver.GetRank());
                                        DriverDL.StoreData(drivers);
                                        DisplayUI.ClearScreen();
                                    }
                                    else
                                    {
                                        string name = AdminUI.TakeInputAsName();
                                        Staff staff = StaffDL.SearchEmployee(name);
                                        StaffDL.RemoveEmployee(staff.GetName(), staff.GetRank());
                                        StaffDL.StoreData(Employees);
                                        DisplayUI.ClearScreen();
                                    }
                                }
                                else if (choice == 3)
                                {

                                    string type = AdminUI.AddEmployeeType();
                                    if (type == "driver" || type == "Driver")
                                    {
                                        string name = AdminUI.TakeInputAsName();
                                        string updatedName = AdminUI.TakeInputAsUpdatedName();
                                        if (DriverDL.SearchEmployee(name) != null)
                                        {
                                            Driver driver = DriverDL.SearchEmployee(name);
                                            DriverDL.UpdateEmployee(name, updatedName, driver.GetRank(), driver.GetID());
                                            DriverDL.StoreData(drivers);
                                            DisplayUI.ClearScreen();
                                        }
                                    }
                                    else
                                    {
                                        string name = AdminUI.TakeInputAsName();
                                        string updatedName = AdminUI.TakeInputAsUpdatedName();
                                        Staff staff = StaffDL.SearchEmployee(name);
                                        StaffDL.UpdateEmployee(name, updatedName, staff.GetRank(), staff.GetID());
                                        StaffDL.StoreData(Employees);
                                        DisplayUI.ClearScreen();
                                    }
                                }
                                else if (choice == 4)
                                {
                                    if (AdminUI.AddEmployeeType() == "driver" || AdminUI.AddEmployeeType() == "Driver")
                                    {
                                        string name = AdminUI.TakeInputAsName();
                                        if (DriverDL.SearchEmployee(name) != null)
                                        {
                                            Driver driver = DriverDL.SearchEmployee(name);
                                            AdminUI.DisplayDriver(driver);
                                            DisplayUI.ClearScreen();
                                        }
                                    }
                                    else
                                    {
                                        string name = AdminUI.TakeInputAsName();
                                        if (StaffDL.SearchEmployee(name) != null)
                                        {
                                            Staff staff = StaffDL.SearchEmployee(name);
                                            AdminUI.DisplayStaff(staff);
                                            DisplayUI.ClearScreen();

                                        }

                                    }

                                }
                                else if (choice == 5)
                                {
                                    string type = AdminUI.AddEmployeeType();
                                    if (type == "driver" || type == "Driver")
                                    {
                                        AdminUI.DisplayDriver(DriverDL.driversList);
                                        DisplayUI.ClearScreen();
                                    }
                                    else
                                    {
                                        AdminUI.DisplayStaff(StaffDL.EmployeesList);
                                        DisplayUI.ClearScreen();
                                    }
                                }
                                else if (choice == 6)
                                {
                                    Bus bus = BusUI.GetInputForBus();
                                    BusDL.AddBusToList(bus);
                                    BusDL.StoreData(BusesData);
                                    DisplayUI.ClearScreen();
                                }
                                else if (choice == 7)
                                {
                                    string serial = BusUI.TakeSerialNumber();
                                    BusDL.RemoveBus(serial);
                                    BusDL.StoreData(BusesData);
                                    DisplayUI.ClearScreen();
                                }
                                else if (choice == 8)
                                {
                                    string serial = BusUI.TakeSerialNumber();
                                    if (BusDL.SearchBusBySerial(serial) != null)
                                    {
                                        Bus bus = BusDL.SearchBusBySerial(serial);
                                        string updated = BusUI.TakeUpdatedRoute();
                                        BusDL.UpdateBus(serial, bus.GetRoute(), updated);
                                        /*  BusDL.StoreData(BusesData);*/
                                        DisplayUI.ClearScreen();
                                    }

                                }
                                else if (choice == 9)
                                {
                                    string route = BusUI.TakeRoute();
                                    Bus bus = BusDL.SearchBusByRoute(route);
                                    if (bus != null)
                                    {
                                        BusUI.ViewBus(bus);
                                        DisplayUI.ClearScreen();
                                    }
                                    else
                                    {
                                        BusUI.NotAvial();
                                        DisplayUI.ClearScreen();

                                    }

                                }
                                else if (choice == 10)
                                {
                                    string date = BusUI.TakeDate();
                                    Bus bus = BusDL.SearchBusByDate(date);
                                    if (bus != null)
                                    {
                                        BusUI.ViewBus(bus);
                                        DisplayUI.ClearScreen();
                                    }
                                    else
                                    {
                                        BusUI.NotAvial();
                                        DisplayUI.ClearScreen();

                                    }
                                }
                                else if (choice == 11)
                                {
                                    BusUI.ViewBus(BusDL.busesList);
                                    DisplayUI.ClearScreen();
                                }
                                else if(choice == 12)
                                {
                                    double income = StaffDL.GetIncome();
                                    AdminUI.DisplayIncome(income);
                                    DisplayUI.ClearScreen();
                                }
                            }
                            while (choice != 0);

                        }
                        else if(PersonDL.SearchRoleInList(person.GetName(), person.GetPassword()) != "Admin")
                        {
                            int opt = 1;
                            do
                            {
                                DisplayUI.CustomerHeader();
                                bool CancelSeatFlag = false;
                                opt = CustomerUI.Menu();
                                if(opt == 1)
                                {
                                    string route = BusUI.TakeRoute();
                                    Bus bus = BusDL.SearchBusByRoute(route);
                                    if (bus != null)
                                    {
                                        BusUI.ViewBus(bus);
                                        DisplayUI.ClearScreen();
                                    }
                                    else
                                    {
                                        BusUI.NotAvial();
                                        DisplayUI.ClearScreen();


                                    }
                                }
                                else if(opt == 2)
                                {
                                    BusUI.ViewBus(BusDL.busesList);
                                    DisplayUI.ClearScreen();
                                 
                                }
                                else if(opt == 3)
                                {
                                    string serial = BusUI.TakeSerialNumber();
                                     busInput = BusDL.SearchBusBySerial(serial);
                                    if(busInput != null)
                                    {
                                        CustomerUI.DisplaySelected();
                                        DisplayUI.ClearScreen();
                                    }
                                    else
                                    {
                                        CustomerUI.DisplayWrongInput();
                                        DisplayUI.ClearScreen();
                                    }
                                }
                                else if(opt == 4)
                                {
                                    string name = CustomerUI.TakeName();
                                    string password = CustomerUI.TakePassword();
                                    string role = "Customer";
                                    string contact = CustomerUI.TakeContact();
                                    string address = CustomerUI.TakeAddress();
                                    List<int> seats = CustomerUI.TakeSeats();
                                    customerInput = new Customer(name, password, role, contact, address, seats, busInput);
                                    bool flag = customerInput.CheckIfReserved(seats);
                                    CustomerUI.DisplayWrongSeat(flag, customerInput, CustomerDL.customersList);
                                    DisplayUI.ClearScreen();
                                }
                                else if(opt == 5)
                                {
                                    int unchanged = CustomerUI.TakeUnchangedSeat();
                                    int changed = CustomerUI.TakechangedSeat();
                                    bool flag =   customerInput.UpdateSeatNumber(unchanged, changed);
                                    if(flag != true)
                                    {
                                        CustomerUI.DisplayWrongInput();
                                        DisplayUI.ClearScreen();
                                    }    

                                }
                                else if(opt == 6)
                                {
                                    string type = CustomerUI.TakePaymentMethod();
                                    double charges= customerInput.GetCharges(type);                                     
                                    CustomerUI.DisplayCharges(charges);
                                    if(customerInput.GetBus() != null)
                                    {
                                        CustomerDL.AddCustomerToList(customerInput);
                                        CustomerDL.StoreData(CustomerData, customerInput);
                                        DisplayUI.ClearScreen();
                                    }
                                    else
                                    {
                                        CustomerUI.DisplayWrongInput();
                                        DisplayUI.ClearScreen();
                                    }

                                }
                                else if(opt == 7)
                                {
                                    int Cancelseat = CustomerUI.TakeSeatToCancel();
                                    CancelSeatFlag =   customerInput.CancelSeat(Cancelseat);
                                    DisplayUI.ClearScreen();
                                }
                                else if(opt == 8)
                                {
                                   double refund =  customerInput.GetRefund(CancelSeatFlag);
                                   CustomerUI.DisplayRefund(refund, CancelSeatFlag);
                                   CustomerDL.ReplaceCustomer(customerInput);
                                 /*  CustomerDL.StoreData(CustomerData, customerInput);*/
                                   DisplayUI.ClearScreen();
                                }
                                else if(opt == 9)
                                {
                                    CustomerUI.DisplayTickets(CustomerDL.customersList);
                                    DisplayUI.ClearScreen();
                                }
                            }
                            while (opt != 0);
                            
                        }
                    }
                    DisplayUI.ClearScreen();

                }
                else if(option == 3)
                {
                    string name = PersonUI.TakeInputAsName();
                    string password = PersonDL.GetPasswordByName(name);
                    if (password != null)
                    {
                        PersonUI.DisplayPassword(password);
                        DisplayUI.ClearScreen();
                    } 
                    else
                    {
                        PersonUI.DisplayWrongInput();
                        DisplayUI.ClearScreen();
                    }
                }
            }
            while (option != 4);

        }
    }
}
