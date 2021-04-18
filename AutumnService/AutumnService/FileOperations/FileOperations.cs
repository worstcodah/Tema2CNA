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
            const string AutumnStarSignsPath = "../../AutumnService/AutumnService/Resources/autumn.txt";
            var initialAutumnStarSigns = File.ReadAllLines(AutumnStarSignsPath).ToList();
            List<string> trimmedAutumnStarSigns = new List<string>();
            foreach (var interval in initialAutumnStarSigns)
            {
                trimmedAutumnStarSigns.Add(interval.Trim());
            }

            return trimmedAutumnStarSigns;
        }
    }
}
