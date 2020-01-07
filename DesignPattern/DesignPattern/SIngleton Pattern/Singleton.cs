//---------------------------------------------------------------------
// <copyright file="Singleton.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace DesignPattern.SIngleton_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This is class Singleton.
    /// </summary>
    public class Singleton
    {
        /// <summary>
        /// Singletonusers this instance.
        /// </summary>
        public void Singletonuser()
        {
            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("1: Eager initialization");
                    Console.WriteLine("2: Lazy Initialization");
                    Console.WriteLine("3: Thread Safe Singleton");
                    Console.WriteLine("4: Static block initialization");
                    Console.WriteLine("5: Enum Singleton");
                    Console.WriteLine("6:To Exit a Program");
                    int userchoice = int.Parse(Console.ReadLine());
                    switch (userchoice)
                    {
                        case 1:
                            EagerSingleton singleton = EagerSingleton.Getsingleton;
                            singleton.Yourinformation("\nkaku ki maka ki jay\n");

                            EagerSingleton singleton1 = EagerSingleton.Getsingleton;
                            singleton1.Yourinformation("\nkaku ki bahin ki jay\n");
                            break;
                        case 2:
                            Singletons singleton2 = Singletons.Getsingleton;
                            singleton2.Yourinformation("\npakau mama ki jay\n");

                            Singletons singleton3 = Singletons.Getsingleton;
                            singleton3.Yourinformation("\njay jay maharashtra majha\n");
                            break;
                        case 3:
                            Parallel.Invoke(() => firstmethod(),()=> secondmethod());
                            break;
                        case 4:
                            //Sataticblockintialization sataticblockintialization = new Sataticblockintialization();
                            //sataticblockintialization.Yourinformation("hello how are you");
                            break;
                        case 5:
                                Console.WriteLine("\nThis are the food item :\t{0}\t\t{1}\t{2}",fooditem.RohanMasalchhas,fooditem.KamalTea,fooditem.RoshiCoffe);
                                Console.WriteLine("\nThis is the enum value :{0}\t{1}\t{2} ",(int)fooditem.SayaliNoodle, (int)fooditem.MathurBiryani, (int)fooditem.NanakuColdwater);
                            break;
                        case 6:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Wrong Input Trying To Entering");
                            break;
                    }
                }

            }catch(FormatException FormatException)
            {
                Console.WriteLine(FormatException.Message);
            }
        }

        private static void secondmethod()
        {
            Singletons singleton4 = Singletons.Getsingleton;
            singleton4.Yourinformation("\njay jay maharashtra majha\n");
        }

        private static void firstmethod()
        {
            Singletons singleton5 = Singletons.Getsingleton;
            singleton5.Yourinformation("\npakau mama ki jay\n");
        }
        public enum fooditem
        {
            RohanMasalchhas,
            KamalTea,
            RoshiCoffe,
            NanakuColdwater = 11,
            MathurBiryani = 22,
            SayaliNoodle = 33
        }
    }
}
