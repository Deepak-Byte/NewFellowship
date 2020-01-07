//---------------------------------------------------------------------
// <copyright file="Visitor.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Behavioral_Design_Patterns.MediatorDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is class Visitor.
    /// </summary>
    /// <seealso cref="Behavioral_Design_Patterns.MediatorDesignPattern.AbstractVisitor" />
    public class Visitor : AbstractVisitor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Visitor"/> class.
        /// </summary>
        /// <param name="names">The names.</param>
        public Visitor(string names)
        {
            this.name = names;
        }
        /// <summary>
        /// Recesives the specified SMS.
        /// </summary>
        /// <param name="sms">The SMS.</param>
        public override void Recesive(string sms)
        {
            Console.WriteLine("{0} <== {1} ", name, sms);
        }
    }
}
