using System;
using System.Threading;

class Program
{
    static void Main()
    {
        ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Yellow };
        string[] icons = { ".", "..", "...", "....", ".....", "......" };

        for (int i = 0; i < 5; i++)
        {
            Console.Clear(); // Clears the console at start
            foreach (var icon in icons)
            {
                Console.ForegroundColor = colors[i % colors.Length]; // Cycle through colors
                Console.WriteLine($"Searching {icon}");
                Thread.Sleep(500);
                Console.Clear(); // Clears the console after each iteration
            }
        }

        Console.ResetColor(); // Reset color back to default
    }
}
