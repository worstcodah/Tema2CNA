using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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


       

        public override Task<StarSign> GetStarSign(CalendarDate calendarDate, ServerCallContext context)
        {
            



                return base.GetStarSign(calendarDate, context);
        }


    }
}
