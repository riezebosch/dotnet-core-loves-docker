using System;
using Microsoft.Extensions.Configuration;

namespace json
{
    class Program
    {
        static void Main(string[] args)
        {
            string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{environment}.json", true, false);

            var configuration = builder.Build();
            System.Console.WriteLine(configuration["message"]);
        }
    }
}
