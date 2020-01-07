//----------------------------------------------------------------------
// <copyright file="BookAddressInterface.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace NEW_OPPS_PROJECT.AddressBook
{
    using Nancy.Json;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    /// <summary>
    /// This is class for userinterface.
    /// </summary>
    public class BookAddressInterface
    {
        List<BookDetails> list = new List<BookDetails>();
        JavaScriptSerializer jscript = new JavaScriptSerializer();
        /// <summary>
        /// This is switch method.
        /// </summary>
        public void UserInterface()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n-----------------------------WELCOME TO ADDRESS BOOK DICTIONARY-----------------------------\n");
                Console.WriteLine("1: FOR TO ADD NEW PERSON IN LIST");
                Console.WriteLine("2: FOR TO EDIT DETAILS OF EXITING PERSON");
                Console.WriteLine("3: FOR TO DELETE A PERSON");
                Console.WriteLine("4: PRINT A ADDRESS BOOK");
                Console.WriteLine("5: SHORT BY NAME");
                Console.WriteLine("6: To Create New File");
                Console.WriteLine("7: TO EXIT PROGARM");
                int userchoice = int.Parse(Console.ReadLine());
                switch (userchoice)
                {
                    case 1:
                        Addnewperson();
                        break;
                    case 2:
                        Editperson();
                        break;
                    case 3:
                        Delete();
                        break;
                    case 4:
                        Print();
                        break;
                    case 5:
                        ShortbyName();
                        break;
                    case 6:
                        Creatnewfile();
                        break;
                    case 7:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("WRONG INPUT ENTERED BY YOU");
                        break;
                }
            }
        }

        /// <summary>
        /// This is Creat file method.
        /// </summary>
        private void Creatnewfile()
        {
            //Reading from file format from user
            Console.WriteLine("ENTER NEW FILE NAME WITH EXTENSION ");
            string filename = Console.ReadLine();
            //Createing new file of extension as par user choice
            StreamWriter file = new StreamWriter(filename);
            //User data
            Console.WriteLine("\n1: ENTER NEW NAME\n2: ENTER NEW PHONE NUMBER\n3: ENTER MODIFIED AGE\n4: ENTER NEW ADDRESES");
            string newusername = Console.ReadLine();
            string newusernumber = Console.ReadLine();
            string newuseraddress = Console.ReadLine();
            string newuserage = Console.ReadLine();
            //Adding into list
            list.Add(new BookDetails()
            {
                UserName = newusername,
                UserNumber = newusernumber,
                AgeofUser = newuserage,
                UserAddress = newuseraddress
            });
            //Serialize it as par json file formate
            string jsondata = JsonConvert.SerializeObject(list);
            //Writting all data into file created file
            file.Write(jsondata);
            Console.WriteLine("\n***********NEW PERSON GET AADED SUCCESFULLY***********\n\n");
            //Closing file
            file.Close();
        }

        /// <summary>
        /// This is Short name method.
        /// </summary>
        private void ShortbyName()
        {
            //Console.WriteLine("ENTER NAME OF NEW JSON FILE");
            //string newfielname = Console.ReadLine();
            string jsondata = File.ReadAllText(AddressPath());
            //list = jscript.Deserialize<List<BookDetails>>(jsondata);
            list.Sort();
            list = jscript.Deserialize<List<BookDetails>>(jsondata);
            var descListOb = list.OrderBy(x => x.UserName);
            JsonConvert.SerializeObject(descListOb);
            Print();
        }

        /// <summary>
        /// This is  Print method.
        /// </summary>
        private void Print()
        {
            string filepath = AddressPath();
            string jsondata = System.IO.File.ReadAllText(filepath);
            list = jscript.Deserialize<List<BookDetails>>(jsondata);

            foreach (var item in list)
            {
                Console.WriteLine("\n-----------------------------------------------------------------------------------------");
                Console.WriteLine("\nNAME OF PERSON: {0}\nPHONE NUMBER OF HIS: {1}\nADDRESS OF PERSON: {2}\nAGE OF PERSON: {3}",
                                 item.UserName,
                                 item.UserNumber,
                                 item.UserAddress,
                                 item.AgeofUser
                                 );
                Console.WriteLine("-----------------------------------------------------------------------------------------\n");
            }
        }

        /// <summary>
        /// This is Delete method.
        /// </summary>
        private void Delete()
        {
            int count = 0;
            Console.WriteLine("ENTER YOUR SERIAL NUMBER");
            int userserialno = int.Parse(Console.ReadLine());

            string filepath = AddressPath();
            string jsondata = System.IO.File.ReadAllText(filepath);
            list = jscript.Deserialize<List<BookDetails>>(jsondata);
            foreach (var item in list)
            {
                if (userserialno == (item.Userserialnum))
                {
                    list.RemoveAt(count);
                    jsondata = JsonConvert.SerializeObject(list);
                    string filepath1 = AddressPath();
                    File.WriteAllText(filepath1, jsondata);
                    break;
                }
                count++;
            }
        }

        /// <summary>
        /// This is Edit method.
        /// </summary>
        private void Editperson()
        {
            Console.WriteLine("ENTER YOUR SERIAL NUMBER");
            int userinputint = int.Parse(Console.ReadLine());
            Console.WriteLine("\n1: ENTER NEW NAME\n2: ENTER NEW PHONE NUMBER\n3: ENTER MODIFIED AGE\n4: ENTER NEW ADDRESES");
            string newusername = Console.ReadLine();
            string newusernumber = Console.ReadLine();
            string newuserage = Console.ReadLine();
            string newuseraddress = Console.ReadLine();

            string filepath = AddressPath();
            string jsondata = System.IO.File.ReadAllText(filepath);
            list = jscript.Deserialize<List<BookDetails>>(jsondata);
            foreach (var item in list)
            {
                if (userinputint == (item.Userserialnum))
                {
                    item.UserName = newusername;
                    item.UserNumber = newusernumber;
                    item.UserAddress = newuseraddress;
                    item.AgeofUser = newuserage;
                    jsondata = JsonConvert.SerializeObject(list);
                    string filepath1 = AddressPath();
                    System.IO.File.WriteAllText(filepath1, jsondata);
                    Console.WriteLine("\n#####################YOUR CHANGES HAS BEEN DONE SUCCESFULLY#####################\n");
                    break;
                }
            }
        }

        /// <summary>
        /// This is Add method.
        /// </summary>
        private void Addnewperson()
        {
            Console.WriteLine("\nENTER NAME OF NEW USER\nENTER USER PHONE NUMBER\nENTER USER ADDRESS\nENTER USER AGE\n");
            string newusername = Console.ReadLine();
            string newusernumber = Console.ReadLine();
            string newuseraddress = Console.ReadLine();
            string newuserage = Console.ReadLine();
            //Reading file from path
            string filepath = AddressPath();
            string jsondata = System.IO.File.ReadAllText(filepath);
            list = jscript.Deserialize<List<BookDetails>>(jsondata);

            int userserialnum = Getserialnum();
            list.Add(new BookDetails()
            {
                UserName = newusername,
                UserNumber = newusernumber,
                AgeofUser = newuserage,
                UserAddress = newuseraddress,
                Userserialnum = userserialnum + 1,
            }); 
            jsondata = JsonConvert.SerializeObject(list);
            string filepath1 = AddressPath();
            File.WriteAllText(filepath1, jsondata);
            Console.WriteLine("\n***********NEW PERSON GET AADED SUCCESFULLY***********\n\n");
        }

        /// <summary>
        /// This is serial number return method.
        /// </summary>
        /// <returns></returns>
        public int Getserialnum()
        {
            int count = 0; 
            string filepath = AddressPath();
            string jsondata = File.ReadAllText(filepath);
            list = jscript.Deserialize<List<BookDetails>>(jsondata);
            foreach (var item in list)
            {
                count++;
            }
            return count;
        }

        /// <summary>
        /// This is filepath return mehtod.
        /// </summary>
        /// <returns></returns>
        public string AddressPath()
        {
            string filepath = @"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\AddressBook\Addressbook.json";
            return filepath;
        }
    }
}
