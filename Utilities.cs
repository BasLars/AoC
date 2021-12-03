using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AoC
{
    public static class Utilities
    {
        public static List<string> getInputAsStringList(string fileName)
        {
            return File.ReadAllLines($"./InputFiles/{fileName}")
            .Select(line => Convert.ToString(line))
            .ToList();
        }

        public static List<int> getInputAsIntList(string fileName)
        {
            return File.ReadAllLines($"./InputFiles/{fileName}")
            .Select(line => int.Parse(line))
            .ToList();
        }

        public static int countOfBiggerThanPrevious(List<int> data)
        {
            int counter = 0;
            for (int i = 1; i < data.Count(); i++)
            {
                if (data[i] > data[i - 1])
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}