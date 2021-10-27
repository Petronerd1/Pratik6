using System;

namespace Karekök
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number : ");
            string numStr = Console.ReadLine();
            int numInt = int.Parse(numStr);
            double rootMath = RootMath(numInt);
            Console.WriteLine($"{numInt} number is Squareroot Math {rootMath}");
            double squareroot = SquareR(numInt);
            Console.WriteLine($"{numInt} sayisinin karekökü {squareroot}");

            Console.WriteLine("Press any key to EXIT...");
            Console.ReadKey();
        }
        static double RootMath(int x)
        {
            double SquareRoot = Math.Sqrt(x);
            return SquareRoot;
        }
        static double SquareR(int x)
        {
            int number = x;
            double root = 1;
            int i = 0;
            while (true)
            {
                i = i + 1;
                root = (number / root + root) / 2;
                if (i == number + 1)
                {
                    break;
                }
                
            }
            return root;
        }
    }
}
