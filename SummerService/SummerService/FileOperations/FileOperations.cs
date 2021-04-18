using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SummerService.FileOperations
{
    public static class FileOperations
    {
        public static List<string> GetSummerZodiacIntervals()
        {
            const string SummerStarSignsPath = "../../SummerService/SummerService/Resources/summer.txt";
            var initialSummerStarSigns = File.ReadAllLines(SummerStarSignsPath).ToList();
            List<string> trimmedSummerStarSigns = new List<string>();
            foreach (var interval in initialSummerStarSigns)
            {
                trimmedSummerStarSigns.Add(interval.Trim());
            }

            return trimmedSummerStarSigns;
        }
    }
}
