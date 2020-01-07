//---------------------------------------------------------------------
// <copyright file="BookName.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Structural_Design_Patterns.FacadePattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is BookName class.
    /// </summary>
    public class BookName
    {
        /// <summary>
        /// Novels the books.
        /// </summary>
        public void NovelBooks()
        {
            Console.WriteLine("This is novel book");
        }
        /// <summary>
        /// Technicals the book.
        /// </summary>
        public void TechnicalBook()
        {
            Console.WriteLine("This is Thechanical Book");
        }
    }
    /// <summary>
    /// This is class Booktype.
    /// </summary>
    public class Booktype
    {
        /// <summary>
        /// Smalls the book.
        /// </summary>
        public void SmallBook()
        {
            Console.WriteLine("Small size book");
        }
        /// <summary>
        /// Larges the book.
        /// </summary>
        public void LargeBook()
        {
            Console.WriteLine("Large size Book");
        }
    }
    /// <summary>
    /// This is class Bookprice
    /// </summary>
    public class Bookprice
    {
        /// <summary>
        /// Lows the book price.
        /// </summary>
        public void LowBookPrice()
        {
            Console.WriteLine("Books Price below 500 Rupees");
        }
        /// <summary>
        /// Highes the book price.
        /// </summary>
        public void HighBookPrice()
        {
            Console.WriteLine("Books Price bitween 500 too 1000 Rupees");
        }
    }
}
