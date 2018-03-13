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
                .AddCommandLine(args)
                .AddDockerSecrets();

            var configuration = builder.Build();

            while (true)
            {
                System.Console.WriteLine(configuration["message"]);  
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));              
            }
        }
    }
}
