//----------------------------------------------------------------------
// <copyright file="Program.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace PrimeNumberRange
{
    using System;
    using System.Collections;

    /// <summary>
    /// The main class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Inputoutput inputoutput = new Inputoutput();
            Utility utility = new Utility();
            int[] obj = null;
            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("1: Prime range 2D array than only 3rd will work ");
                    Console.WriteLine("2: Prime Anagrams thna only 'Queue' will work");
                    Console.WriteLine("3: Prime Stack show");
                    Console.WriteLine("4: Prime Queue Pop");
                    Console.WriteLine("5: To add anagram  to Queue type");
                    Console.WriteLine("6: To Print anagram Queue from ");
                    Console.WriteLine("7: To calender ");
                    Console.WriteLine("8: To exit");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            inputoutput.Input();
                            break;
                        case 2:
                            obj = utility.Primeanagram();
                            break;
                        case 3:
                            utility.Show();
                            break;
                        case 4:
                            for(int i=0; i<168; i++)
                            utility.Pop();
                            break;
                        case 5:
                            inputoutput.Queue(obj);
                            break;
                        case 6:
                            for(int i=0; i<326; i++)
                            utility.Evacute();
                            break;
                        case 7:
                            inputoutput.Calenderprogram(); 
                            break;
                        case 8:
                            flag = false;
                            break;
                        default:
                            break;
                                
                    }

                }
                
            }
            catch (FormatException E)
            {
                Console.WriteLine(E.Message);
            }
            catch (Exception E1)
            {
                Console.WriteLine(E1.Message);
            }
            Console.ReadKey();
        
        
        }
    }
}
