//----------------------------------------------------------------------
// <copyright file="Stocks.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace NEW_OPPS_PROJECT.StockAccount
{
    /// <summary>
    /// This is class Stocks.
    /// </summary>
    public class Stocks
    {
        /// <summary>
        /// The sharename
        /// </summary>
        private string sharename;
        /// <summary>
        /// The numberofshare
        /// </summary>
        private int numberofshare;
        /// <summary>
        /// The shareprice
        /// </summary>
        private int shareprice;

        /// <summary>
        /// Gets or sets the sharename.
        /// </summary>
        /// <value>
        /// The sharename.
        /// </value>
        public string Sharename { get => sharename; set => sharename = value; }
        /// <summary>
        /// Gets or sets the numberofshare.
        /// </summary>
        /// <value>
        /// The numberofshare.
        /// </value>
        public int Numberofshare { get => numberofshare; set => numberofshare = value; }
        /// <summary>
        /// Gets or sets the shareprice.
        /// </summary>
        /// <value>
        /// The shareprice.
        /// </value>
        public int Shareprice { get => shareprice; set => shareprice = value; }
    }
}
