using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SummerService
{
    public class SummerService : SummerStarSignService.SummerStarSignServiceBase
    {
        private readonly ILogger<SummerService> _logger;
        public SummerService(ILogger<SummerService> logger)
        {
            _logger = logger;
        }

        public override Task<StarSignResponse> SummerStarSignRequest(CalendarDate request, ServerCallContext context)
        {
            return base.SummerStarSignRequest(request, context);
        }
    }
}
