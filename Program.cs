using System;

namespace AoC
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("What is yoru name?");
        var name = Console.ReadLine();
        var currentDate = DateTime.Now;
        Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
        }
    }
}
