using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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

        public static List<string> getListOfMatchingIndicies(List<string> data, string key)
        {
            return data.Where(x => x.Contains(key)).ToList();
        }


        public static List<int> getDigits(List<string> data)
        {
            List<int> ret = new List<int>();            

            data.ForEach(x => {
                ret.Add(Convert.ToInt32(Regex.Replace(x, "[^0-9]", "")));
            });

            return ret;

        }

    }
}