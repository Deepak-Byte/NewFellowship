//---------------------------------------------------------------------
// <copyright file="Client.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Structural_Design_Patterns.AdapterDesign
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is client class.
    /// </summary>
    /// <seealso cref="Structural_Design_Patterns.AdapterDesign.IAdapter" />
    public class Client:IAdapter
    {
        //public List<string> GetProductDetails()
        //{

        //}        
        /// <summary>
        /// The getproductdetails
        /// </summary>
        /// <returns></returns>
        public List<string> Getproductdetails()
        {
            //// Create Instance of an AdapterClass classs
            Adapter adapter = new Adapter();
            return adapter.ListOfProductDetails();
        }
    }
}
