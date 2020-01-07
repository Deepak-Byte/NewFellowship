//----------------------------------------------------------------------
// <copyright file="BookDetails.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace NEW_OPPS_PROJECT.AddressBook
{
    /// <summary>
    /// This is bookdetails class.
    /// </summary>
    public class BookDetails
    {
        /// <summary>
        /// The user name
        /// </summary>
        private string userName;
        /// <summary>
        /// The user number
        /// </summary>
        private string userNumber;
        /// <summary>
        /// The user address
        /// </summary>
        private string userAddress;
        /// <summary>
        /// The ageof user
        /// </summary>
        private string ageofUser;
        /// <summary>
        /// The userserialnum
        /// </summary>
        private int userserialnum;

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        public string UserName { get => userName; set => userName = value; }
        /// <summary>
        /// Gets or sets the user number.
        /// </summary>
        /// <value>
        /// The user number.
        /// </value>
        public string UserNumber { get => userNumber; set => userNumber = value; }
        /// <summary>
        /// Gets or sets the user address.
        /// </summary>
        /// <value>
        /// The user address.
        /// </value>
        public string UserAddress { get => userAddress; set => userAddress = value; }
        /// <summary>
        /// Gets or sets the ageof user.
        /// </summary>
        /// <value>
        /// The ageof user.
        /// </value>
        public string AgeofUser { get => ageofUser; set => ageofUser = value; }
        /// <summary>
        /// Gets or sets the userserialnum.
        /// </summary>
        /// <value>
        /// The userserialnum.
        /// </value>
        public int Userserialnum { get => userserialnum; set => userserialnum = value; }
    }
}
