//---------------------------------------------------------------------
// <copyright file="FacadePatternMain.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Structural_Design_Patterns.FacadePattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is class FacadePatternMain.
    /// </summary>
    public class FacadePatternMain
    {
        /// <summary>
        /// Facades the main.
        /// </summary>
        public void FacadeMain()
        {
            BookFacade bookfacade = new BookFacade();
            Console.WriteLine("\n---------------Books Details with cheap review----------------\n");
            bookfacade.Bookget();


            Console.WriteLine("\n---------------Book Details with goog review----------------\n");
            bookfacade.Bookset();
            Console.ReadLine();
        }
    }
}
