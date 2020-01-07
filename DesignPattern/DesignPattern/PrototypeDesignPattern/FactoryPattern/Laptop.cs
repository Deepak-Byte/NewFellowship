using System;
using System.Collections.Generic;
using System.Text;
//---------------------------------------------------------------------
// <copyright file="ConcreteComputerFactory.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace DesignPattern.FactoryPattern
{
    public class Laptop:IFactory
    {
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
