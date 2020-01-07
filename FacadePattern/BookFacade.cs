//---------------------------------------------------------------------
// <copyright file="BookFacade.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Structural_Design_Patterns.FacadePattern
{
    /// <summary>
    /// This is class BookFacade.
    /// </summary>
    public class BookFacade
    {
        /// <summary>
        /// The booksname
        /// </summary>
        BookName booksname;
        /// <summary>
        /// The booktype
        /// </summary>
        Booktype booktype;
        /// <summary>
        /// The bookprice
        /// </summary>
        Bookprice bookprice;
        /// <summary>
        /// Initializes a new instance of the <see cref="BookFacade"/> class.
        /// </summary>
        public BookFacade()
        {
            booksname = new BookName();
            booktype = new Booktype();
            bookprice = new Bookprice();
        }
        //'operation in facade class        
        /// <summary>
        /// Bookgets this instance.
        /// </summary>
        public void Bookget()
        {
            booksname.NovelBooks();
            booktype.SmallBook();
            bookprice.LowBookPrice();
        }
        // 'Operation' in Facade class        
        /// <summary>
        /// Booksets this instance.
        /// </summary>
        public void Bookset()
        {
            booksname.TechnicalBook();
            booktype.LargeBook();
            bookprice.HighBookPrice();
        }
    }
}
