//----------------------------------------------------------------------
// <copyright file="Utility.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace HASHTABLE
{
    using System;

    /// <summary>
    /// This is Hashlinkedlist.
    /// </summary>
    public class Hashlinkedlist
    {
        Node head;
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

        /// <summary>
        /// Searches the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Search(int data)
        {
            int count = 0;
            Node n = head;
            bool flag = true;
            while (n != null)
            {
                count++;
                if (data == n.data)
                {
                    Remove(count - 1);
                    flag = false;
                    break;
                }
                n = n.next;
            }
            if (flag == true)
            {
                Add(data);
            }
        }

        /// <summary>
        /// Removes the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
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
        /// Shows this instance.
        /// </summary>
        public void Show()
        {
            Node temp = head;
            while (temp != null)
            {
                
                Console.Write(temp.data + "\t");
                temp = temp.next;
                
            }
            Console.WriteLine();
        }
    }
}
