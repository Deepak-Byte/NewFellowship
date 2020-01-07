//----------------------------------------------------------------------
// <copyright file="Inventorygrocery.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace NEW_OPPS_PROJECT.Inventorymanagement
{
    /// <summary>
    /// This is class Inventorygrocery.
    /// </summary>
    public class Inventorygrocery
    {
        /// <summary>
        /// The type
        /// </summary>
        private string type;
        /// <summary>
        /// The nameofitem
        /// </summary>
        private string nameofitem;
        /// <summary>
        /// The weihtofitem
        /// </summary>
        private double weihtofitem;
        /// <summary>
        /// The priceofitem
        /// </summary>
        private double priceofitem;

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public string Type { get => type; set => type = value; }
        /// <summary>
        /// Gets or sets the nameofitem.
        /// </summary>
        /// <value>
        /// The nameofitem.
        /// </value>
        public string Nameofitem { get => nameofitem; set => nameofitem = value; }
        /// <summary>
        /// Gets or sets the weihtofitem.
        /// </summary>
        /// <value>
        /// The weihtofitem.
        /// </value>
        public double Weihtofitem { get => weihtofitem; set => weihtofitem = value; }
        /// <summary>
        /// Gets or sets the priceofitem.
        /// </summary>
        /// <value>
        /// The priceofitem.
        /// </value>
        public double Priceofitem { get => priceofitem; set => priceofitem = value; }
    }
}
