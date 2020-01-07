//----------------------------------------------------------------------
// <copyright file="Userpalyingzone.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace NEW_OPPS_PROJECT.Cliniquemanagement
{
    using System;

    /// <summary>
    /// This is class Clinicinputoutput.
    /// </summary>
    public class Userpalyingzone
    {
        /// <summary>
        /// Docotors this instance is method.
        /// </summary>

        //public Random Randomizer;

        string[] Cards = { "Club_King", "Club_Queen", "Club_Jack", "Club 1", "Club 2", "Club 3", "Club 4", "Club 5", "Club 6","Club 7", "Club 8", "Club 9", "Club 10",

                           "Diamonds_King", "Diamonds_Queen", "Diamonds_Jack", "Diamonds 1", "Diamonds 2", "Diamonds 3" ,"Diamonds 4", "Diamonds 5","Diamonds 6", "Diamonds 7", "Diamonds 8", "Diamonds 9", "Diamonds 10",

                           "Hearts_King", "Hearts_Queen", "Hearts_Jack", "Hearts 1", "Hearts 2", "Hearts 3", "Hearts 4", "Hearts 5", "Hearts 6", "Hearts 7", "Hearts 8", "Hearts 9", "Hearts 10",

                           "Spades_King", "Spades_Queen", "Spades_Jack", "Spades 1", "Spades2", "Spades 3", "Spades 4", "Spades 5", "Spades 6", "Spades 7", "Spades 8", "Spades 9", "Spades 10" };

        /// <summary>
        /// This is method of Docotor.
        /// </summary>
        public void Docotor()
        {
            try
            {
                Console.WriteLine("------------------------------Welcome to card game--------------------------------");

                //Generating random number every time. 
                int[] cardpool = new int[52];
                Random random = new Random();
                int mtp;
                for (int i = 0; i < cardpool.Length; i++)
                {
                    mtp = random.Next(53);
                    while (boolcompare(mtp, cardpool))
                    {
                        mtp = random.Next(53);
                    }
                    cardpool[i] = mtp;
                }
                for (int i = 0; i < 52; i++)
                {

                }
                char choice;
                do
                {
                    Dispaly(cardpool);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("DO YOU AGAIN WANT TO PLAY THAN PRESS 'Y' || 'y' : ");
                    choice = char.Parse(Console.ReadLine());
                } while (choice == 'y' || choice == 'Y');

                Console.WriteLine();
            }
            catch (FormatException FormatException)
            {
                Console.WriteLine(FormatException.Message);
            }
            Console.ReadKey();
        }

        /// <summary>
        /// This is method to campare generated number if allready ganerated.
        /// </summary>
        /// <param name="mtp"></param>
        /// <param name="cardpool"></param>
        /// <returns></returns>
        private bool boolcompare(int mtp, int[] cardpool)
        {
            foreach (var item in cardpool)
            {
                if (item == mtp)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// This is method to dispaly a player.
        /// </summary>
        /// <param name="cardpool"></param>
        public void Dispaly(int []cardpool)
        {
            Console.WriteLine("FIRST PALYER CARDS : ");
            for (int i = 0; i < 9; i++)
            {
                int k = cardpool[i];
                Console.Write(Cards[k]+"-> ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("SCEOND PALYER CARDS : ");
            for (int i = 9; i < 18; i++)
            {
                int k = cardpool[i];
                Console.Write(Cards[k] + "-> ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("THIRD PALYER CARDS : ");
            for (int i = 18; i < 27; i++)
            {
                int k = cardpool[i];
                Console.Write(Cards[k] + "-> ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("FOUR PALYER CARDS : ");
            for (int i = 27; i < 36; i++)
            {
                int k = cardpool[i];
                Console.Write(Cards[k] + "-> ");
            }
        }

        /**************************************************************TO dispaly random number generated**************************************/

        //private void Print(int[] cardpool)
        //{
        //    int[] palyer1 = new int[9];
        //    int[] palyer2 = new int[9];
        //    int[] palyer3 = new int[9];
        //    int[] palyer4 = new int[9];

        //    for (int i = 0; i < 9; i++)
        //    {
        //        palyer1[i] = cardpool[i];
        //        Console.WriteLine(palyer1[i]);
        //    }
        //    Console.WriteLine();
        //    for (int j = 9; j < 18; j++)
        //    {
        //        palyer2[j-9] = cardpool[j];
        //        Console.WriteLine(palyer1[j-9]);
        //    }
        //    Console.WriteLine();
        //    for (int k = 18; k < 27; k++)
        //    {
        //        palyer3[k-18] = cardpool[k];
        //        Console.WriteLine(palyer1[k-18]);
        //    }
        //    Console.WriteLine();
        //    for (int l = 27; l < 36; l++)
        //    {
        //        palyer4[l-27] = cardpool[l];
        //        Console.WriteLine(palyer1[l-27]);
        //    }
        //}

    }
}
