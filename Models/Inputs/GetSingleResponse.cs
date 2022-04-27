namespace Nmos.Models.Inputs
{
    public class GetSingleResponse<T> : NmosResponse
    {
        public T? Data { get; set; }
    }
}