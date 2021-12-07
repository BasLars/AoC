using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AoC
{
    public class Day2
    {
        public static void solvePart1()
        {
            List<string> data = Utilities.getInputAsStringList("day2");
            int horizontalPosition = 0;
            int depth = 0;

            var forward = Utilities.getListOfMatchingIndicies(data, "forward");
            var up = Utilities.getListOfMatchingIndicies(data, "up");
            var down = Utilities.getListOfMatchingIndicies(data, "down");

            horizontalPosition = Utilities.getDigits(forward).Sum();
            depth = Utilities.getDigits(down).Sum() - Utilities.getDigits(up).Sum();

            Console.WriteLine($"Horizontal position = {horizontalPosition}, depth = {depth}, vector = {horizontalPosition * depth}");
        }

        public static void solvePart2()
        {
            List<string> data = Utilities.getInputAsStringList("day2");
            int horizontalPosition = 0;
            int depth = 0;
            int aim = 0;

            data.ForEach((x) =>
            {
                int amount = int.Parse(x.Split(' ')[1]);
                switch (x.Split(' ')[0])
                {
                    
                    case "forward":
                        horizontalPosition += amount;
                        depth += (aim * amount);
                        break;
                    case "down":
                        aim += amount;
                        break;
                    case "up":
                        aim -= amount;
                        break;
                }
                
            });
            Console.WriteLine($"Result: {horizontalPosition * depth}");
        }
    }
}