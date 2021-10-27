using System;

namespace ConsoleApp1._5
{
    class Program
    {
        public static void Swap(ref int x, ref int y)
        {
            int swap;

            swap = x;
            x = y;
            y = swap;
        }

        public static void Main()
        {
            int x = 5;
            int y = 3;

            Swap(ref x, ref y);

            Console.WriteLine("x: {0} , y: {1}", x, y);
            Console.ReadKey();
        }
    }
}
