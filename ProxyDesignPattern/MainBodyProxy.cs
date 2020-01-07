//---------------------------------------------------------------------
// <copyright file="MainBodyProxy.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Structural_Design_Patterns.ProxyDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is MainBodyProxy class.
    /// </summary>
    public class MainBodyProxy
    {
        /// <summary>
        /// Mains the body.
        /// </summary>
        public void MainBody()
        {
            InterfaceUserItem userItem = new LegalLimitedCommand("deepak", "dfdsfdf");
            try
            {
                userItem.ShowNameofUser("Obama");
                userItem.ShowNameofUser("Trump");
            }
            catch(Exception Exception)
            {
                throw Exception;
            }
        }
    }
}
