using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ZodiacServer.Helper
{
    public static class Helper
    {
        public static bool IsValidDate(string input)
        {
            string[] formats = { "M/d/yyyy", "M/dd/yyyy", "MM/d/yyyy", "MM/dd/yyyy", "M/d/yyy", "M/dd/yyy", "MM/d/yyy", "MM/dd/yyy" };
            DateTime dateValue;

            if (DateTime.TryParseExact(input, formats, new CultureInfo("en-US"), DateTimeStyles.None, out dateValue))
                return true;
            else
                return false;
        }

        public static Tuple<string, string, string> GetDateValues(string input)
        {
            var separator = "/";
            String[] outputStrings = input.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            var index = 0;
            string day, month, year;
            day = month = year = null;

            foreach (string output in outputStrings)
            {
                if (Regex.IsMatch(output, @"^\d+$"))
                {
                    switch (index)
                    {
                        case 0: month = output; break;
                        case 1: day = output; break;
                        case 2: year = output; break;
                        default: break;
                    }
                }
                ++index;
            }
            return Tuple.Create(month, day, year);
        }

        public static string ReplaceDashesWithSlashes(string calendarDate)
        {
            var dash = "-";
            var separator = "/";
            return Regex.Replace(calendarDate, dash, separator);
        }
    }
}
