using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Nmos.Clients;
using Nmos.Models.Inputs;
using Spectre.Console;
using Spectre.Console.Cli;
using System.Threading.Tasks;

namespace Nmos.Commands
{
    internal sealed class NodesCommand : NmosCommand
    {
        protected override async Task<CommandResult> ExecuteCommandAsync(CommandContext context, string url, string? id = null)
        {
            AnsiConsole.MarkupLine("[green]Getting nodes...[/]");

            using var client = new NmosClient(url);

            NmosResponse response = string.IsNullOrEmpty(id) ? await client.GetAllNodes() : await client.GetNode(id);

            if (!ValidateResponse(response))
                return CommandResult.Failure();

            string json = JsonConvert.SerializeObject(response);

            return CommandResult.Success(JToken.Parse(json));
        }
    }
}
