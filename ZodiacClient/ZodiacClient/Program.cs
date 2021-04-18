using Grpc.Net.Client;
using System;

namespace ZodiacClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new StarSignService.StarSignServiceClient(channel);

            var zodiacData = client.GetStarSignRequest(new CalendarDate { Day="25", Month="10", Year="2000"});
            Console.WriteLine(zodiacData.StarSign);


            channel.ShutdownAsync();
        }
    }
}

