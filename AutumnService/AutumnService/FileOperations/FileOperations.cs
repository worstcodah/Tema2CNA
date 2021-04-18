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
            var initialAutumnStarSigns = File.ReadAllLines(Constants.Constants.AutumnIntervalsFilePath).ToList();
            List<string> trimmedAutumnStarSigns = new List<string>();
            foreach (var interval in initialAutumnStarSigns)
            {
                trimmedAutumnStarSigns.Add(interval.Replace(" ", String.Empty));
            }

            return trimmedAutumnStarSigns;
        }
    }
}
