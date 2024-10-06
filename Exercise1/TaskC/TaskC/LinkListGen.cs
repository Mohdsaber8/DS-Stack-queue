using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskC
{
    internal class LinkListGen<T> where T : IComparable
    {
        private LinkGen<T> head;

        public LinkListGen()
        {
            head = null;
        }

        public void AddToHead(T item)
        {
            LinkGen<T> newLink = new LinkGen<T>(item);
            newLink.Next = head;
            head = newLink;
        }

        public string DisplayList()
        {
            var current = head;
            StringBuilder result = new StringBuilder();
            while (current != null)
            {
                result.AppendLine(current.Data.ToString());
                current = current.Next;
            }
            return result.ToString();
        }

        public int NumberOfItems()
        {
            var current = head;
            int count = 0;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        public bool IsPresentItem(T item)
        {
            var current = head;
            while (current != null)
            {
                if (current.Data.CompareTo(item) == 0)
                    return true;
                current = current.Next;
            }
            return false;
        }

        public void RemoveItem(T item)
        {
            LinkGen<T> current = head;
            LinkGen<T> previous = null;

            while (current != null)
            {
                if (current.Data.CompareTo(item) == 0)
                {
                    if (previous == null)
                        head = current.Next;
                    else
                        previous.Next = current.Next;

                    break;
                }
                previous = current;
                current = current.Next;
            }
        }

        public void AppendItem(T item)
        {
            LinkGen<T> newLink = new LinkGen<T>(item);
            if (head == null)
            {
                head = newLink;
            }
            else
            {
                LinkGen<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newLink;
            }
        }

        public void InsertInOrder(T item)
        {
            LinkGen<T> newLink = new LinkGen<T>(item);
            LinkGen<T> current = head;
            LinkGen<T> previous = null;

            while (current != null && current.Data.CompareTo(item) < 0)
            {
                previous = current;
                current = current.Next;
            }

            if (previous == null)
                head = newLink;
            else
                previous.Next = newLink;

            newLink.Next = current;
        }
    }
}


