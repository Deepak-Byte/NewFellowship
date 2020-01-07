//----------------------------------------------------------------------
// <copyright file="Queue.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Queue
{
    using System;

    /// <summary>
    /// The Queue class.
    /// </summary>
    public class Queue
    {
        static Node head;
        /// <summary>
        /// This Add method.
        /// </summary>
        /// <param name="data"></param>
        public void Add(int data)
        {
            Node node = new Node();
            node.data = data;
            node.next = null;
            if (head == null)
            {
                head = node;
                Console.WriteLine("First element is " + node.data);
            }
            else
            {
                Node n = head;
                while (n.next != null)
                {
                    n = n.next;
                }
                n.next = node;
            }
            Console.WriteLine("The number added is " + data);
        }

        /// <summary>
        /// The Show methhod.
        /// </summary>
        public void Show()
        {
            Node n = head;
            while (n.next != null)
            {
                Console.WriteLine(n.data);
                n = n.next;
            }
            Console.WriteLine(n.data);
        }

        /// <summary>
        /// The Dequeue class.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="data"></param>
        public void Dequeue(int num, int data)
        {

            Node n = head;
            Node n1 = null;
            for (int i = 0; i < num - 2; i++)
            {
                n = n.next;
            }
            n1 = n.next;
            n.next = n1.next;
            Console.WriteLine("Person queue was deleted is " + num);
            if (data <= n1.data)
            {
                n1.data = n1.data - data;
                Console.WriteLine("Amount was balanced is " + n1.data);
            }
            else
            {
                Console.WriteLine("Don't have sifficient balanced");
            }
        }

        /// <summary>
        /// The Isempty method.
        /// </summary>
        /// <returns></returns>
        public int Isempty()
        {
            Node n = head;
            int count = 0;
            while (n != null)
            {
                n = n.next;
                count++;
            }
            
            return count;
        }
    }
}
