using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Nmos.Clients;
using Nmos.Models.Inputs;
using Nmos.Models.v1._3._1;
using Spectre.Console;
using Spectre.Console.Cli;
using System.Threading.Tasks;

namespace Nmos.Commands
{
    internal class DevicesCommand : NmosCommand
    {
        protected override async Task<CommandResult> ExecuteCommandAsync(CommandContext context, string url, string? id = null)
        {
            AnsiConsole.MarkupLine("[green]Getting devices...[/]");

            var client = new NmosClient(url);

            GetAllResponse<Device> response = await client.GetAllDevices();

            if (!ValidateResponse(response))
                return CommandResult.Failure();

            string json = JsonConvert.SerializeObject(response.Data);

            return CommandResult.Success(JToken.Parse(json));
        }
    }
}
