//---------------------------------------------------------------------
// <copyright file="MobileEmploye.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace DesignPattern.PrototypeDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// This is class MobileEmploye.
    /// </summary>
    /// <seealso cref="DesignPattern.PrototypeDesignPattern.IEmployee" />
    public class MobileEmploye: IEmployee
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        public int Age { get; set; }
        /// <summary>
        /// Gets or sets the type of the employment.
        /// </summary>
        /// <value>
        /// The type of the employment.
        /// </value>
        public string EmploymentType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

        // Implement shallow cloning method
        public IEmployee Clone()
        {
            // Shallow Copy 
            return this.MemberwiseClone() as IEmployee;

            // Deep Copy
            // Implement Memberwise clone method for every reference type object 
            // return ..
        }
    }
}
