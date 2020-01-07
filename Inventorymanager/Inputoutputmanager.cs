//----------------------------------------------------------------------
// <copyright file="Inputoutputmanager.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace NEW_OPPS_PROJECT.Inventorymanager
{
    using Newtonsoft.Json;
    using System;
    using System.IO;

    /// <summary>
    /// This is class Inputoutputmanager.
    /// </summary>
    public class Inputoutputmanager
    {
        /// <summary>
        /// Printcalculatvalues this instance.
        /// </summary>
        public void Printcalculatvalue()
        {
            //Reading file using sttream reader from path of json file
            using (StreamReader read = new StreamReader(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\Inventorymanagement\INVENTORYJSON.json"))
            {
                string json = read.ReadToEnd();
                //List<Inventorymanagament> items = JsonConvert.DeserializeObject<List<Inventorymanagament>>(json);
                //Inputoutputmanager reded data of json file
                dynamic array = JsonConvert.DeserializeObject(json);
                foreach (var item in array)
                {
                    Console.WriteLine("TYPE : {0}\nNAME : {1}\nWEIGHT : {2}\n PRICE : {3}", item.Type, item.Name, item.Weight, item.Price);
                    double value = (item.Weight) * (item.Price);
                    Console.WriteLine("TOTAL VALUE OF "+ item.Type +" IS = "+value);
                    Console.WriteLine();
                }
            }
        }
    }
}
