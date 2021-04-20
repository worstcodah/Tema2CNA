using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AutumnService.FileOperations
{
    public static class FileOperations
    {
        public static List<string> GetAutumnZodiacIntervals()
        {
            var initialAutumnIntervals = File.ReadAllLines(Constants.Constants.AutumnIntervalsFilePath).ToList();
            var trimmedAutumnIntervals = new List<string>();
            foreach (var interval in initialAutumnIntervals)
            {
                trimmedAutumnIntervals.Add(interval.Replace(" ", String.Empty));
            }

            return trimmedAutumnIntervals;
        }
    }
}
