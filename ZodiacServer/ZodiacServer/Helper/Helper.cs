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
        public static bool CheckForValidDate(string input)
        {
            string[] formats = { "d/M/yyyy", "dd/M/yyyy", "d/MM/yyyy", "dd/MM/yyyy" };
            DateTime dateValue;

            if (DateTime.TryParseExact(input, formats, new CultureInfo("en-US"), DateTimeStyles.None, out dateValue))
                return true;
            else
                return false;
        }

        public static Tuple<string, string, string> GetDataValues(string input)
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
                        case 0: day = output; break;
                        case 1: month = output; break;
                        case 2: year = output; break;
                        default: break;
                    }
                }
                ++index;
            }

            return Tuple.Create(day, month, year);
        }

        public static void ReplaceDashes(string calendarDate)
        {
            var replaceDash = new Regex(@"-");
            String separator = "/";
            calendarDate = replaceDash.Replace(calendarDate, separator);
        }
    }
}
