using System;

namespace _06.TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

                         

                if (typeDay == "Weekday")
            {
                if (age >= 0 && age <= 18 || age > 64 && age <= 122)
                {
                    Console.WriteLine("12$");
                }
                if (age > 18 && age <= 64)
                {
                    Console.WriteLine("18$");
                }
                if (age < 0 || age > 122)
                {
                    Console.WriteLine("Error!");
                }
                }
            
            if (typeDay == "Weekend")
            {
                if (age >= 0 && age <= 18 || age > 64 && age <= 122)
                {
                    Console.WriteLine("15$");
                }
                if (age > 18 && age <= 64)
                {
                    Console.WriteLine("20$");
                }
                if (age < 0 || age > 122)
                {
                    Console.WriteLine("Error!");
                }
            }
            if (typeDay == "Holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    Console.WriteLine("5$");
                }
                if (age > 18 && age <= 64)
                {
                    Console.WriteLine("12$");
                }
                if (age > 64 && age <= 122)
                {
                    Console.WriteLine("10$");
                }
                if (age < 0 || age > 122)
                {
                    Console.WriteLine("Error!");
                }
            }
            
            }
    }
}
