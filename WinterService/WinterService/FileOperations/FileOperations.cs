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
            var initialWinterStarSigns = File.ReadAllLines(Constants.Constants.WinterIntervalsFilePath).ToList();
            List<string> trimmedWinterStarSigns = new List<string>();
            foreach (var interval in initialWinterStarSigns)
            {
                trimmedWinterStarSigns.Add(interval.Replace(" ", String.Empty));
            }
            return trimmedWinterStarSigns;
        }
    }
}
