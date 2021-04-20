using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WinterService.FileOperations
{
    public static class FileOperations
    {
        public static List<string> GetWinterZodiacIntervals()
        {
            var initialWinterIntervals = File.ReadAllLines(Constants.Constants.WinterIntervalsFilePath).ToList();
            var trimmedWinterIntervals = new List<string>();
            foreach (var interval in initialWinterIntervals)
            {
                trimmedWinterIntervals.Add(interval.Replace(" ", String.Empty));
            }

            return trimmedWinterIntervals;
        }
    }
}
