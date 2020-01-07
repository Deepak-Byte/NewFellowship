using System;
using System.Collections.Generic;
using System.Text;

namespace NEW_OPPS_PROJECT.Deckofcardslinkedlist
{
    public class Cardlinkedlist
    {
        Node head;
        public void Enqueue(string data)
        {
            Node node = new Node();
            node.data = data;
            node.next = null;
            if (head == null)
            {
                node = head;
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
        public void Dequeue()
        {
            Node node = head;
            Node n = null;
            n = node;
            node.next = head;
            Console.WriteLine("deleted element was "+ node.data);
        }

        public void Display()
        {
            Node node = head;
            Console.WriteLine(node.data);
            while (node!= null)
            {
                node = node.next;
                Console.WriteLine(node.data);
            }
            Console.WriteLine(node.data);
        }
    }
}
