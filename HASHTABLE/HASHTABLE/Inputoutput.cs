//----------------------------------------------------------------------
// <copyright file="Inputoutput.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace HASHTABLE
{
    using System;
    using System.Collections;

    /// <summary>
    /// This is Inputoutput class.
    /// </summary>
    public class Inputoutput
    {
        /// <summary>
        /// Inputs this instance.
        /// </summary>
        /// <returns></returns>
        public Object[] Input()
        {
            object[] obj = new object[11];
            try
            {
                //Hash table defining .
                Hashtable ht = new Hashtable();

                //Object defining of legth 11. 
                

                //Creating a linked list for each position of object.
                for (int i = 0; i < 11; i++)
                {
                    obj[i] = new Hashlinkedlist();
                }
                //User input to enter number of input.
                Console.WriteLine("Enter how much number you want to add");
                int num = int.Parse(Console.ReadLine());

                //Array of lentgh as par user input.
                int[] a = new int[num];

                //inserting  each element one by one in array 'a'.
                Console.WriteLine("Enter your element one by one");
                for (int i = 0; i < num; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }
                //Passing array into hashtable linked list. 
                for (int i = 0; i < a.Length; i++)
                {
                    int remaminder = a[i] % 11;
                    Hashlinkedlist hlink = (Hashlinkedlist)obj[remaminder];
                    hlink.Add(a[i]);
                }
                
            }
            catch (FormatException E)
            {
                Console.WriteLine(E.Message);
            }
            catch(Exception E1)
            {
                Console.WriteLine(E1.Message);
            }
            return obj;
        }

        /// <summary>
        /// Displays the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        public void Display(Object [] obj)
        {
            for(int i=0; i< obj.Length; i++)
            {
                Hashlinkedlist hlink = (Hashlinkedlist)obj[i];
                Console.Write("Slot " + "  " + i + "  -> ");
                hlink.Show();
                
            }
        }

        /// <summary>
        /// Searches the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        public void Search(Object [] obj)
        {
            //Hashlinkedlist hlink = new Hashlinkedlist();
            Console.WriteLine("Enter your searching number");
            int data = int.Parse(Console.ReadLine());

            int remainder = data % 11;
            Hashlinkedlist hlink = (Hashlinkedlist)obj[remainder];
            hlink.Search(data);
        }
    }
}
