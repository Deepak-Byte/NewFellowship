//---------------------------------------------------------------------
// <copyright file="Laptop.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace DesignPattern.FactoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is class Laptop.
    /// </summary>
    /// <seealso cref="DesignPattern.FactoryPattern.IFactory" />
    public class Laptop:IFactory
    {/// <summary>
     /// This is LaptopInformation Mehtod.
     /// </summary>
     /// <param name="brand"></param>
        public void LaptopInformation(string brand)
        {
            try
            {
                Console.WriteLine("The name of the laptop " + brand);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
