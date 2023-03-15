using System;

namespace SoftUni
{
    class Cat
    {
        const int playtimeWorkingDay = 63;
        const int playtimeOffDay = 127;

        const int NORM = 30_000;

        static void Main(string[] args)
        {
            int offDays = int.Parse(Console.ReadLine());
            int workingDays = 365 - offDays;

            int totalPlaytimeWorkingDays = workingDays * playtimeWorkingDay;
            int totalPlaytimeOffDays = offDays * playtimeOffDay;

            int total = totalPlaytimeWorkingDays + totalPlaytimeOffDays;

            if(total <= NORM)
            {
                int difference = NORM - total;

                int hours = difference / 60;
                int minutes = difference % 60;

                Console.WriteLine($"Tom sleeps well\n{hours} hours and {minutes} minutes less for play");
            }
            else
            {
                int difference = total - NORM;

                int hours = difference / 60;
                int minutes = difference % 60;

                Console.WriteLine($"Tom will run away\n{hours} hours and {minutes} minutes more for play");
            }
        }
    }
}