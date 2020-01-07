//---------------------------------------------------------------------
// <copyright file="ServerFactory.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace DesignPattern.FactoryPattern
{
    using CsvHelper;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Thsi is class ServerFactory.
    /// </summary>
    public abstract class ServerFactory
    {
        /// <summary>
        /// Gets the factory.
        /// </summary>
        /// <param name="company">The company.</param>
        /// <returns></returns>
        public abstract IFactory GetFactory(string company);
    }
}
