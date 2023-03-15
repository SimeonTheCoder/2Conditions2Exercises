using System;
using System.Transactions;

namespace SoftUni
{
    class Flowers
    {
        const double M_PRICE = 3.25;
        const double Z_PRICE = 4.00;
        const double R_PRICE = 3.50;
        const double C_PRICE = 8.00;

        const double TAX_PERCENT = 0.05;

        static void Main(string[] args)
        {
            int mCount = int.Parse(Console.ReadLine());
            int zCount = int.Parse(Console.ReadLine());
            int rCount = int.Parse(Console.ReadLine());
            int cCount = int.Parse(Console.ReadLine());

            double presentPrice = double.Parse(Console.ReadLine());

            double money = M_PRICE * mCount + Z_PRICE * zCount + R_PRICE * rCount + C_PRICE * cCount;
            money -= money * TAX_PERCENT;

            if(money < presentPrice)
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(presentPrice - money)} leva.");
            }
            else
            {
                Console.WriteLine($"She is left with {Math.Floor(money - presentPrice)} leva.");
            }
        }
    }
}