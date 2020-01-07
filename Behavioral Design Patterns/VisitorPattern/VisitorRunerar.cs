//---------------------------------------------------------------------
// <copyright file="VisitorRunerar.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Behavioral_Design_Patterns.VisitorPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is  class VisitorRunerar.
    /// </summary>
    public class VisitorRunerar
    {
        /// <summary>
        /// Mains the visitor.
        /// </summary>
        public void MainVisitor()
        { 
            var Mealsnonveg = new Mealsnonveg();
            var Milk = new Milk();
            var Busicut = new Busicut();

            var Promotion = new Promotion();
            Mealsnonveg.Accept(Promotion);
            Milk.Accept(Promotion);

            var Markup = new Markup();
            Busicut.Accept(Markup);

            Console.WriteLine("car => "+ Mealsnonveg.cost);
            Console.WriteLine("Plane => " + Milk.cost);
            Console.WriteLine("Truck => " + Busicut.cost);
        }
    }
}
