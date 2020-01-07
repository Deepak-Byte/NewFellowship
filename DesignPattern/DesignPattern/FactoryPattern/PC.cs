//---------------------------------------------------------------------
// <copyright file="PC.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace DesignPattern.FactoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is class PC.
    /// </summary>
    /// <seealso cref="DesignPattern.FactoryPattern.IFactory" />
    public class PC:IFactory
    {
        /// <summary>
        /// LaptopInformation method have the details about the lapop.
        /// </summary>
        /// <param name="brand">brand is the name of computer type or laptop type.</param>
        public void LaptopInformation(string brand)
        {
            try
            {
                Console.WriteLine("The name of the laptop " + brand);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
