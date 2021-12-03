using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AoC
{
    public class Day1
    {        
        public static void solveDay1()
        {
            int[] data = Utilities.getInputAsIntArray("day1");
            int counter = 0;
            Console.WriteLine(data.Count());

            for (int i = 1; i < data.Count(); i++)
            {
                if (data[i] > data[i - 1])
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }

        


    }
}