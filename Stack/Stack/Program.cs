//----------------------------------------------------------------------
// <copyright file="Program.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Stack
{
    using System;

    /// <summary>
    /// The Program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Input input = new Input();
            Utility utility = new Utility();
            //Actual program is start from here////
            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("1 for push");
                    Console.WriteLine("2 for pop");
                    Console.WriteLine("3 for peak");
                    Console.WriteLine("4 for show");
                    //Console.WriteLine("5 for check");
                    Console.WriteLine("5 for exit");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            input.Inputstack();
                            break;
                        case 2:
                            utility.Listlength();
                            break;
                        case 3:
                            utility.Peak();
                            break;
                        case 4:
                            utility.Show();
                            break;
                        case 5:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Wrong input Enterd");
                            break;
                    }

                }
            }
            catch (FormatException formatexception)
            {
                Console.WriteLine(formatexception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            Console.ReadKey();
        }
    }
}
