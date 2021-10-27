using System;

namespace ConsoleApp1._2
{
    class Program
    {
        public static int  SumCal(int number)
        {
            string n1 = Convert.ToString(number);
            int sum = 0;
            for (int i = 0; i < n1.Length; i++)
                sum += Convert.ToInt32(n1.Substring(i, 1));
            return sum;
        }
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a number :");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of the digits of the number {0} is : {1} \n", num, SumCal(num));
            Console.ReadKey();
        }
    }
}
