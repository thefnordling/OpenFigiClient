using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Range<T> 
    {
        public Range(T from, T to)
        {
            this.From = from;
            this.To = to;
        }
        public T From { get; private set; }
        public T To { get; private set; }
    }
}
