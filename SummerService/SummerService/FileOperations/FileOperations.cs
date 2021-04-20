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
            var initialSummerIntervals = File.ReadAllLines(Constants.Constants.SummerIntervalsFilePath).ToList();
            var trimmedSummerIntervals = new List<string>();
            foreach (var interval in initialSummerIntervals)
            {
                trimmedSummerIntervals.Add(interval.Replace(" ", String.Empty));
            }

            return trimmedSummerIntervals;
        }
    }
}
