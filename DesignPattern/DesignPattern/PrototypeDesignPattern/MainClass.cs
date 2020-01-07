//---------------------------------------------------------------------
// <copyright file="MainClass.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace DesignPattern.PrototypeDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is class MainClass.
    /// </summary>
    public class MainClass
    {
        /// <summary>
        /// Thsi is method.
        /// </summary>
        public void Mainofprotoype()
        {
            ////Making fix class to boject.
            FixEmploye fixEmploye = new FixEmploye();
            fixEmploye.Name = "Sam";
            fixEmploye.Age = 25;
            fixEmploye.EmploymentType = "Permanent";
            ////fix em[ployee calling
            FixEmploye permanettype = (FixEmploye)fixEmploye.Clone();
            permanettype.Name = "Tom";
            permanettype.Age = 30;

            Console.WriteLine("Permanent Employee Details\n");
            Console.WriteLine("Name of employee: {0}\n; Ageof employee: {1};\n Employment Type: {2}\n", fixEmploye.Name, fixEmploye.Age, fixEmploye.EmploymentType);

            Console.WriteLine("Cloned Permanent Employee Details\n");
            Console.WriteLine("Name of employee: {0};\n Age of employee: {1};\n Employment Type: {2}\n", permanettype.Name, permanettype.Age, permanettype.EmploymentType);

            Console.ReadLine();
        }
    }
}
