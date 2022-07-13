using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Box
{
    public class Box<T> : IComparable<T>  where T : IComparable<T>
    { 
        public Box(T element)
        {
            Element = element;
        }
        public Box(List<T> elementList)
        {
            Elements = elementList;
        }
        public List<T> Elements { get; }
        public T Element { get; }

        //public void Swap(List<T> Elements, int indexOfOne, int indexOfTwo)
        //{
        //    T firstEl = Elements[indexOfOne];
        //    Elements[indexOfOne] = Elements[indexOfTwo];
        //    Elements[indexOfTwo] = firstEl;
        //}
    public int CountOfGreaterElement<T>(List<T> list, T readline) where T : IComparable =>
        list.Count(word => word.CompareTo(readline) > 0);

        //public override string ToString()
        //{
        //    var sb = new StringBuilder();
        //    foreach (var element in Elements)
        //    {
        //        sb.AppendLine($"{element.GetType()}: {element}");

        //    }
        //    return sb.ToString().TrimEnd();
        //    //return $"{typeof(T)}: {Element}";
        //}
    public int CompareTo(T other) 
        => Element.CompareTo(other);
    }
}
