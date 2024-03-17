using Microsoft.Extensions.Configuration;
using System;

namespace lab4_solid
{
    class Program
    {
        static void Main(string[] args)
        {

            IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", false, true);
            IConfigurationRoot root = builder.Build();

            Console.WriteLine("Hello, world!");
        }
    }
}