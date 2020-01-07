//----------------------------------------------------------------------
// <copyright file="Utility.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Stack
{
    using System;

    /// <summary>
    /// The Utility class.
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// The Head Node.
        /// </summary>
        static Node head;

        /// <summary>
        /// The Push method.
        /// </summary>
        /// <param name="data"></param>
        public void Push(char data)
        {
            Node node = new Node();
            node.data = data;
            node.next = null;
            if (head == null)
            {
                head = node;
                Console.WriteLine("Nothing list is empty intially ");
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

        /// <summary>
        /// The Pop method.
        /// </summary>
        public void Pop()
        {
            Node temp = head;
            Node n1 = null;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            n1 = temp.next;
            temp.next = n1.next;
            Console.WriteLine("String was deleted is " + n1.data);
            
        }

        /// <summary>
        /// The Remove method.
        /// </summary>
        /// <param name="index"></param>
        public void Remove(int index)
        {
            try
            {
                if (index == 0)
                {
                    head = head.next;
                }
                else
                {
                    Node n = head;
                    Node n1 = null;
                    for (int i = 0; i < index - 1; i++)
                    {
                        n = n.next;
                    }
                    n1 = n.next;
                    n.next = n1.next;
                    Console.WriteLine("String was deleted is " + n1.data);
                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }

        /// <summary>
        /// The Show method.
        /// </summary>
        public void Show()
        {
            int count = 0;
            int count1 = 0;
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + "\t");
                
                if (temp.data == '(')
                {
                    count++;
                }
                if (temp.data == ')')
                {
                    count1++;
                }

                temp = temp.next;
            }
            Console.WriteLine();
            Check(count, count1);
            Console.WriteLine();
        }

        /// <summary>
        /// The Listlength method.
        /// </summary>
        public void Listlength()
        {
            Node node = new Node();
            node = head;
            int count = 0;
            while (node != null)
            {
                count++;
                node = node.next;
            }
            Console.WriteLine("Number of element in your list is " + (count));
            Remove(count - 1);

        }

        /// <summary>
        /// The Peak method.
        /// </summary>
        public void Peak()
        {
            //Node node = new Node();
            Node node = head;
            int count = 0;
            Node n = null;
            while (node.next != null)
            {
                count++;
                node = node.next;
                //Console.Write(node.data);
            }
            //n=node.next;
            Console.WriteLine("Last element in your list is " + (node.data));
            Console.WriteLine();
        }

        /// <summary>
        /// The Check method.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        public void Check(int num1, int num2)
        {
            //int count = 0;
            //int count1 = 0;
            //for (int i = 0; i < k; i++)
            //{
            //    object ch1 = Pop();
            //    char[] ch2 = (char[])ch1;
            //    if (ch2[i] == '(')
            //    {
            //        count++;
            //    }
            //    if (ch2[i] == ')')
            //    {
            //        count1++;
            //    }
            //}
            if (num1 == num2)
            {
                Console.WriteLine("Your equestion is balanced");
            }
            else
            {
                Console.WriteLine("Your equestion is not balanced");
            }
        }
    }
}
