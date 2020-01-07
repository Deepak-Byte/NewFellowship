//---------------------------------------------------------------------
// <copyright file="IAdapter.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Structural_Design_Patterns.AdapterDesign
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is IAdapter Interface.
    /// </summary>
    public interface IAdapter
    {
        /// <summary>
        /// The getproductdetails
        /// </summary>
        List<string> Getproductdetails();

        
    }
}
