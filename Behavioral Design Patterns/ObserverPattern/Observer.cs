//---------------------------------------------------------------------
// <copyright file="Observer.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Behavioral_Design_Patterns.ObserverPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is class Observer.
    /// </summary>
    public class Observer
    {
        /// <summary>
        /// Observers the function.
        /// </summary>
        public static void ObserverFunction()
        {
            try
            {
                //// create Instance od an CompanyClass class.
                Company company = new Company("Capgemini", 100);
                company.Attach(new Inventory("Attach"));
                company.Detach(new Inventory("Detach"));

                company.Price = 100;
                company.Price = 200;
                company.Price = 300;
                company.Price = 400;

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
