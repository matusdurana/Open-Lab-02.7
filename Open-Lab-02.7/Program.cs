using System;

namespace Open_Lab_02._7
{
    class Program
    {
        public static bool IsTimeForMilkAndCookies(int year, int month, int day)
        {
            return (month == 12 && day == 24);

        }
        static void Main(string[] args)
        {
            int day;
            int month;
            int year;
           
            Console.WriteLine("Zadaj deň:");
            day = int.Parse(Console.ReadLine());

            Console.WriteLine("Zadaj Mesiac:");
            month = int.Parse(Console.ReadLine());

            Console.WriteLine("Zadaj rok:");
            year = int.Parse(Console.ReadLine());

            Console.WriteLine(IsTimeForMilkAndCookies(year, month, day));
            

        }
        
    }
}
