//----------------------------------------------------------------------
// <copyright file="Utility.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace PrimeNumberRange
{
    using System;
    using System.Collections;

    /// <summary>
    /// This is Utility.
    /// </summary>
    public class Utility
    {
        static Node head;
        private int[] element;
        private int front;
        private int rear;
        private int max;
        static int[,] calendar = new int[6, 7];
        /*******************************************Prime range in 2D Array***********************************************/

        /// <summary>
        /// The prime method.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public void Prime(int start, int end)
        {
            int count = 0;
            int count1 = 0;
            Console.Write(start + " to " + end+"->");
            for (int i = start; i < end; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    count = 0;
                    count1++;
                    Add(i);
                    Console.Write(i+" ");
                }
                else
                {
                    count = 0;
                }
                
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        /**************************************************Prime Aanagram******************************/
        /// <summary>
        /// The primeanagram.
        /// </summary>
        public int[] Primeanagram()
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
                     array = PrimeWithAnagram(a[i], a[j]);
                    //Console.WriteLine(a[i]);
                }
            }
            
            return array;
        }

        /*************************************Prime With Anagram************************************************/
        /// <summary>
        /// The prime with anagram.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        public int[] PrimeWithAnagram(int num1, int num2)
        {
            int count = 0;
            int[] array = new int[168];
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
            }
            return array;
        }
        /************************************************Linked list*******************************************/
        /// <summary>
        /// The Add method.
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
        }
        /**************************************************Show******************************/
        /// <summary>
        /// The Show.
        /// </summary>
        public void Show()
        {
            Node n = head;
            Console.WriteLine(n.data);
            while (n.next!= null)
            {
                n = n.next;
                Console.Write(n.data+"\t");
            }
            Console.WriteLine();
        }

        /***************************************Pop **********************************************/
        /// <summary>
        /// Pops this instance.
        /// </summary>
        public void Pop()
        {
            Node n = head;
            Node n1 = n.next;
            while (n.next.next != null)
            {
                n = n.next;
                //Console.WriteLine(n.data);
            }
            n.next = null;
            Console.WriteLine(n.data);
        }

        //public void Queue(int size)
        //{
        //    element =new int[size];
        //    front = 0;
        //    rear = -1;
        //    max = size;
        //}

        //public void Enqueue(int item)
        //{
        //    if (rear == max-1)
        //    {
        //        Console.WriteLine("Queue have no size ");
        //    }
        //    else
        //    {
        //        element[++rear]= item;
        //    }

        //}
        //public void Dequeue()
        //{
        //    if (front == rear + 1)
        //    {
        //        Console.WriteLine("Queue was Emoty initially");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Element Dqueue is " + element[front]);
        //        int dequeue = element[front++];
        //        Console.WriteLine("Front elenment is " + element[front]);
        //        Console.WriteLine("Last element is " + element[rear]);
        //    }

        //}

        //public void Print()
        //{
        //    if (front == rear + 1)
        //    {
        //        Console.WriteLine("Queue was Empyt");
        //    }
        //    else
        //    {
        //        for(int i=front; i<=rear; i++)
        //        {
        //            Console.WriteLine("Element present in Queue " + element[front]);
        //        }
        //    }
        //}

        public void Evacute()
        {
            Node node = head;
            Node n1 = null;
            n1=node;
            head=node.next;
            Console.WriteLine("Dequeue element was tis all are angram number " + node.data);
        }

        public void Calender(int year, int month)
        {
            //int days = DateTime.DaysInMonth(year, month);
            //Console.WriteLine("Calender of "+year+" "+month);
            //Console.WriteLine("Mon Thu Wed Thur Fri Sut Sun");
            //int currentDay = 1;
            //for (int i = 0; i < calendar.GetLength(0); i++)
            //{
            //    for (int j = 0; j < calendar.GetLength(1) && currentDay <= days; j++)
            //    {
            //        if (i == 0 && month > j)
            //        {
            //            calendar[i, j] = 0;
            //        }
            //        else
            //        {
            //            calendar[i, j] = currentDay;
            //            currentDay++;
            //        }
            //    }
            //}
            int c = DateTime.DaysInMonth(year, month);
            Console.WriteLine(c);
            //for (int i = 3; i < 365; i++)
            //{
                
            //    for (int j = 0; j < 7; j++)
            //    {
            //        Console.Write(c+"\t");
            //        c++;
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
