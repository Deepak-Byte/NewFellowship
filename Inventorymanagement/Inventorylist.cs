//----------------------------------------------------------------------
// <copyright file="Inventorylist.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace NEW_OPPS_PROJECT.Inventorymanagement
{
    using System.Collections.Generic;

    /// <summary>
    /// This is class Inventorylist.
    /// </summary>
    public class Inventorylist
    {
        /// <summary>
        /// The inventorygroceries
        /// </summary>
        List<Inventorygrocery> inventorygroceries;
        /// <summary>
        /// Gets or sets the inventorygroceries.
        /// </summary>
        /// <value>
        /// The inventorygroceries.
        /// </value>
        internal List<Inventorygrocery> Inventorygroceries { get => inventorygroceries; set => inventorygroceries = value; }
    }
}
