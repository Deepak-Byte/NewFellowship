//---------------------------------------------------------------------
// <copyright file="IInventory.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Behavioral_Design_Patterns.ObserverPattern
{
    /// <summary>
    /// This is interface IInventory.
    /// </summary>
    public interface IInventory
    {
        /// <summary>
        /// Updates the specified stock.
        /// </summary>
        /// <param name="stock">The stock.</param>
        void Update(Stock stock);
    }
}
