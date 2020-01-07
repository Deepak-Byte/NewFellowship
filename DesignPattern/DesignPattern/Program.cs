//---------------------------------------------------------------------
// <copyright file="Program.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace DesignPattern
{
    using System;
    using DesignPattern.SIngleton_Pattern;
    using DesignPattern.FactoryPattern;
    //using DesignPattern.ProtoytpePattern;
    using DesignPattern.PrototypeDesignPattern;

    /// <summary>
    /// Thhis is class Program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// This is main method.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            object obj = new object();
            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("--------------------WELCOME TO CREATIONAL DESIGN PATTERN--------------------");
                    Console.WriteLine("1: FOR SINAGLETON PATTERN");
                    Console.WriteLine("2: FOR FACTORY PATTERN");
                    Console.WriteLine("3: FOR PROTOTYPE PATTERN");
                    Console.WriteLine("4: FOR EXIT PROGRAM");
                    int userinput = int.Parse(Console.ReadLine());
                    switch (userinput)
                    {
                        case 1:  Singleton Singleton = new Singleton();
                                 Singleton.Singletonuser();
                                 break;
                        case 2:
                            MainFactory MainFactory = new MainFactory();
                            MainFactory.Factory();
                            break;
                        case 3:
                            MainClass mainclass = new MainClass();
                            mainclass.Mainofprotoype();
                            break;
                        case 4:
                            break;
                        default:
                            Console.WriteLine("Trying To Enter Wrong Input");
                            break;
                    }
                }
            }
            catch (FormatException FormatException)
            {
                Console.WriteLine("YOU ARE NOT ENERING CORRECT FORMAT INPUT " + FormatException.Message);
            }
        }
    }
}
