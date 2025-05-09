using Newtonsoft.Json;
using RestSharp;
using SmartWaiver.Net.Exceptions;
using SmartWaiver.Net.Interfaces;
using SmartWaiver.Net.Objects;

namespace SmartWaiver.Net.Clients
{
    public class WebhookQueueClient : IWebhookQueueClient
    {
        private readonly RestClient _client;

        public WebhookQueueClient(RestClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Delete Account Message
        /// </summary>
        /// <param name="messageId"></param>
        /// <returns></returns>
        public DeleteAccountMessageResponse DeleteAccountMessage(string messageId)
        {
            var request = new RestRequest("/v4/webhooks/queues/account/{messageId}");
            request.AddUrlSegment("messageId", messageId);

            var response = _client.ExecuteAsync<DeleteAccountMessageResponse>(request, Method.Delete).Result;

            if (response.IsSuccessful)
            {
                return response.Data;
            }

            var ex = new FailedToFetchFromAPIException($"Failed to fetch deleting result", response.ErrorException);
            ex.AddWebTrace(response.Content);
            throw ex;
        }

        /// <summary>
        /// Retrieve Account Message
        /// </summary>
        /// <returns></returns>
        public RetrieveAccountMessageResponse RetrieveAccountMessage()
        {
            var request = new RestRequest("/v4/webhooks/queues/account");

            var response = _client.ExecuteAsync<RetrieveAccountMessageResponse>(request).Result;

            if (response.IsSuccessful)
            {
                return response.Data;
            }

            var ex = new FailedToFetchFromAPIException($"Failed to fetch account messages", response.ErrorException);
            ex.AddWebTrace(response.Content);
            throw ex;
        }
    }
}
