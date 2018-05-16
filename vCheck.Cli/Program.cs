using System;
using vCheck.Lib;

namespace vCheck.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var cli = new CliBuilder.CliBuilder()
                .AddActionArg(FindPackage, "Find NuGet package using API", "find")
                .Start(args);
        }

        public static void FindPackage(string[] args)
        {
            var catalog = Client.GetPackageInfoByID(args[0]);
            Console.WriteLine(catalog);
        }
    }
}
