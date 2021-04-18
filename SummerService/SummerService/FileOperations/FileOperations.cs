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
            var initialSummerStarSigns = File.ReadAllLines(Constants.Constants.SummerIntervalsFilePath).ToList();
            List<string> trimmedSummerStarSigns = new List<string>();
            foreach (var interval in initialSummerStarSigns)
            {
                trimmedSummerStarSigns.Add(interval.Replace(" ", String.Empty));
            }

            return trimmedSummerStarSigns;
        }
    }
}
