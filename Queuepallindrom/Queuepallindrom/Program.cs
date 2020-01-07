//----------------------------------------------------------------------
// <copyright file="Program.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Queuepallindrom
{
    using System;

    /// <summary>
    /// The Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The Main method.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("1: To enqueue your string in queue at end ");
                    Console.WriteLine("2: To enqueue your string in queue at front ");
                    Console.WriteLine("3: To dequeue your string in queue at end ");
                    Console.WriteLine("4: To dequeue your string in queue at front ");
                    Console.WriteLine("5: To check Isempty or size of Queue or PRINT");
                    Console.WriteLine("6: TO check PALLINDROM ");
                    Console.WriteLine("7: To Exit a program");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Inputoutput io = new Inputoutput();
                            io.Inputatend();
                            break;
                        case 2:
                            Inputoutput io1 = new Inputoutput();
                            io1.Inputatfront();
                            break;
                        case 3:
                            Utility utility = new Utility();
                            utility.Dequeueatend();
                            break;
                        case 4:
                            Utility utility1 = new Utility();
                            utility1.Dequeueatfront();
                            break;
                        case 5:
                            Utility utility2 = new Utility();
                            utility2.Show();
                            break;
                        case 6:
                            Inputoutput io2 = new Inputoutput();
                            io2.Ispalindrom();
                                break;
                        case 7:
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
            catch (Exception E1)
            {
                Console.WriteLine(E1.Message);
            }
        }
    }
}
