using System;
using Microsoft.Extensions.Configuration;

namespace json
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .AddCommandLine(args);

            var configuration = builder.Build();
            System.Console.WriteLine(configuration["message"]);
        }
    }
}
