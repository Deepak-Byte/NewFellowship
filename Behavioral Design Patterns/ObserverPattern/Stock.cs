//---------------------------------------------------------------------
// <copyright file="Stock.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Behavioral_Design_Patterns.ObserverPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is class Stock.
    /// </summary>
    public abstract class Stock
    {
        /// <summary>
        /// The symbol
        /// </summary>
        private string symbol;
        /// <summary>
        /// The price
        /// </summary>
        private int price;
        /// <summary>
        /// The inventories
        /// </summary>
        private List<IInventory> Inventories = new List<IInventory>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Stock"/> class.
        /// </summary>
        /// <param name="symbol1">The symbol1.</param>
        /// <param name="price1">The price1.</param>
        public Stock(string symbol1, int price1)
        {
            this.symbol = symbol1;
            this.price = price1;
        }
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public int Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (this.price != value)
                {
                    this.price = value;
                    this.Notify();
                }
            }
        }
        /// <summary>
        /// Gets the symbol.
        /// </summary>
        /// <value>
        /// The symbol.
        /// </value>
        public string Symbol
        {
            get { return this.symbol; }
        }
        /// <summary>
        /// Attaches the specified inventory interface.
        /// </summary>
        /// <param name="inventoryInterface">The inventory interface.</param>
        public void Attach(IInventory inventoryInterface)
        {
            try
            {
                this.Inventories.Add(inventoryInterface);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Detaches the specified interface.
        /// </summary>
        /// <param name="interface">The interface.</param>
        public void Detach(Inventory @interface)
        {
            try
            {
                this.Inventories.Remove(@interface);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Notifies this instance.
        /// </summary>
        public void Notify()
        {
            try
            {
                foreach (IInventory @interface in this.Inventories)
                {
                    @interface.Update(this);
                }

                Console.WriteLine(" ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
