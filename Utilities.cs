using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AoC
{
    public static class Utilities
    {
        public static string[] getInputAsStringArray(string fileName){
            return File.ReadAllLines($"./InputFiles/{fileName}");
        }  

        public static int[] getInputAsIntArray(string fileName){
            string[] input = File.ReadAllLines($"./InputFiles/{fileName}");
            return Array.ConvertAll(input, s => Int32.Parse(s));
        }       
    }
}