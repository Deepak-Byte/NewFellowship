//---------------------------------------------------------------------
// <copyright file="Program.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Behavioral_Design_Patterns
{
    using System;
    using Behavioral_Design_Patterns.MediatorDesignPattern;
    using Behavioral_Design_Patterns.VisitorPattern;
    using Observer = ObserverPattern.Observer;


    /// <summary>
    /// This is  class Program.
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
                    Console.WriteLine("-------------------------WELCOME TO BEHAVIORAL DESIGN PATERN---------------------------");
                    Console.WriteLine("1: OBSERVER DESIGN PATERN ");
                    Console.WriteLine("2: VISITOR DESIGN PATERN ");
                    Console.WriteLine("3: MEDIATOR DESIGN PATERN  ");
                    Console.WriteLine("4: TO EXIT PROGRAM");
                    int userinput = int.Parse(Console.ReadLine());
                    switch (userinput)
                    {
                        case 1:
                            //Program program = new Program();
                            //program.Observer();
                            Observer.ObserverFunction();
                            break;
                        case 2:
                            //Observer observerkeliye = new Observer();
                            VisitorRunerar VisitorRunerar = new VisitorRunerar();
                            VisitorRunerar.MainVisitor();
                            break;
                        case 3:
                            MediatorMain mediatorMain = new MediatorMain();
                            mediatorMain.MediatorMainmethod();
                            break;
                        case 4:

                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Wrong Input Entering");
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

        //public void Observer()
        //{
        //    //MyTopics mytopics = new MyTopics();
        //    //mytopics.Mytopicsare("kamlesh");
        //    //Console.WriteLine("---------------------For Subscribe Customar-----------------");
        //    //Customar customar = new Customar("Customar Hare");
        //    //mytopics.Subscribe(customar);

        //    //Customar customar1 = new Customar("Customar There");
        //    //mytopics.Subscribe(customar1);


        //    //Console.WriteLine("---------------------For Unsubscribe Customar-----------------");
        //    //mytopics.Unsubscribe(customar1);

        //    //Customar customar2 = new Customar("Customar There");
        //    //mytopics.Subscribe(customar2);

        //    Console.ReadLine();
        //}
    }
}
