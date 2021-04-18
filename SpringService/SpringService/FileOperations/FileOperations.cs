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
            const string SpringStarSignsPath = "../../SpringService/SpringService/Resources/spring.txt";
            var initialSpringStarSigns = File.ReadAllLines(SpringStarSignsPath).ToList();
            List<string> trimmedSpringStarSigns = new List<string>();
            foreach (var interval in initialSpringStarSigns)
            {
                trimmedSpringStarSigns.Add(interval.Replace(" ", String.Empty));
            }

            return trimmedSpringStarSigns;
        }
    }
}
