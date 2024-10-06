using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskC
{
    internal class LinkGen<T> where T : IComparable
    {
        private T data;
        private LinkGen<T> next;

        public LinkGen(T item)
        {
            this.data = item;
            this.next = null;
        }

        public LinkGen<T> Next
        {
            get { return next; }
            set { next = value; }
        }

        public T Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}
