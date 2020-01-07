//----------------------------------------------------------------------
// <copyright file="UserStockAccount.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace NEW_OPPS_PROJECT.Stockaccount
{
   using Nancy.Json;
   using System.Collections.Generic;
   using Newtonsoft.Json;
   using System.IO;
   using System;

    /// <summary>
    /// This is class of name User Stock Account where all methods include share sell & share buy.
    /// </summary>
    public class UserStockAccount
    {
        /// <summary>
        /// The jscript.
        /// </summary>
        JavaScriptSerializer jscript = new JavaScriptSerializer();
        /// <summary>
        /// Stock account inputs this is method for user to buy a share with print it's data.
        /// </summary>
        public void Stockaccountinput()
        {
            List<Customars> list = new List<Customars>();
            Customars stocks = new Customars();
            Stockvaluelist stockvaluelist = new Stockvaluelist();
            try
            {
                Console.WriteLine("-------------------------WELCOME TO SHARE MARKET----------------------------");

                Console.WriteLine("+++++++++++++++++++ WE HAVE TWO COMPANY SHARE AVAILABLE ++++++++++++++++++++");

                Console.WriteLine("                         TCS MUTUAL FUND SERNICE                            ");
                Console.WriteLine("TOTAL NUMBER OF SHARE AVAILABLE IS : " + 500 + "                    ");
                Console.WriteLine("VALUE OF EACH SHARE : " + 1500);

                Console.WriteLine("                         RBI SIP CURRENT MODE                               ");
                Console.WriteLine("TOTAL NUMBER OF SHARE AVAILABLE IS : " + 200 + "                  ");
                Console.WriteLine("VALUE OF EACH SHARE : " + 1000);
                Console.WriteLine();
                Console.WriteLine("IN WHICH COMPANY YOU WANT TO INVEST MONEY ");

                Console.WriteLine("DO YOU WANT TO BUY A SHARE THAN PRESS [1] :");
                Console.WriteLine("DO YOU WANT TO SHELL YOUR SHARE THAN PRESS [2] :");
                int choice = int.Parse(Console.ReadLine());
                ////TO select either sell or buy share.
                if (choice == 1)
                {
                    //Name to user as input.
                    Console.WriteLine("ENTER YOUR NAME");
                    string nameofholder = Console.ReadLine();
                    //Amount vailable in user bank as input.
                    Console.WriteLine("ENTER THE AMOUNT AVAILABLE IN YOUR BANK ");
                    int amount = int.Parse(Console.ReadLine());
                    Console.WriteLine("*********CONGRATULATION********");
                    Console.WriteLine("YOUR ACCOUNT IS SUCCESFULY CREATED");
                    //Operton to user to select company to invest money.
                    Console.WriteLine("WHICH COMPANY SHARE YOU WANT TO PURCHES \nPRESS [1] FOR TCS \nPRESS [2] FOR RBI");
                    int company = int.Parse(Console.ReadLine());
                    if (company == 1)
                    {
                        //Number of share customar want to buy from user.
                        Console.WriteLine("HOW MANY SHARE YOU WANT TO BUY");
                        int numberofshare = int.Parse(Console.ReadLine());
                        int b = Checkstatus(1, numberofshare);
                        if ((b > 0) && amount>(1500* numberofshare))
                        {
                            int amountdeducted = numberofshare * 1500;
                            string jsondata = System.IO.File.ReadAllText(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\Stockaccount\Tcscustomar.json");
                            list = jscript.Deserialize<List<Customars>>(jsondata);
                            int ramaningshare = (b - numberofshare);
                            int balanacetcs = checkbalanceoftcs();

                            list.Add(new Customars()
                            {
                                Nameofcompany = "TCS",
                                Numberofshare = 500,
                                Valueofeachshare = 1500,
                                Shareremainig = ramaningshare,
                                Companybalances = balanacetcs + (1500 * numberofshare),

                                Nameofcustomor = nameofholder,
                                Amountdeducted = (1500 * numberofshare),
                                Customarbalances = amount - (1500 * numberofshare),
                                Customarshare = numberofshare
                            });
                            jsondata = JsonConvert.SerializeObject(list);
                            System.IO.File.WriteAllText(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\Stockaccount\Tcscustomar.json", jsondata);
                            Console.WriteLine("INVENTORY AADED SUCCESFULLY");

                            Console.WriteLine("Do you want to see the data you entered than pres 'Y' ");
                            char check = char.Parse(Console.ReadLine());
                            if (check == 'Y' || check == 'y')
                            {
                                using (StreamReader read = new StreamReader(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\Stockaccount\Tcscustomar.json"))
                                {
                                    Console.WriteLine();
                                    string json = read.ReadToEnd();
                                    List<Customars> items = JsonConvert.DeserializeObject<List<Customars>>(json);
                                    dynamic array = JsonConvert.DeserializeObject(json);
                                    foreach (var item in array)
                                    {
                                        Console.WriteLine("NAME OF COMPANY: {0}\nNUMBER OF SHARE : {1}\nVALUE OF SHARE : {2}\nSHARE REMAINING OF COMPANY : {3}\nCOMPANY BANK BALANCES : {4}\nNAME OF CUSTOMAR : {5}\nAMOUNT DEDUCTED FROM CUSTOMAR BANK : {6}\nCUSTOMAR BANK BALANCES : {7}\nCUSTOMAR SHARE : {8}\n"
                                            , item.Nameofcompany,
                                            item.Numberofshare, 
                                            item.Valueofeachshare, 
                                            item.Shareremainig, 
                                            item.Companybalances,
                                            
                                            item.Nameofcustomor, 
                                            item.Amountdeducted,
                                            item.Customarbalances, 
                                            item.Customarshare);
                                        Console.WriteLine();
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("YOU ARE NOT ELIGIBLE TO THIS SHARE");
                        }
                    }
                    else
                    {
                        Console.WriteLine("HOW MANY SHARE YOU WANT TO BUY");
                        int numberofshareRBI = int.Parse(Console.ReadLine());
                        int b = Checkstatus(2, numberofshareRBI);
                         if ((b > 0) && amount > (1500 * numberofshareRBI))
                         {

                            int amountdeducted = numberofshareRBI * 1500;
                            string jsondata = System.IO.File.ReadAllText(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\Stockaccount\Rbiustomar.json");
                            list = jscript.Deserialize<List<Customars>>(jsondata);
                            int ramaningshare = (b - numberofshareRBI);
                            int balanacerbi =  checkbalanceofrbi();
                            list.Add(new Customars()
                            {
                                Nameofcompany = "RBI SIP",
                                Numberofshare = 200,
                                Valueofeachshare = 1000,
                                Shareremainig = ramaningshare,
                                Companybalances = balanacerbi + (1000 * numberofshareRBI),

                                Nameofcustomor = nameofholder,
                                Amountdeducted = (1000 * numberofshareRBI),
                                Customarbalances = amount - (1000 * numberofshareRBI),
                                Customarshare = numberofshareRBI
                            });
                            jsondata = JsonConvert.SerializeObject(list);
                            System.IO.File.WriteAllText(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\Stockaccount\Rbiustomar.json", jsondata);
                            Console.WriteLine("INVENTORY AADED SUCCESFULLY");

                            Console.WriteLine("Do you want to see the data you entered than pres 'Y' ");
                            char check = char.Parse(Console.ReadLine());
                            if (check == 'Y' || check == 'y')
                            {
                                using (StreamReader read = new StreamReader(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\Stockaccount\Rbiustomar.json"))
                                {
                                    Console.WriteLine();
                                    string json = read.ReadToEnd();
                                    List<Customars> items = JsonConvert.DeserializeObject<List<Customars>>(json);
                                    dynamic array = JsonConvert.DeserializeObject(json);
                                    foreach (var item in array)
                                    {
                                        Console.WriteLine("NAME OF COMPANY: {0}\nNUMBER OF SHARE : {1}\nVALUE OF SHARE : {2}\nSHARE REMAINING OF COMPANY : {3}\nCOMPANY BANK BALANCES : {4}\nNAME OF CUSTOMAR : {5}\nAMOUNT DEDUCTED FROM CUSTOMAR BANK : {6}\nCUSTOMAR BANK BALANCES : {7}\nCUSTOMAR SHARE : {8}\n"
                                            , item.Nameofcompany,
                                            item.Numberofshare,
                                            item.Valueofeachshare,
                                            item.Shareremainig,
                                            item.Companybalances,

                                            item.Nameofcustomor,
                                            item.Amountdeducted,
                                            item.Customarbalances,
                                            item.Customarshare);
                                        Console.WriteLine();
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("YOU ARE NOT ELIGIBLE TO THIS SHARE");
                        }
                    }
                }
                else
                {
                    Shellshare();
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
        }

        /**************************************************Check status of share of RBI & TCS*************************************************/
        /// <summary>
        /// Checkstatuses the specified type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        public int Checkstatus(int type , int number)
        {
            int available = 0;
            if (type == 1)
            {

                using (StreamReader read = new StreamReader(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\Stockaccount\Tcscustomar.json"))
                {

                    string json = read.ReadToEnd();
                    //List<Customars> items = JsonConvert.DeserializeObject<List<Customars>>(json);
                    dynamic array = JsonConvert.DeserializeObject(json);
                    foreach (var item in array)
                    {
                        Console.WriteLine(item.Shareremainig);

                        available = item.Shareremainig;
                        
                    }
                }
                return available;
            }
            else
            {
                using (StreamReader read = new StreamReader(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\Stockaccount\Rbiustomar.json"))
                {

                    string json = read.ReadToEnd();
                    //List<Customars> items = JsonConvert.DeserializeObject<List<Customars>>(json);
                    dynamic array = JsonConvert.DeserializeObject(json);
                    foreach (var item in array)
                    {
                        Console.WriteLine(item.Shareremainig);

                        available = item.Shareremainig;
                    }
                }
                return available;
            }
                
        }

        /*************************************************************Shell share********************************************************/
        /// <summary>
        /// This is method for shellimg a share to company.
        /// </summary>
        
        public void Shellshare()
        {
            JavaScriptSerializer jscript = new JavaScriptSerializer();
            List<Customars> list = new List<Customars>();
            Customars stocks = new Customars();
            Stockvaluelist stockvaluelist = new Stockvaluelist();
            int availableshare = 0;
            int availablebalance = 0;
            int availablesharecustomar = 0;
            try
            {
                Console.WriteLine("TO WHICH COMPANY YOU WANT TO SHELL YOUR SHARE FOR 'TCS' [1] 'RBI' [2] ");
                int companyname = int.Parse(Console.ReadLine());
                if (companyname == 1)
                {
                    
                    Console.WriteLine("DO YOU ALREADY HAVE ACCOUNT FOR TCS COMPANY");
                    Console.WriteLine("IF YES THAN PRESS 'Y' IF NO THAN PRESS 'N' ");
                    Char choice = char.Parse(Console.ReadLine());
                    if (choice == 'y' || choice == 'Y')
                    {
                        Console.WriteLine("ENTER YOUR NAME");
                        string sellusername = Console.ReadLine();
                        Console.WriteLine("HOW MANY SHARE YOU WANT TO SHELL");
                        int numofshaellshare = int.Parse(Console.ReadLine());
                        Console.WriteLine("ENTER VALUE OF EACH SHARE");
                        int eachsharevalue = int.Parse(Console.ReadLine());
                        int totalsum = numofshaellshare * eachsharevalue;

                        string tcsdata = File.ReadAllText(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\Stockaccount\Tcscustomar.json");
                        List<Customars> items = JsonConvert.DeserializeObject<List<Customars>>(tcsdata);
                        dynamic array = JsonConvert.DeserializeObject(tcsdata);
                        foreach (var item in array)
                        { 
                            availablebalance = item.Companybalances;
                            availableshare = item.Shareremainig;
                            availablesharecustomar = item.Customarshare;
                        }

                        foreach (var item in items)
                        {
                            if ((sellusername).Equals(item.Nameofcustomor))
                            {
                                item.Shareremainig = availableshare + numofshaellshare;
                                item.Companybalances = availablebalance - totalsum;
                                item.Customarbalances = availablebalance + totalsum;
                                item.Customarshare = availablesharecustomar - numofshaellshare;
                                tcsdata = JsonConvert.SerializeObject(items);
                                System.IO.File.WriteAllText(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\Stockaccount\Tcscustomar.json", tcsdata);
                                break;
                            }
                        }
                        Console.WriteLine("INVENTORY UPDATED SUCCESFULLY");

                    }
                }
                else
                {
                    Console.WriteLine("DO YOU ALREADY HAVE ACCOUNT FOR RBI SIP COMPANY");
                    Console.WriteLine("IF YES THAN PRESS 'Y' IF NO THAN PRESS 'N' ");
                    Char choice = char.Parse(Console.ReadLine());
                    if (choice == 'y' || choice == 'Y')
                    {
                        Console.WriteLine("ENTER YOUR NAME");
                        string sellusername = Console.ReadLine();
                        Console.WriteLine("HOW MANY SHARE YOU WANT TO SHELL");
                        int numofshaellshare = int.Parse(Console.ReadLine());
                        Console.WriteLine("ENTER VALUE OF EACH SHARE");
                        int eachsharevalue = int.Parse(Console.ReadLine());
                        int totalsum = numofshaellshare * eachsharevalue;

                        string rbidata = File.ReadAllText(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\Stockaccount\Rbiustomar.json");
                        //list = jscript.Deserialize<List<Customars>>(tcsdata);
                        List<Customars> items = JsonConvert.DeserializeObject<List<Customars>>(rbidata);
                        dynamic array = JsonConvert.DeserializeObject(rbidata);
                        foreach (var item in array)
                        {
                            availablebalance = item.Companybalances;
                            availableshare = item.Shareremainig;
                            availablesharecustomar = item.Customarshare;
                        }
                        foreach (var item in items)
                        {
                            if ((sellusername).Equals(item.Nameofcustomor))
                            {
                                item.Shareremainig = availableshare + numofshaellshare;
                                item.Companybalances = availablebalance - totalsum;

                                item.Customarbalances = availablebalance + totalsum;
                                item.Customarshare = availablesharecustomar - numofshaellshare;
                                rbidata = JsonConvert.SerializeObject(items);
                                System.IO.File.WriteAllText(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\Stockaccount\Rbiustomar.json", rbidata);
                                break;
                            }
                        }
                        Console.WriteLine("INVENTORY UPDATED SUCCESFULLY");
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
        }


        /*************************************************************check balance of tcs********************************************************/
        /// <summary>
        /// Checkbalanceoftcses this instance.
        /// </summary>
        /// <returns></returns>
        public int checkbalanceoftcs()
        {
            int available = 0;
            using (StreamReader read = new StreamReader(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\Stockaccount\Tcscustomar.json"))
            {

                string json = read.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                foreach (var item in array)
                {
                    //Console.WriteLine(item.Shareremainig);
                    available = item.Companybalances;
                }
            }
            return available;
        }

        /*************************************************************check balance of rbi********************************************************/
        /// <summary>
        /// Checkbalanceofrbis this instance.
        /// </summary>
        /// <returns></returns>
        public int checkbalanceofrbi()
        {
            int available = 0;
            using (StreamReader read = new StreamReader(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\Stockaccount\Rbiustomar.json"))
            {

                string json = read.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                foreach (var item in array)
                {
                    //Console.WriteLine(item.Shareremainig);
                    available = item.Companybalances;
                }
            }
            return available;
        }


    }
}
