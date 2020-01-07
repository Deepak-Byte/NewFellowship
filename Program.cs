//---------------------------------------------------------------------
// <copyright file="Program.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Structural_Design_Patterns
{
    using Structural_Design_Patterns.AdapterDesign;
    using System;
    using Structural_Design_Patterns.FacadePattern;
    using Structural_Design_Patterns.ProxyDesignPattern;

    /// <summary>
    /// This is CLass Program.
    /// </summary>
    public class Program
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
                    //This is hoice  for iser to intracte.
                    Console.WriteLine("---------------------------WELCOME TO STRUCTURE TO PATTERN------------------------------");
                    Console.WriteLine("1: Adapter design pattern");
                    Console.WriteLine("2: Facade design pattern");
                    Console.WriteLine("3: Proxy design pattern");
                    Console.WriteLine("4: To exit a program");
                    int userchoice = int.Parse(Console.ReadLine());
                    switch (userchoice)
                    {
                        case 1:
                            Customarclass Adapter = new Customarclass();
                            Adapter.AdapterFuncation();
                            break;
                        case 2:
                            FacadePatternMain FacadePatternMain = new FacadePatternMain();
                            FacadePatternMain.FacadeMain();
                            break;
                        case 3:
                            MainBodyProxy mainmodyproxy = new MainBodyProxy();
                            mainmodyproxy.MainBody();
                            break;
                        case 4:flag = false;
                            break;
                        default:
                            Console.WriteLine("wrong input entering by you");
                            break;

                    }
                }
            }
            catch (FormatException FormatException)
            {
                Console.WriteLine(FormatException.Message);
            }
            catch (Exception Exception)
            {
                Console.WriteLine(Exception.Message);
            }
        }
    }
}
