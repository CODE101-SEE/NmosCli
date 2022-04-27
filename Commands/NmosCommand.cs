using Newtonsoft.Json;
using Nmos.Models.Inputs;
using Spectre.Console;
using Spectre.Console.Cli;
using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace Nmos.Commands
{
    internal sealed class NmosSettings : CommandSettings
    {
        [CommandOption("--secure")]
        [DefaultValue(false)]
        public bool Secure { get; set; } = false;

        [CommandOption("--address")]
        [DefaultValue("localhost")]
        public string Address { get; set; } = "localhost";

        [CommandOption("--port")]
        [DefaultValue(3211)]
        public int Port { get; set; } = 3211;

        [CommandOption("--version")]
        [DefaultValue(1.2)]
        public double Version { get; set; } = 1.2;

        [CommandOption("--id")]
        public string Id { get; set; } = string.Empty;
    }

    internal abstract class NmosCommand : AsyncCommand<NmosSettings>
    {
        public override async Task<int> ExecuteAsync(CommandContext context, NmosSettings settings)
        {
            if (string.IsNullOrEmpty(settings.Address))
            {
                AnsiConsole.MarkupLine("[red]No address provided[/]");
                return -1;
            }

            string url = $"{(settings.Secure ? "https://" : "http://")}{settings.Address}:{settings.Port}/x-nmos/query/v{settings.Version.ToString("0.0", System.Globalization.CultureInfo.InvariantCulture)}/";

            if (!Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                AnsiConsole.MarkupLine("[red]Invalid url provided[/]");
                return -1;
            }

            AnsiConsole.MarkupLine($"[green]Connecting to NMOS {new Uri(url)}[/]");

            CommandResult result = default;

            await AnsiConsole.Status()
                .StartAsync("Querying...", async ctx =>
                {
                    result = await ExecuteCommandAsync(context, url, settings.Id);
                });

            AnsiConsole.WriteLine(result.Response?.ToString(Formatting.Indented) ?? string.Empty);

            return (int)result.StatusCode;
        }

        protected abstract Task<CommandResult> ExecuteCommandAsync(CommandContext commandContext, string url, string? id = null);

        protected bool ValidateResponse([NotNullWhen(true)] NmosResponse? response)
        {
            if (response is null) return false;
            if (response.Success) return true;

            foreach (Exception exception in response.Exceptions)
            {
                AnsiConsole.WriteException(exception);
            }

            return false;

        }
    }
}
