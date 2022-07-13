using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Box
{
    class StartUp
    {
        static void Main()
        {
            var numberOfLines = int.Parse(Console.ReadLine());
            //var list = new List<int>();
            //for (int i = 0; i < numberOfLines; i++)
            //{
            //    var input = int.Parse(Console.ReadLine());
            //    list.Add(input);
            //}
            //var commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //var box = new Box<int>(list);
            //var indexOne = commands[0];
            //var indexTwo = commands[1];
            //box.Swap(list, indexOne, indexTwo);
            //Console.WriteLine(box);
            var list = new List<double>();
                for (int i = 0; i < numberOfLines; i++)
            {
                var input = double.Parse(Console.ReadLine());
                list.Add(input);
            }
            var box = new Box<double>(list);
            var compareElement = double.Parse(Console.ReadLine());
            var count = box.CountOfGreaterElement(list, compareElement);
            Console.WriteLine(count);
        }
    }
}
