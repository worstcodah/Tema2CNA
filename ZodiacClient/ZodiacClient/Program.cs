using Grpc.Core;
using Grpc.Net.Client;
using System;

namespace ZodiacClient
{
    public class Program
    {
        private static GrpcChannel channel;
        private static StarSignService.StarSignServiceClient client;
        static void RunZodiacMenu()
        {
            var choice = Char.MinValue;
            do
            {
                Console.Clear();
                Console.WriteLine("Doriti sa trimiteti o data calendaristica spre server si sa primiti un raspuns?\n N/n -> nu\n Orice alta tasta -> da");
                choice = Console.ReadKey().KeyChar;
                if (choice == 'N' || choice == 'n')
                {
                    break;
                }
                Console.WriteLine("\nIntroduceti o data calendaristica (data trebuie sa fie in format luna/zi/an):  ");
                var inputDate = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(inputDate))
                {
                    Console.WriteLine("Data nu poate fi alcatuita doar din spatii goale!");
                    Console.WriteLine("Apasati o tasta pentru a continua.");
                    Console.ReadKey();
                    continue;
                }
                inputDate = inputDate.Replace(" ", String.Empty);
                try
                {
                    var zodiacData = client.GetStarSignRequest(new InputDate { InputCalendarDate = inputDate });
                    Console.WriteLine("Zodia asociata datei calendaristice introduse (" + inputDate + ") este " + zodiacData.StarSign);
                    Console.WriteLine("Apasati o tasta pentru a continua.");
                    Console.ReadKey();
                }
                catch (RpcException rpcException)
                {
                    Console.WriteLine(rpcException.Status.Detail);
                    Console.WriteLine("Apasati o tasta pentru a continua.");
                    Console.ReadKey();
                }
            } while (true);
            Console.WriteLine("\nClientul se inchide...");
        }
        static void Main(string[] args)
        {
            channel = GrpcChannel.ForAddress("https://localhost:5001");
            client = new StarSignService.StarSignServiceClient(channel);
            RunZodiacMenu();

            channel.ShutdownAsync();
        }
    }
}

