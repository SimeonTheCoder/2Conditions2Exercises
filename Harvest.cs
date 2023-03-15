using System;

namespace SoftUni
{
    class Harvest
    {
        const double WINE_AREA = 0.4;
        const double PRODUCTION_PER_WINE = 2.5;

        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double productionPerArea = double.Parse(Console.ReadLine());

            int targetWine = int.Parse(Console.ReadLine());
            int employeesCount = int.Parse(Console.ReadLine());

            double wineArea = area * WINE_AREA;
            double production = wineArea * productionPerArea;

            double wine = production / PRODUCTION_PER_WINE;

            if(wine >= targetWine)
            {
                double remaining = wine - targetWine;

                double winePerPerson = remaining / employeesCount;

                Console.WriteLine($"Good harvest this year! Total wine: {wine} liters.");
                Console.WriteLine($"{remaining} liters left -> {winePerPerson} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(targetWine - wine)} liters wine needed.");
            }
        }
    }
}