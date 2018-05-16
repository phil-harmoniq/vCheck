using System;
using CliBuilder;
using vCheck.Lib;

namespace vCheck.Cli
{
    class Program
    {
        static CliApp Cli;

        static void Main(string[] args)
        {
            Cli = new CliAppBuilder()
                .AddActionArg(FindPackage, "Find NuGet package using API", "find")
                .Build();
            
            Cli.Start(args);
        }

        public static void FindPackage(string[] args)
        {
            var catalog = Client.GetPackageInfoByID(args[0]);
            Console.WriteLine($"Package name: {catalog.Items[0].CatalogEntry.PackageID}");
            Console.WriteLine($"Highest version: {catalog.UpperVersion}");
            Console.WriteLine($"Lowest version: {catalog.LowerVersion}");
            Console.WriteLine($"Author(s): {catalog.Items[0].CatalogEntry.Authors}");
        }
    }
}
