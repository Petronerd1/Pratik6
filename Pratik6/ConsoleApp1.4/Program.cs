using System;

namespace ConsoleApp1._4
{
    class Program
    {
        static void Main(string[] args)
        {

            string day = DateTime.Now.Day.ToString("00");
            string month = GetMonth(DateTime.Now.Month);
            int year = DateTime.Now.Year;
            string time = DateTime.Now.ToLongTimeString();
            Console.WriteLine("Today is {0} of {1} of {2}. It's {3}.", day, month, year,time);
            Console.ReadKey();
        }
        static string GetMonth(int numberMonth)
        {
            string[] months =
                new string[] {"January", "February", "March", "April", "May", "June", "July",
                           "August", "September", "October", "November", "Decenber"};
            return months[numberMonth - 1];
        }
    }
}
