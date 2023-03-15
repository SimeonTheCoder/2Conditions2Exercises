using System;

namespace SoftUni
{
    class Pipes
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());

            int speedA = int.Parse(Console.ReadLine());
            int speedB = int.Parse(Console.ReadLine());

            double time = double.Parse(Console.ReadLine());

            double filledA = speedA * time;
            double filledB = speedB * time;

            double total = filledA + filledB;

            if(total <= volume)
            {
                double percentageTotal = total / volume * 100f;

                double percentageA = filledA / total * 100f;
                double percentageB = filledB / total * 100f;

                Console.WriteLine($"The pool is {percentageTotal:f2}% full.Pipe 1: {percentageA:f2}%.Pipe 2: {percentageB:f2}%.");
            }
            else
            {
                Console.WriteLine($"For {time:f2} hours the pool overflows with {(total - volume):f2} liters.");
            }
        }
    }
}