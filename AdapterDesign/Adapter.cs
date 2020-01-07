//---------------------------------------------------------------------
// <copyright file="Adapter.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Structural_Design_Patterns.AdapterDesign
{
    using System;
    using System.Collections.Generic;


    /// <summary>
    /// This is Adapter class.
    /// </summary>
    public class Adapter
    {
        /// <summary>
        /// Lists the of product details.
        /// </summary>
        /// <returns></returns>
        public List<string> ListOfProductDetails()
        {
            //// Use List as generic collection type
            List<string> news = new List<string>();
            try
            {
                Console.WriteLine("Industrial News");
                Console.WriteLine("Television News");
                Console.WriteLine("Educational News");
                Console.WriteLine("Share Market News");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return news;
        }
    }
}
