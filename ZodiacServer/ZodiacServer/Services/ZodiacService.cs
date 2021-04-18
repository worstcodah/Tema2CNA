using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Grpc.Net.Client;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
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

        public override Task<StarSignResponse> GetStarSignRequest(InputDate inputDate, ServerCallContext context)
        {
            var calendarDate = inputDate.InputCalendarDate.ToString();
            Helper.Helper.ReplaceDashes(calendarDate);
            
            //Validari data calendar + exceptie catre client.

            if (!Helper.Helper.CheckForValidDate(calendarDate))
            {
                throw new RpcException(new Status(StatusCode.InvalidArgument, "Data introdusa nu este valida !"));
            }

            //Zodii
            var channel = GrpcChannel.ForAddress(Constants.Constants.ChannelPort);
            var month = Convert.ToInt32(calendarDate.Split("/").ToList().ElementAt(1));
            var calendarDateValues = Helper.Helper.GetDataValues(calendarDate);
            switch (Convert.ToInt32(month))
            {
                case 12:
                case 1:
                case 2:
                    {
                        var client = new WinterService.WinterStarSignService.WinterStarSignServiceClient(channel);
                        var starSign = client.WinterStarSignRequest(new WinterService.CalendarDate
                        {
                            Day = calendarDateValues.Item1,
                            Month = calendarDateValues.Item2,
                            Year = calendarDateValues.Item3
                        });
                        return Task.FromResult(new StarSignResponse { StarSign = (StarSign)starSign.StarSign });
                    }
                case 3:
                case 4:
                case 5:
                    {
                        var client = new SpringService.SpringStarSignService.SpringStarSignServiceClient(channel);
                        var starSign = client.SpringStarSignRequest(new SpringService.CalendarDate
                        {
                            Day = calendarDateValues.Item1,
                            Month = calendarDateValues.Item2,
                            Year = calendarDateValues.Item3
                        });
                        return Task.FromResult(new StarSignResponse { StarSign = (StarSign)starSign.StarSign });
                    }
                case 6:
                case 7:
                case 8:
                    {
                        var client = new SummerService.SummerStarSignService.SummerStarSignServiceClient(channel);
                        var starSign = client.SummerStarSignRequest(new SummerService.CalendarDate
                        {
                            Day = calendarDateValues.Item1,
                            Month = calendarDateValues.Item2,
                            Year = calendarDateValues.Item3
                        });
                        return Task.FromResult(new StarSignResponse { StarSign = (StarSign)starSign.StarSign });
                    }
                case 9:
                case 10:
                case 11:
                    {
                        var client = new AutumnService.AutumnStarSignService.AutumnStarSignServiceClient(channel);
                        var starSign = client.AutumnStarSignRequest(new AutumnService.CalendarDate
                        {
                            Day = calendarDateValues.Item1,
                            Month = calendarDateValues.Item2,
                            Year = calendarDateValues.Item3
                        });
                        return Task.FromResult(new StarSignResponse { StarSign = (StarSign)starSign.StarSign });
                    }
            }

            return Task.FromResult(new StarSignResponse { StarSign = StarSign.Undefined });
        }


    }
}
