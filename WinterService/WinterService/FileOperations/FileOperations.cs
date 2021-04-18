using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WinterService.FileOperations
{
    public static class FileOperations
    {
        public static List<string> GetAutumnZodiacIntervals()
        {
            const string WinterStarSignsPath = "../../WinterService/WinterService/Resources/winter.txt";
            var initialWinterStarSigns = File.ReadAllLines(WinterStarSignsPath).ToList();
            List<string> trimmedWinterStarSigns = new List<string>();
            foreach (var interval in initialWinterStarSigns)
            {
                trimmedWinterStarSigns.Add(interval.Trim());
            }

            return trimmedWinterStarSigns;
        }
    }
}
