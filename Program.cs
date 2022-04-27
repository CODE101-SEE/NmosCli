using Nmos.Commands;
using Spectre.Console;
using Spectre.Console.Cli;
using System.Threading.Tasks;

namespace Nmos
{
    internal class Program
    {
        static async Task<int> Main(string[] args)
        {
            var app = new CommandApp();
            app.Configure(config =>
            {
                config.AddCommand<NodesCommand>("nodes")
                    .WithDescription("Get's registered nodes")
                    .WithExample(new[] { "nodes", "--address localhost", "--port 3211", "--version 1.2", "--id f0e16eb0-5959-5556-b6f2-0954b6108e72" });

                config.AddCommand<DevicesCommand>("devices")
                    .WithDescription("Get's registered devices")
                    .WithExample(new[] { "devices", "--address localhost", "--port 3211", "--version 1.2" });

                config.AddCommand<ReceiversCommand>("receivers")
                    .WithDescription("Get's registered receivers")
                    .WithExample(new[] { "receivers", "--address localhost", "--port 3211", "--version 1.2" });

                config.AddCommand<SendersCommand>("senders")
                    .WithDescription("Get's registered senders")
                    .WithExample(new[] { "senders", "--address localhost", "--port 3211", "--version 1.2" });

                config.AddCommand<SourcesCommand>("sources")
                    .WithDescription("Get's registered sources")
                    .WithExample(new[] { "sources", "--address localhost", "--port 3211", "--version 1.2" });

                config.AddCommand<SubscriptionsCommand>("subscriptions")
                    .WithDescription("Get's subscriptions")
                    .WithExample(new[] { "subscriptions", "--address localhost", "--port 3211", "--version 1.2" });
            });

            if (args.Length == 0)
            {
                AnsiConsole.Write(new FigletText(".NET Nmos CLI").Centered().Color(Color.Red));
            }

            return await app.RunAsync(args);

        }
    }
}
