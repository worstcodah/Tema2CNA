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

        //In cazul in care se face run cu debugger-ul, nu se va mai opri in momentul in care se arunca exceptie in if.
        [System.Diagnostics.DebuggerHidden]
        public override Task<StarSignResponse> GetStarSignRequest(InputDate inputDate, ServerCallContext context)
        {
            var calendarDate = Helper.Helper.ReplaceDashesWithSlashes(inputDate.InputCalendarDate.ToString());
            //Validari data calendar + exceptie catre client
            if (!Helper.Helper.CheckForValidDate(calendarDate))
            {
                throw new RpcException(new Status(StatusCode.InvalidArgument, "String-ul introdus (" + calendarDate + ") nu este o data calendaristica valida !"));
            }

            //Determinarea microserviciului si returnarea zodiei
            var channel = GrpcChannel.ForAddress(Constants.Constants.ChannelPort);
            var month = Convert.ToInt32(calendarDate.Split("/").ToList().ElementAt(0));
            var calendarDateValues = Helper.Helper.GetDataValues(calendarDate);
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    {
                        var client = new WinterService.WinterStarSignService.WinterStarSignServiceClient(channel);
                        var starSign = client.WinterStarSignRequest(new WinterService.CalendarDate
                        {
                            Month = calendarDateValues.Item1,
                            Day = calendarDateValues.Item2,
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
                            Month = calendarDateValues.Item1,
                            Day = calendarDateValues.Item2,
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
                            Month = calendarDateValues.Item1,
                            Day = calendarDateValues.Item2,
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
                            Month = calendarDateValues.Item1,
                            Day = calendarDateValues.Item2,
                            Year = calendarDateValues.Item3
                        });
                        return Task.FromResult(new StarSignResponse { StarSign = (StarSign)starSign.StarSign });
                    }
            }
            return Task.FromResult(new StarSignResponse { StarSign = StarSign.Undefined });
        }


    }
}
