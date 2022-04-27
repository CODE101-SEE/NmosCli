using Newtonsoft.Json.Linq;

namespace Nmos.Commands
{
    public enum StatusCode
    {
        Failed = -1,
        Success = 0,
    }

    public struct CommandResult
    {
        public CommandResult(StatusCode statusCode, JToken? response)
        {
            StatusCode = statusCode;
            Response = response;
        }

        public StatusCode StatusCode { get; set; }
        public JToken? Response { get; set; }

        public static CommandResult Success(JToken? response = null)
        {
            return new CommandResult(StatusCode.Success, response);
        }

        public static CommandResult Failure(JToken? response = null)
        {
            return new CommandResult(StatusCode.Failed, response);
        }
    }
}
