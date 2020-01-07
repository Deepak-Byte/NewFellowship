//----------------------------------------------------------------------
// <copyright file="Utility.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Queuepallindrom
{
    using System;

    /// <summary>
    /// The Utility class.
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// The head.
        /// </summary>
        static Node head;

        /// <summary>
        /// Enqueueatends the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Enqueueatend(string data)
        {
            Node node = new Node();
            node.data = data;
            node.next = null;
            if (head == null)
            {
                head = node;
                Console.WriteLine("String was succesfully added at first location");
            }
            else
            {
                Node n = head;
                while (n.next != null)
                {
                    n = n.next;
                }
                n.next = node;
                Console.WriteLine("String was succesfully added at end");
            }
        }

        /// <summary>
        /// Enqueueatfronts the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Enqueueatfront(string data)
        {
            Node node = new Node();
            node.data = data;
            node.next = null;
            node.next = head;
            head = node;
            Console.WriteLine("String was succesfully added at front");
        }

        /// <summary>
        /// Dequeueatends this instance.
        /// </summary>
        public void Dequeueatend()
        {
            Node node = head;
            //Node n1 = null;
            int count = 0;
            while (node != null)
            {
                node = node.next;
                count++;
            }
            Console.WriteLine(count);
            Remove(count-1);
            //n1 = node.next;
            //node.next = n1.next;
            //Console.WriteLine("Data deleted was at end is " + n1.data);
        }

        /// <summary>
        /// Dequeueatfronts this instance.
        /// </summary>
        public void Dequeueatfront()
        {
            Node node = head;
            Node n1 = null;
            node.next = head;
            n1 = node.next;
            node.next = n1.next;
            Console.WriteLine("Data deleted was at front is " + n1.data);
        }

        /// <summary>
        /// Shows this instance.
        /// </summary>
        public void Show()
        {
            Node temp = head;
            while (temp.next != null)
            {
                Console.Write(temp.data + "->\t");
                temp = temp.next;
            }
            Console.WriteLine(temp.data+"->\t");
            Console.ReadKey();
        }

        /// <summary>
        /// Removes the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        public void Remove(int index)
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
                Console.WriteLine("Data deleted was at end is " + n1.data);
            }
        }

        /// <summary>
        /// Checks the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        public void Check(int index)
        {
            Node n = head;
            for (int i = 0; i < index-1 ; i++)
            {
                n = n.next;
            }
            char[] arr = (n.data).ToCharArray();             //TO convert string type into char array type
            Array.Reverse(arr);                              //TO Reverse a string
            string result = new string(arr);                 //TO conert  char array into string
            int def = string.Compare(result, (n.data));      // TO compare whether two string are same
            if (def == -1)
            {
                Console.WriteLine("not palindrom");
            }
            else
            {
                Console.WriteLine("palindrom");
            }
        }
    }
}
