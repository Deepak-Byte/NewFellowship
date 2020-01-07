//---------------------------------------------------------------------
// <copyright file="ConcreteComputerFactory.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace DesignPattern.FactoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ConcreteComputerFactory : ServerFactory
    {
        public override IFactory GetFactory(string company)
        {
            switch (company)
            {
                case "laptop":
                    return new Laptop();

                case "PC":
                    return new PC();
                default:
                    throw new ApplicationException(string.Format("laptop{0} cannot found", company));
            }
        }
    }
}
