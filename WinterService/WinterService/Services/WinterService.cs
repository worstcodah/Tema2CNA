using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WinterService
{
    public class WinterService : WinterStarSignService.WinterStarSignServiceBase
    {
        private readonly ILogger<WinterService> _logger;
        public WinterService(ILogger<WinterService> logger)
        {
            _logger = logger;
        }

        public override Task<StarSignResponse> WinterStarSignRequest(CalendarDate calendarDate, ServerCallContext context)
        {

            

            return base.WinterStarSignRequest(calendarDate, context);
        }


    }
}
