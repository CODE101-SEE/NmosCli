using Nmos.Models.Inputs;
using Nmos.Models.v1._3._1;
using System.Threading.Tasks;

namespace Nmos.Clients
{
    public interface INmosClient
    {
        Task<GetAllResponse<Device>> GetAllDevices();
        Task<GetSingleResponse<Device>> GetDevice(string id);

        Task<GetAllResponse<Node>> GetAllNodes();
        Task<GetSingleResponse<Node>> GetNode(string id);

        Task<GetAllResponse<Source>> GetAllSources();
        Task<GetSingleResponse<Source>> GetSource(string id);

        Task<GetAllResponse<Subscription>> GetAllSubscriptions();
        Task<GetSingleResponse<Subscription>> GetSubscription(string id);

        Task<GetAllResponse<Receiver>> GetAllReceivers();
        Task<GetSingleResponse<Receiver>> GetReceiver(string id);

        Task<GetAllResponse<Sender>> GetAllSenders();
        Task<GetSingleResponse<Sender>> GetSender(string id);

        Task<GetAllResponse<Flow>> GetAllFlows();
        Task<GetSingleResponse<Flow?>> GetFlow(string id);

        Task<GetSingleResponse<T>> GetSingleAsync<T>(string endpoint, string id);
        Task<GetAllResponse<T>> GetAllAsync<T>(string endpoint);

        Task<GetSingleResponse<SenderConfiguration>> GetSenderActiveConfigurationAsync(string endpoint, string senderId);
        Task<GetSingleResponse<string>> GetSenderTransportFileAsync(string endpoint, string senderId);

        Task<GetSingleResponse<ReceiverConfiguration>> GetReceiverActiveConfigurationAsync(string endpoint, string receiverId);
    }
}