using System;

namespace SoftUni
{
    class FuelTank2
    {
        const double GASOLINE_PRICE = 2.22;
        const double DIESEL_PRICE = 2.33;
        const double GAS_PRICE = 0.93;

        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            int liters = int.Parse(Console.ReadLine());

            string clubString = Console.ReadLine();

            bool clubCard = false;

            if (clubString == "Yes") clubCard = true;
            if (clubString == "No") clubCard = false;

            double pricePerLiter = 0f;

            switch (fuelType)
            {
                case "Gasoline":
                    pricePerLiter = GASOLINE_PRICE;

                    break;

                case "Diesel":
                    pricePerLiter = DIESEL_PRICE; 

                    break;

                case "Gas":
                    pricePerLiter = GAS_PRICE;

                    break;    
            }

            double price = pricePerLiter * liters;

            if(clubCard)
            {
                if(fuelType == "Gasoline")
                {
                    price -= liters * 0.18;
                }
                else if(fuelType == "Diesel")
                {
                    price -= liters * 0.12;
                }
                else if(fuelType == "Gas")
                {
                    price -= liters * 0.08;
                }
            }

            if(liters >= 20 && liters <= 25)
            {
                price -= price * 0.08;
            }
            else if(liters > 25)
            {
                price -= price * 0.10;
            }

            Console.WriteLine($"{price:f2} lv.");
        }
    }
}