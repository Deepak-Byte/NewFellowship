//---------------------------------------------------------------------
// <copyright file="Company.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Behavioral_Design_Patterns.ObserverPattern
{
    /// <summary>
    /// This is calss Company.
    /// </summary>
    /// <seealso cref="Behavioral_Design_Patterns.ObserverPattern.Stock" />
    public class Company:Stock
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Company"/> class.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        /// <param name="price">The price.</param>
        public Company(string symbol, int price) : base(symbol, price)
        {
        }
    }
}
