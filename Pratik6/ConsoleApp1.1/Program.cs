using System;

namespace ConsoleApp1._1
{
    class Program
    {
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }
        static double PlusMethod(double x, double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            int Num1 = PlusMethod(7, 4);
            double Num2 = PlusMethod(4.7, 6.7);
            Console.WriteLine("Int :" + Num1);
            Console.WriteLine("Double :" + Num2);
            Console.ReadKey();
        }
    }
}
