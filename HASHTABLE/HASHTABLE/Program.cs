//----------------------------------------------------------------------
// <copyright file="Program.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace HASHTABLE
{
    using System;

    /// <summary>
    /// This is Program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Object[] obj=null;
            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("1: TO add number in hash table");
                    Console.WriteLine("2: TO show a hash table");
                    Console.WriteLine("3: To search a element in Hashtable");
                    Console.WriteLine("3: To Exit a program");
                    int choie = int.Parse(Console.ReadLine());
                    switch (choie)
                    {
                        case 1:
                            Inputoutput io = new Inputoutput();
                            obj = io.Input();
                            break;
                        case 2:
                            Inputoutput io1 = new Inputoutput();
                            io1.Display(obj);
                            break;
                        case 3:
                            Inputoutput io2 = new Inputoutput();
                            io2.Search(obj);
                            break;
                        case 4:
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

        }
    }
}

