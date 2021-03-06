using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemnt_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank ourBank = new Bank("Developer's Bank", 100);
            bool repeat1 = true;
            Console.WriteLine("Welcome To Our Banking System");

            while (repeat1)
            {
                Console.WriteLine("Open an account");
                Console.WriteLine("Perform transection on an account");
                Console.WriteLine("Exit the application");
                string value1 = Convert.ToString(Console.ReadLine());

                switch (value1)
                {
                    case "open":
                        Console.WriteLine("Open Saving Account..");
                        Console.WriteLine("Open Checking Account");
                        Console.WriteLine("Exit the application");
                        string value2 = Convert.ToString(Console.ReadLine());
                        switch (value2)
                        {
                            case "saving":
                                Console.WriteLine("Enter Account Name");
                                string accountName = Console.ReadLine();
                                Console.WriteLine("Enter Balance:");
                                double balance = Convert.ToDouble(Console.ReadLine());
                                if (balance < 1)
                                {
                                    Console.WriteLine("Invalid Balance");
                                }
                                else
                                {
                                    Console.WriteLine("Enter Address..");

                                    Console.WriteLine("Enter Road Number:");
                                    string roadNo = Console.ReadLine();
                                    Console.WriteLine("Enter House Number:");
                                    string houseNo = Console.ReadLine();
                                    Console.WriteLine("Enter City:");
                                    string city = Console.ReadLine();
                                    Console.WriteLine("Enter Country:");
                                    string country = Console.ReadLine();
                                    Console.WriteLine("Enter Date of Birth :");

                                    Console.WriteLine("Enter Day:");
                                    int dayS = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Enter Month:");
                                    int monthS = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Enter Year:");
                                    int yearS = Convert.ToInt32(Console.ReadLine());

                                    Birthday birthS = new Birthday(dayS, monthS, yearS);
                                    Address addressS = new Address(roadNo, houseNo, city, country);
                                    Account account1 = new Account(accountName, balance, addressS, birthS, "saving", 0);
                                    ourBank.AddAccount(account1);
                                    Console.WriteLine("Saving Account Created Successfully");



                                }
                                continue;

                            case "checking":
                                Console.WriteLine("Enter Account Name");
                                string checkaccountName = Console.ReadLine();
                                Console.WriteLine("Enter Balance:");
                                double checkbalance = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("Enter your Address.");

                                Console.WriteLine("Enter Road Number:");
                                string checkroadNo = Console.ReadLine();
                                Console.WriteLine("Enter House Number:");
                                string checkhouseNo = Console.ReadLine();
                                Console.WriteLine("Enter City:");
                                string checkcity = Console.ReadLine();
                                Console.WriteLine("Enter Country:");
                                string checkcountry = Console.ReadLine();
                                Console.WriteLine("Enter Date of Birth :");

                                Console.WriteLine("Enter Day:");
                                int checkday = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Enter Month:");
                                int checkmonth = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Enter Year:");
                                int checkyear = Convert.ToInt32(Console.ReadLine());

                                Birthday checkbirth = new Birthday(checkday, checkmonth, checkyear);
                                Address checkaddress = new Address(checkroadNo, checkhouseNo, checkcity, checkcountry);
                                Account account2 = new Account(checkaccountName, checkbalance, checkaddress, checkbirth, "Checking", 0);
                                ourBank.AddAccount(account2);
                                Console.WriteLine("Checking Account Created Successfully");

                                continue;
                            case "quit":
                                Console.WriteLine("..Exit..");



                                break;

                        }

                        break;
                    case "account":

                        break;
                }

            }
        }
    }
}
