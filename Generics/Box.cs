using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> date;

        public Box()
        {
            this.date = new List<T>(); ;
        }

        public int Count
        {
            get
            {
                return this.date.Count;
            }
        }

        public void Add(T item)
        {
            this.date.Add(item);
        }
        public T Remove()
        {
            var lastElement = this.date[this.date.Count - 1];
            this.date.RemoveAt(this.date.Count - 1);
            return lastElement;
        }
    }
}


