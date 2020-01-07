//---------------------------------------------------------------------
// <copyright file="IFactory.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace DesignPattern.FactoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is IFactory class.
    /// </summary>
    public interface IFactory
    {
            /// <summary>
            /// LaptopInformation method have the details about the lapop.
            /// </summary>
            /// <param name="brand">brand is the name of computer type or laptop type.</param>
            void LaptopInformation(string brand);
     
    }
}
