//----------------------------------------------------------------------
// <copyright file="Stockmanagament.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace NEW_OPPS_PROJECT.StockAccount
{
    using System.Collections.Generic;
    /// <summary>
    /// Stock managament class.
    /// </summary>
    public class Stockmanagament
    {
        /// <summary>
        /// The inventorystocks
        /// </summary>
        List<Stocks> inventorystocks;
        /// <summary>
        /// Gets or sets the inventorygroceries.
        /// </summary>
        /// <value>
        /// The inventorygroceries.
        /// </value>
        public List<Stocks> Inventorygroceries { get => inventorystocks; set => inventorystocks = value; }
    }
}
