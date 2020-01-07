//---------------------------------------------------------------------
// <copyright file="Customarclass.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Structural_Design_Patterns.AdapterDesign
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is clas customer.
    /// </summary>
    public class Customarclass
    {
        /// <summary>
        /// This is AdapterFuncation method.
        /// </summary>
        public void AdapterFuncation()
        {
            try
            {
                IAdapter adapter = new Client();
                foreach (string product in adapter.Getproductdetails())
                {
                    Console.WriteLine(product);
                }
                Console.WriteLine();
            }
            catch (Exception Exception)
            {
                Console.WriteLine(Exception.Message);
            }
        }
    }
}
