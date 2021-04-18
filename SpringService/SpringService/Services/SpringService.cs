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

        public override Task<StarSignResponse> SpringStarSignRequest(CalendarDate request, ServerCallContext context)
        {
            return base.SpringStarSignRequest(request, context);
        }

    }
}
