//----------------------------------------------------------------------
// <copyright file="Inputoutput.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace PrimeNumberRange
{
    using System;
    /// <summary>
    /// The Inputoutput class.
    /// </summary>
    public class Inputoutput
    {
        /// <summary>
        /// Inputs this instance.
        /// </summary>
        public void Input()
        {
            Utility pm = new Utility();
            int start = 2;
            int end = 100;
            for (int i = 0; i < 10; i++)
            {
                pm.Prime(start, end);
                start = start + 100;
                end = end + 100;
            }
        }


        public void Queue(int[] obj)
        {
            int k = 0;
            int[] array = null;
            int[] a = new int[168];
            for (int i = 2; i < 1000; i++)
            {
                int count = 0;
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    a[k] = i;
                    //Console.WriteLine(i+ " "+k);
                    k++;
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    PrimeWithAnagram(a[i], a[j]);
                    //Console.WriteLine(a[i]);
                }
            }
        }
        public void PrimeWithAnagram(int num1, int num2)
        {
            int count = 0;
            Utility utility = new Utility();
            string str1 = Convert.ToString(num1);
            string str2 = Convert.ToString(num2);

            char[] c1 = str1.ToCharArray();
            char[] c2 = str2.ToCharArray();
            Array.Sort(c1);
            Array.Sort(c2);
            string my1 = new string(c1);
            string my2 = new string(c2);
            if (my1.Equals(my2))
            {
                  Console.WriteLine(str1 + " " + str2);
                  utility.Add(num1);
            }
        }

        public void Calenderprogram()
        {
            Utility utility = new Utility();
            Console.WriteLine("Enter The Year ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Month");
            int month = int.Parse(Console.ReadLine());
            utility.Calender(year, month);
        }

    }
}
