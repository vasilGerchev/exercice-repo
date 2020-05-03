using System;

namespace _03.BackInThirtyMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int afterThirtyMinites = minutes + 30;

            if (afterThirtyMinites > 59)
            {
                afterThirtyMinites -= 60;
                hours++;
              
            }
            if (hours > 23)
            {
                hours -= 24;
            }
            Console.WriteLine($"{hours}:{afterThirtyMinites:D2}");
        }
    
    }
}
