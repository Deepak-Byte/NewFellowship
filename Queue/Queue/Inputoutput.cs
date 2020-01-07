//----------------------------------------------------------------------
// <copyright file="Inputoutput.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Queue
{
    using System;
    /// <summary>
    /// The Inputouput class.
    /// </summary>
    public class Inputoutput
    {
        /// <summary>
        /// Inputs this instance.
        /// </summary>
        public void Input()
        {
            Queue u = new Queue();
            //Console.WriteLine("How many user want to diposit a money");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your amount one by one ");
            //for (int i = 0; i < number; i++)
            //{
            //    u.Add(int.Parse(Console.ReadLine()));
            //}
            Console.WriteLine("Enter your amount ");
            u.Add(int.Parse(Console.ReadLine()));

        }

        /// <summary>
        /// Withdrawals this instance.
        /// </summary>
        public void Withdrawal()
        {
            Console.WriteLine("Enter your queue number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("How much amount you want to Withdraw ");
            int reject = int.Parse(Console.ReadLine());
            Queue u = new Queue();
            u.Dequeue(num, reject);
           
        }

        /// <summary>
        /// Isempties this instance.
        /// </summary>
        public void Isempty()
        {
            Queue u1 = new Queue();
            Console.WriteLine("Number bank customar having account in bank is " + u1.Isempty()); ;
        }
    }
}
