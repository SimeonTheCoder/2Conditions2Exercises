using System;

namespace SoftUni
{
    class Pets
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            double food = int.Parse(Console.ReadLine());

            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double turtleFood = double.Parse(Console.ReadLine());

            turtleFood /= 1000f;

            double totalDog = dogFood * days;
            double totalCat = catFood * days;
            double totalTurtle = turtleFood * days;
            
            double total = totalDog + totalCat + totalTurtle;

            if(total < food)
            {
                Console.WriteLine($"{Math.Floor(food - total)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(total - food)} more kilos of food are needed.");
            }
        }
    }
}