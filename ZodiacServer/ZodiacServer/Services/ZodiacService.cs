using Grpc.Core;
using Grpc.Net.Client;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Threading.Tasks;


namespace ZodiacServer
{
    public class ZodiacService : StarSignService.StarSignServiceBase
    {
        private readonly ILogger<ZodiacService> _logger;
        public ZodiacService(ILogger<ZodiacService> logger)
        {
            _logger = logger;
        }


        public override Task<StarSignResponse> GetStarSignRequest(CalendarDate calendarDate, ServerCallContext context)
        {
            //Validari data calendar + exceptii catre client.


            //Zodii
            var channel = GrpcChannel.ForAddress(Constants.Constants.CHANNEL_PORT);
            
            switch (calendarDate.Month)
            {
                case "12":
                case "1":
                case "01":
                case "2":
                case "02":
                    {
                        var client = new WinterService.WinterStarSignService.WinterStarSignServiceClient(channel);
                        var starSign = client.WinterStarSignRequest(new WinterService.CalendarDate
                        {
                            Day = calendarDate.Day,
                            Month = calendarDate.Month,
                            Year = calendarDate.Year
                        });
                        return Task.FromResult(new StarSignResponse { StarSign = (StarSign)starSign.StarSign });
                    }
                case "3":
                case "03":
                case "4":
                case "04":
                case "5":
                case "05":
                    {

                        break;
                    }
                case "6":
                case "06":
                case "7":
                case "07":
                case "8":
                case "08":
                    {
                        break;
                    }
                case "9":
                case "09":
                case "10":
                case "11":
                    {

                        var client = new AutumnService.AutumnStarSignService.AutumnStarSignServiceClient(channel);

                        var starSign = client.AutumnStarSignRequest(new AutumnService.CalendarDate
                        {
                            Day = calendarDate.Day,
                            Month = calendarDate.Month,
                            Year = calendarDate.Year
                        });
                        return Task.FromResult(new StarSignResponse { StarSign = (StarSign)starSign.StarSign });
                    }
            }

            return base.GetStarSignRequest(calendarDate, context);
        }


    }
}
