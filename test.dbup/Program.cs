using DbUp;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Reflection;

namespace test.dbup
{
    class Program
    {
        static void Main(string[] args)
        {
            var postgresConnectionString = $"Host=localhost;Database=postgres;Username=postgres;Password=password;Port=5432";

            //var connectionString = "User ID=postgres;Password=password;Host=localhost;Port=5432;Database=posttest";

            var upgradeEngine = DeployChanges.To
                .PostgresqlDatabase(postgresConnectionString)
                .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
                .LogToConsole()
                .Build();

            Console.WriteLine(String.Join(";", upgradeEngine.GetDiscoveredScripts().Select(s => s.Name)));

            if (upgradeEngine.IsUpgradeRequired())
            {
                var result = upgradeEngine.PerformUpgrade();

                Console.WriteLine(JsonConvert.SerializeObject(result));
            }

            Console.WriteLine("Hello World!");
        }
    }
}
