using System;

namespace ConsoleApp1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int levels = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Points(levels));
        }

        static int Points(int levels)
        {
            if (levels == 1)
            {
                return 1;
            }

            int totalPoints = levels;
            totalPoints += Points(levels - 1);
            return totalPoints;
        }
    }
}
