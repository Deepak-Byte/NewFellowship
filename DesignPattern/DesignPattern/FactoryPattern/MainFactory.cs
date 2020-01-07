//---------------------------------------------------------------------
// <copyright file="MainFactory.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace DesignPattern.FactoryPattern
{
    using CsvHelper;
    //using DesignPattern.FactoryDesignPattern;
    using System;
    using System.Collections.Generic;
    using System.Text;
    //using IFactory = DesignPattern.FactoryDesignPattern.IFactory;
    public class MainFactory
    {
        public static void Factory()
        {
            try
            {
                // create Instance of ServerFactoryClass class.
                ServerFactory serverFactory = new ConcreteComputerFactory();

                IFactory laptop = serverFactory.GetFactory("laptop");
                laptop.LaptopInformation("HP_Laptop");

                IFactory pc = serverFactory.GetFactory("PC");
                //// call LaptopInformation function of the IFactory interface.
                pc.LaptopInformation("HCL_PC");

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
