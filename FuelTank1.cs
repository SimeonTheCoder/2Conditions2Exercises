using System;

namespace SoftUni
{
    class FuelTank1
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            int liters = int.Parse(Console.ReadLine());

            if(fuelType != "Diesel" && fuelType != "Gasoline" && fuelType != "Gas")
            {
                Console.WriteLine("Invalid fuel!");

                return;
            }

            if(liters >= 25)
            {
                Console.WriteLine($"You have enough {fuelType.ToLower()}.");
            }
            else
            {
                Console.WriteLine($"Fill your tank with {fuelType.ToLower()}!");
            }
        }
    }
}