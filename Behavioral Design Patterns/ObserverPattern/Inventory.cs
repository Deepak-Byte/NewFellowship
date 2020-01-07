//---------------------------------------------------------------------
// <copyright file="Inventory.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Behavioral_Design_Patterns.ObserverPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is class Inventory.
    /// </summary>
    /// <seealso cref="Behavioral_Design_Patterns.ObserverPattern.IInventory" />
    public class Inventory:IInventory
    {
        /// <summary>
        /// The name.
        /// </summary>
        string name;
        /// <summary>
        /// The stock
        /// </summary>
        private Stock Stock;
        /// <summary>
        /// Initializes a new instance of the <see cref="Inventory"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public Inventory(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// Gets or sets the stock.
        /// </summary>
        /// <value>
        /// The stock.
        /// </value>
        public Stock stock
        {
            get
            {
                return this.Stock;
            }

            set
            {
                this.Stock = value;
            }
        }
        /// <summary>
        /// Updates the specified stock.
        /// </summary>
        /// <param name="stock">The stock.</param>
        public void Update(Stock stock)
        {
            try
            {
                Console.WriteLine("Placed position {0} {1}'s" + "change to {2 : C}", this.name, this.stock.Symbol, this.stock.Price);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
