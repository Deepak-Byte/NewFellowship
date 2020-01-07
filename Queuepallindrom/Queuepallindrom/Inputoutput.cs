
//----------------------------------------------------------------------
// <copyright file="Inputoutput.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Queuepallindrom
{
    using System;

    /// <summary>
    /// The  Inputoutput class.
    /// </summary>
    public class Inputoutput
    {
        /// <summary>
        /// Inputatends this instance.
        /// </summary>
        public void Inputatend()
        {
            Utility utility = new Utility();
            Console.WriteLine("Enter your string");
            string word = Console.ReadLine();
            //char[] ch = word.ToCharArray();
            utility.Enqueueatend(word);

        }

        /// <summary>
        /// Inputatfronts this instance.
        /// </summary>
        public void Inputatfront()
        {
            Utility utility = new Utility();
            Console.WriteLine("Enter your string");
            string word = Console.ReadLine();
            utility.Enqueueatfront(word);
        }

        /// <summary>
        /// Ispalindroms this instance.
        /// </summary>
        public void Ispalindrom()
        {
            Console.WriteLine("Enter the index of string who's pallindrom you want to check");
            int index = int.Parse(Console.ReadLine());
            Utility utility = new Utility();
            utility.Check(index);
            //if(b == true)
            //    Console.WriteLine("The string you are searching for is pallindrom");
            //else
            //    Console.WriteLine("The string you are searching for is not pallindrom");
        }
    }
}
