using Nmos.Models.Inputs;
using Nmos.Models.v1._3._1;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nmos.Clients
{
    public class NmosClient : INmosClient
    {
        private readonly RestClient _client;

        public const string DevicesUrl = "devices";
        public const string NodesUrl = "nodes";
        public const string SourcesUrl = "sources";
        public const string FlowsUrl = "flows";
        public const string SendersUrl = "senders";
        public const string ReceiversUrl = "receivers";
        public const string SubscriptionUrl = "subscriptions";

        public NmosClient(string url)
        {
            _client = new RestClient(url);
            _client.UseNewtonsoftJson();
            _client.AddDefaultHeader("Cache-Control", "no-cache");
        }

        public async Task<GetAllResponse<Device>> GetAllDevices()
        {
            return await GetAllAsync<Device>(DevicesUrl);
        }

        public async Task<GetSingleResponse<Device>> GetDevice(string id)
        {
            return await GetSingleAsync<Device>(DevicesUrl, id);
        }

        public async Task<GetAllResponse<Node>> GetAllNodes()
        {
            return await GetAllAsync<Node>(NodesUrl);
        }

        public async Task<GetSingleResponse<Node>> GetNode(string id)
        {
            return await GetSingleAsync<Node>(NodesUrl, id);
        }

        public async Task<GetAllResponse<Source>> GetAllSources()
        {
            return await GetAllAsync<Source>(SourcesUrl);
        }

        public async Task<GetSingleResponse<Source>> GetSource(string id)
        {
            return await GetSingleAsync<Source>(SourcesUrl, id);
        }

        public async Task<GetAllResponse<Subscription>> GetAllSubscriptions()
        {
            return await GetAllAsync<Subscription>(SubscriptionUrl);
        }

        public async Task<GetSingleResponse<Subscription>> GetSubscription(string id)
        {
            return await GetSingleAsync<Subscription>(SubscriptionUrl, id);
        }

        public async Task<GetAllResponse<Receiver>> GetAllReceivers()
        {
            return await GetAllAsync<Receiver>(ReceiversUrl);
        }

        public async Task<GetSingleResponse<Receiver>> GetReceiver(string id)
        {
            return await GetSingleAsync<Receiver>(ReceiversUrl, id);
        }

        public async Task<GetAllResponse<Sender>> GetAllSenders()
        {
            var result = await GetAllAsync<Sender>(SendersUrl);
            foreach (var sender in result.Data)
            {
                if (!string.IsNullOrEmpty(sender.FlowId))
                    sender.Flow = (await GetFlow(sender.FlowId)).Data;
            }
            return result;
        }

        public async Task<GetSingleResponse<Sender>> GetSender(string id)
        {
            var result = await GetSingleAsync<Sender>(SendersUrl, id);
            if (!string.IsNullOrEmpty(result.Data.FlowId))
                result.Data.Flow = (await GetFlow(result.Data.FlowId)).Data;
            return result;
        }

        public async Task<GetAllResponse<Flow>> GetAllFlows()
        {
            return await GetAllAsync<Flow>(FlowsUrl);
        }

        public async Task<GetSingleResponse<Flow>> GetFlow(string id)
        {
            return await GetSingleAsync<Flow>(FlowsUrl, id);
        }

        public async Task<GetSingleResponse<SenderConfiguration>> GetSenderActiveConfigurationAsync(string endpoint, string senderId)
        {
            string url = $"{endpoint}/single/senders/{senderId}/active";

            return await GetSingleAsync<SenderConfiguration>(url);
        }

        public GetSingleResponse<SenderConfiguration> GetSenderActiveConfiguration(string endpoint, string senderId)
        {
            string url = $"{endpoint}/single/senders/{senderId}/active";

            return GetSingle<SenderConfiguration>(url);
        }

        public async Task<GetSingleResponse<string>> GetSenderTransportFileAsync(string endpoint, string senderId)
        {
            string url = $"{endpoint}/single/senders/{senderId}/transportfile";

            var response = new GetSingleResponse<string> { Endpoint = url };
            try
            {
                var request = new RestRequest(url);
                request.Method = Method.GET;
                var res = await _client.ExecuteAsync(request);
                response.Data = res.Content;
                response.Success = res.IsSuccessful;
                if (!res.IsSuccessful)
                    response.Exceptions = new List<Exception> { new InvalidOperationException($"API returned null for {url}") };
            }
            catch (Exception e)
            {
                response.Exceptions = new List<Exception> { e };
            }

            return response;
        }


        public async Task<GetSingleResponse<ReceiverConfiguration>> GetReceiverActiveConfigurationAsync(string endpoint, string receiverId)
        {
            string url = $"{endpoint}/single/receivers/{receiverId}/active";

            return await GetSingleAsync<ReceiverConfiguration>(url);
        }

        public async Task<GetSingleResponse<T>> GetSingleAsync<T>(string endpoint, string id)
        {
            var response = new GetSingleResponse<T> { Endpoint = $"{_client.BaseUrl?.AbsoluteUri}{endpoint}/{id}" };
            try
            {
                var request = new RestRequest($"{endpoint}/{id}", DataFormat.Json);
                request.Timeout = 1000;
                var res = await _client.GetAsync<T>(request);
                response.Data = res;
                response.Success = res is not null;
                if (res is null)
                    response.Exceptions = new List<Exception> { new InvalidOperationException($"API returned null for {endpoint} {id}") };
            }
            catch (Exception e)
            {
                response.Exceptions = new List<Exception> { e };
            }

            return response;
        }


        public GetSingleResponse<T> GetSingle<T>(string endpoint)
        {
            var response = new GetSingleResponse<T> { Endpoint = endpoint };
            try
            {
                var request = new RestRequest(endpoint, DataFormat.Json);
                var res = _client.Get<T>(request);
                response.Data = res.Data;
                response.Success = res.IsSuccessful;
                if (!res.IsSuccessful)
                    response.Exceptions = new List<Exception> { new InvalidOperationException($"API returned null for {endpoint}") };
            }
            catch (Exception e)
            {
                response.Exceptions = new List<Exception> { e };
            }

            return response;
        }

        public async Task<GetSingleResponse<T>> GetSingleAsync<T>(string endpoint)
        {
            var response = new GetSingleResponse<T> { Endpoint = endpoint };
            try
            {
                var request = new RestRequest(endpoint, DataFormat.Json);
                var res = await _client.GetAsync<T>(request);
                response.Data = res;
                response.Success = res is not null;
                if (res is null)
                    response.Exceptions = new List<Exception> { new InvalidOperationException($"API returned null for {endpoint}") };
            }
            catch (Exception e)
            {
                response.Exceptions = new List<Exception> { e };
            }

            return response;
        }

        public async Task<GetAllResponse<T>> GetAllAsync<T>(string endpoint)
        {
            var response = new GetAllResponse<T> { Endpoint = $"{_client.BaseUrl?.AbsoluteUri}{endpoint}" };
            try
            {
                var request = new RestRequest(endpoint, DataFormat.Json);
                request.Timeout = 1000;
                var res = await _client.GetAsync<List<T>>(request);
                response.Data = res;
                response.Success = res is not null;
                if (res is null)
                    response.Exceptions = new List<Exception> { new InvalidOperationException($"API returned null for {endpoint}") };
            }
            catch (Exception e)
            {
                response.Exceptions = new List<Exception> { e };
            }


            return response;
        }
    }
}
