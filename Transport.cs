using System;

namespace SoftUni
{
    class Transport
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());

            string type = Console.ReadLine();

            if(km < 20)
            {
                double price = 0.7 + (type == "day" ? 0.79 : 0.90) * km;

                Console.WriteLine($"{price:f2}");
            }else if(km < 100)
            {
                double price = 0.09;
                double total = km * price;

                Console.WriteLine($"{total:f2}");
            }
            else
            {
                double price = 0.06;
                double total = km * price;

                Console.WriteLine($"{total:f2}");
            }
        }
    }
}