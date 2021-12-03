using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AoC
{
    public class Day1
    {
        public static void solvePart1()
        {
            List<int> data = Utilities.getInputAsIntList("day1");
            Console.WriteLine(Utilities.countOfBiggerThanPrevious(data));
        }

        public static void solvePart2()
        {
            List<int> data = Utilities.getInputAsIntList("day1");
            List<int> combined = new List<int>();

            for (int i = 0; i < data.Count() - 2; i++)
            {
                combined.Add(data.GetRange(i, 3).Sum());
            }

            Console.WriteLine(Utilities.countOfBiggerThanPrevious(combined));

        }
    }
}