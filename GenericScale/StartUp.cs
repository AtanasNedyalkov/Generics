using System;

namespace GenericScale
{
    class StartUp
    {
        static void Main()
        {
            var areEqual = EqualityScale<int>.AreEqual(1, 1);
            Console.WriteLine(areEqual);
        }
    }
}
