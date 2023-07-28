using DataStructureAlgorithm.UnOrderedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.OrderedList
{
    public class OrderedList
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            // Console.WriteLine("{0} inserted into linked list", node.data);
        }
        internal void Display(int number)
        {
            Node temp = this.head;
            int[] arr = new int[number];
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            while (temp != null)
            {
                for (int i = 0; i < number; i++)
                {
                    arr[i] = temp.data;
                    temp = temp.next;
                }
            }
            Array.Sort(arr);
            for (int i = 0; i < number; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        internal int search(int value)
        {
            bool isFound = false;
            Node node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node.data == value)
                {
                    return count;
                }
                node = node.next;
                count++;
            }
            if (isFound)
                return count;
            else
                return -1;
        }
        internal void DeleteNodeAtParticularPosition(int position)
        {
            if (this.head == null)
            {
                Console.WriteLine("The Linked List is Empty");
                return;
            }
            Node temp = this.head;
            if (position == 0)
            {
                this.head = temp.next;
                return;
            }
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }
            if (temp == null || temp.next == null)
            {
                return;
            }
            Node next = temp.next.next;
            temp.next = next;
        }
        public void Operation(int data, int number)
        {
            int position = search(data);
            if (position == -1)
            {
                Add(data);
                Display(number + 1);
            }
            else
            {
                DeleteNodeAtParticularPosition(position);
                Display(number - 1);
            }
        }
    }
}
