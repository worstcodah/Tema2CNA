using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpringService
{
    public class SpringService : SpringStarSignService.SpringStarSignServiceBase
    {
        private readonly ILogger<SpringService> _logger;
        public SpringService(ILogger<SpringService> logger)
        {
            _logger = logger;
        }

        public StarSign StringToStarSign(string starSignString)
        {
            switch (starSignString)
            {
                case "Pesti":
                    return StarSign.Pesti;
                case "Berbec":
                    return StarSign.Berbec;
                case "Taur":
                    return StarSign.Taur;
                case "Gemeni":
                    return StarSign.Gemeni;
            }
            return StarSign.Undefined;
        }
        public override Task<StarSignResponse> SpringStarSignRequest(CalendarDate calendarDate, ServerCallContext context)
        {
            var springStarSigns = FileOperations.FileOperations.GetSpringZodiacIntervals();
            foreach (var springStarSign in springStarSigns)
            {
                var lineContent = springStarSign.Split("-").ToList();
                var firstInterval = lineContent.ElementAt(0).Split("/").ToList();
                var secondInterval = lineContent.ElementAt(1).Split("/").ToList();
                var firstIntervalMonth = firstInterval.ElementAt(1);
                var secondIntervalMonth = secondInterval.ElementAt(1);

                if (Convert.ToInt32(calendarDate.Month) == Convert.ToInt32(firstIntervalMonth))
                {
                    var intervalStartDay = Convert.ToInt32(firstInterval.ElementAt(0));
                    var intervalEndDay = firstIntervalMonth == secondIntervalMonth ? Convert.ToInt32(secondInterval.ElementAt(0)) : Constants.Constants.MaxDayValue;
                    if (intervalStartDay <= Convert.ToInt32(calendarDate.Day) && intervalEndDay >= Convert.ToInt32(calendarDate.Day))
                    {
                        var starSignString = lineContent.ElementAt(2);
                        return Task.FromResult(new StarSignResponse { StarSign = StringToStarSign(starSignString) });
                    }
                }
                if (Convert.ToInt32(calendarDate.Month) == Convert.ToInt32(secondIntervalMonth) && firstIntervalMonth != secondIntervalMonth)
                {
                    var intervalStartDay = Convert.ToInt32(Constants.Constants.MinDayValue);
                    var intervalEndDay = Convert.ToInt32(secondInterval.ElementAt(0));
                    if (intervalStartDay <= Convert.ToInt32(calendarDate.Day) && intervalEndDay >= Convert.ToInt32(calendarDate.Day))
                    {
                        var starSignString = lineContent.ElementAt(2);
                        return Task.FromResult(new StarSignResponse { StarSign = StringToStarSign(starSignString) });
                    }
                }

            }
            return Task.FromResult(new StarSignResponse { StarSign = StarSign.Undefined });
        }

    }
}
