using System;

namespace _10.MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int StartFromNum = int.Parse(Console.ReadLine());
            if (StartFromNum <= 10)
            {
                for (int i = StartFromNum; i <= 10; i++)
                {
                    Console.WriteLine($"{num} X {i} = {num * i}");

                }
            }
            else
            {
                Console.WriteLine($"{num} X {StartFromNum} = {num * StartFromNum}");
            }
        }
    }
}
