//----------------------------------------------------------------------
// <copyright file="Queue.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Queue
{
    using System;

    /// <summary>
    /// The Program class.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("1: For Queue operation ");
                    Console.WriteLine("2: For Bank statment copy operation ");
                    Console.WriteLine("3: For Dequeue operation ");
                    Console.WriteLine("4: For check Empty ");
                    Console.WriteLine("5: For exit program ");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Inputoutput io = new Inputoutput();
                            io.Input();
                            break;
                        case 2:
                            Queue u = new Queue();
                            u.Show();
                            break;
                        case 3:
                            Inputoutput io1 = new Inputoutput();
                            io1.Withdrawal();
                            break;
                        case 4:
                            Inputoutput io2 = new Inputoutput();
                            io2.Isempty();
                            break;
                        case 5:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Wrong input enterd");
                            break;
                    }
                }
            }
            catch (FormatException E)
            {
                Console.WriteLine(E.Message);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
        }
    }
}
