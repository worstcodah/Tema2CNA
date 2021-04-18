using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutumnService
{
    public class AutumnService : AutumnStarSignService.AutumnStarSignServiceBase
    {
        private readonly ILogger<AutumnService> _logger;
        public AutumnService(ILogger<AutumnService> logger)
        {
            _logger = logger;
        }

        public override Task<StarSignResponse> AutumnStarSignRequest(CalendarDate calendarDate, ServerCallContext context)
        {
           

            return base.AutumnStarSignRequest(calendarDate, context);
        }
    }
}
