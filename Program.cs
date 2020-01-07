//----------------------------------------------------------------------
// <copyright file="Program.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace NEW_OPPS_PROJECT
{
    using System;
    using NEW_OPPS_PROJECT.Inventorymanagement;
    using NEW_OPPS_PROJECT.Inventorymanager;
    using NEW_OPPS_PROJECT.Stockaccount;
    using NEW_OPPS_PROJECT.StockAccount;
    using NEW_OPPS_PROJECT.Cliniquemanagement;
    using NEW_OPPS_PROJECT.CliniqueManagement;
    using NEW_OPPS_PROJECT.AddressBook;

    /// <summary>
    /// This is Program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// This is main method.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("--------------HERE IS OPPS PROJECT----------------");
                    Console.WriteLine("1: INVENTORY MANAGAMENT");
                    Console.WriteLine("2: INVENTORY MANAGARr CACULATOR");
                    Console.WriteLine("3: STOCK ACCOUNT MANAGAR");
                    Console.WriteLine("4: FOR STOCK ACCOUNT OPERATION ");
                    Console.WriteLine("5: FOR CARD GAME");
                    Console.WriteLine("6: FOR VISITING CLINIC");
                    Console.WriteLine("7: FOR ADDRESSBOOK PURPOSE");
                    Console.WriteLine("8: TO EXIT THE PROGRAM");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Inputoutput inputoutput = new Inputoutput();
                            inputoutput.Print();
                            break;
                        case 2:
                            Inputoutputmanager inputoutputmanager = new Inputoutputmanager();
                            inputoutputmanager.Printcalculatvalue();
                            break;
                        case 3:
                            Inputstock Inputstock = new Inputstock();
                            Inputstock.Addnewshare();
                            break;
                        case 4:
                            UserStockAccount obj = new UserStockAccount();
                            obj.Stockaccountinput();
                            break;
                        case 5:
                            Userpalyingzone userpalyingzone = new Userpalyingzone();
                            userpalyingzone.Docotor();
                            break;
                        case 6:
                            CliniqueManagementclass cliniqueManagement=new CliniqueManagementclass();
                            cliniqueManagement.WelcometoHospital();
                            break;
                        case 7:
                            BookAddressInterface bookaddressinterface = new BookAddressInterface();
                            bookaddressinterface.UserInterface();
                            break;
                        case 8:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("wrong input intered");
                            break;

                    }
                }
            }
            catch (FormatException FormatException)
            {
                Console.WriteLine(FormatException.Message);
            }
            catch (Exception Exception)
            {
                Console.WriteLine(Exception.Message);
            }
            Console.ReadKey();
        }
    }
}
