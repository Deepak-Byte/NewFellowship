//----------------------------------------------------------------------
// <copyright file="Stocks.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace NEW_OPPS_PROJECT.StockAccount
{
    using Nancy.Json;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// This is class Inputstock.
    /// </summary>
    public class Inputstock
    {
        /// <summary>
        /// The jscript
        /// </summary>
        JavaScriptSerializer jscript = new JavaScriptSerializer();
        /// <summary>
        /// Addnewshares this instance.
        /// </summary>
        public void Addnewshare()
        {
            List<Stocks> list = new List<Stocks>();
            Stocks stocks = new Stocks();
            Stockmanagament stockmanagament = new Stockmanagament();

            //ENTER NAME OF COMPANY SHARE
            Console.WriteLine("ENTER NAME OF SHARE");
            string sharname = Console.ReadLine();
            //ENTER NUMBER OF SHARE USER WANT SHARE
            Console.WriteLine("ENTER NUMBER OF SHARE");
            int sharenumber = int.Parse(Console.ReadLine());
            //ENTER PRICE OF SHARE FROM USER
            Console.WriteLine("ENTER PRICE OF SHARE");
            int shareprice = int.Parse(Console.ReadLine());
            //FILE PATH DATA READING
            string jsondata = System.IO.File.ReadAllText(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\StockAccountManager\Stockjson.json");
            //Deserialize READED DATA
            list = jscript.Deserialize<List<Stocks>>(jsondata);
            //ADDING TO LIST OF STOCK WHICH IS CLASS
            list.Add(new Stocks() { Sharename = sharname, Numberofshare = sharenumber, Shareprice = shareprice });
            //SerializeObject LIST 
            jsondata = JsonConvert.SerializeObject(list);
            //WriteAllText TO SAME PATH 
            System.IO.File.WriteAllText(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\StockAccountManager\Stockjson.json" , jsondata);


            Console.WriteLine("Do you want to see the data you entered than pres 'Y' ");
            char check = char.Parse(Console.ReadLine());
            if (check == 'Y' || check == 'y')
            {
                using (StreamReader read = new StreamReader(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\StockAccountManager\Stockjson.json"))
                {
                    Console.WriteLine();
                    string json = read.ReadToEnd();
                    //List<Stocks> items = JsonConvert.DeserializeObject<List<Stocks>>(json);
                    dynamic array = JsonConvert.DeserializeObject(json);
                    foreach (var item in array)
                    {
                        Console.WriteLine("NAME : {0}\nNUMBER OF SHARE : {1}\nVALUE OF SHARE : {2}", item.Sharename, item.Numberofshare, item.Shareprice);
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine("Succesfully Added Congratulation ");
        }

       
    }
}
