using System;

namespace ConsoleApp1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 1;
            int sayi;

            Console.Write("Number of elements = ");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------------");
            Console.Write(x + " " + y + " ");

            for (int i = 3; i <= sayi; i++)
            {
                int z = x + y;
                Console.Write(z + " ");
                x = y;
                y = z;
            }
            Console.ReadKey();
        }
    }
}
    