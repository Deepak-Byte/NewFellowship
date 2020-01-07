//----------------------------------------------------------------------
// <copyright file="BookList.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace NEW_OPPS_PROJECT.AddressBook
{
    using System.Collections.Generic;

    /// <summary>
    /// This is booklist class.
    /// </summary>
    /// <seealso cref="NEW_OPPS_PROJECT.AddressBook.BookDetails" />
    public class BookList:BookDetails
    {
        /// <summary>
        /// The book details
        /// </summary>
        List<BookDetails> bookDetails;

        /// <summary>
        /// Gets or sets the book details.
        /// </summary>
        /// <value>
        /// The book details.
        /// </value>
        public List<BookDetails> BookDetails { get => bookDetails; set => bookDetails = value; }
    }
}
