//---------------------------------------------------------------------
// <copyright file="CommonCommnad.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Structural_Design_Patterns.ProxyDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is class of commonCommand.
    /// </summary>
    /// <seealso cref="Structural_Design_Patterns.ProxyDesignPattern.InterfaceUserItem" />
    public class CommonCommnad : InterfaceUserItem
    {
        /// <summary>
        /// Shows the nameof user.
        /// </summary>
        /// <param name="name">The name.</param>
        public void ShowNameofUser(string name)
        {
            Console.WriteLine("hello here I am using C# my name is "+name);
        }
    }
}
