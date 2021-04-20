using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SpringService.FileOperations
{
    public static class FileOperations
    {
        public static List<string> GetSpringZodiacIntervals()
        {
            var initialSpringIntervals = File.ReadAllLines(Constants.Constants.SpringIntervalsFilePath).ToList();
            var trimmedSpringIntervals = new List<string>();
            foreach (var interval in initialSpringIntervals)
            {
                trimmedSpringIntervals.Add(interval.Replace(" ", String.Empty));
            }

            return trimmedSpringIntervals;
        }
    }
}
