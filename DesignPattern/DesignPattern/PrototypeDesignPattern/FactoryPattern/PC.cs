using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryPattern
{
    public class PC:IFactory
    {
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
