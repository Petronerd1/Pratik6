using System;

namespace ConsoleApp1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal fact;
            Console.Write("Enter a number :");
            int num = Convert.ToInt32(Console.ReadLine());
            fact = Factorial(num);
            Console.WriteLine("The factorial of number {0} is {1}",num,fact);
            Console.ReadLine();
        }
        static decimal Factorial(int n1)
        {
            if(n1==0)
            {
                return 1;
            }
            else
            {
                return n1 * Factorial(n1 - 1);
            }
        }
    }
}
