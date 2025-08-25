using System;

class Question3
{
    enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

    static void Main(string[] args)
    {
        int[] units = new int[7];

        Console.WriteLine("Enter units consumed for each day (Mon to Sun):");
        for (int i = 0; i < 7; i++)
        {
            Console.Write("Day " + (i + 1) + ": ");
            units[i] = Convert.ToInt32(Console.ReadLine());
        }

        int total = 0;
        int maxUnits = units[0];
        int maxDayIndex = 0;

        for (int i = 0; i < 7; i++)
        {
            total += units[i];
            if (units[i] > maxUnits)
            {
                maxUnits = units[i];
                maxDayIndex = i;
            }
        }

        double average = (double)total / 7;

        Console.WriteLine("\nTotal units: " + total);
        Console.WriteLine("Average units/day: " + average.ToString("0.00"));
        Console.WriteLine("Highest consumption: " + (Days)maxDayIndex + " (" + maxUnits + " units)");
    }
}
