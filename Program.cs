using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceSimulator;

internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Welcome to the dice throwing simulator!");

        // Get number of rolls
        System.Console.Write("How many dice rolls would you like to simulate? ");
        int numRolls = int.Parse(System.Console.ReadLine());

        // Create the dice rolling instance
        RollDie roll = new RollDie();
        int[] results = roll.DieRoller(numRolls);

        // Print the histogram
        System.Console.WriteLine($"\nDICE ROLLING SIMULATION RESULTS\nEach \"*\" represents 1% of the total number of rolls.\nTotal number of rolls = {numRolls}.\n");
        
        for (int i = 2; i <= 12; i++)
        {
            int percentage = (results[i] * 100) / numRolls;
            string asterisks = new string('*', Math.Max(1, percentage));
            Console.WriteLine($"{i}: {asterisks}");
        }

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");

        
    }
}