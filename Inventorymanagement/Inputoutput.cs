
//----------------------------------------------------------------------
// <copyright file="Inputoutput.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace NEW_OPPS_PROJECT.Inventorymanagement
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    public class Inputoutput
    {
        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            //Reading file using steam reader.
            using (StreamReader read = new StreamReader(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\Inventorymanagement\INVENTORYJSON.json"))
            {
                string json = read.ReadToEnd();
                //List<Inventorygrocery> items = JsonConvert.DeserializeObject<List<Inventorygrocery>>(json);
                dynamic array = JsonConvert.DeserializeObject(json);
                foreach(var item in array)
                {
                    Console.WriteLine("TYPE : {0}\nNAME : {1}\nWEIGHT : {2}\n PRICE : {3}" , item.Type, item.Name, item.Weight , item.Price);
                }
                Console.WriteLine();
            }
        }
    }
}
