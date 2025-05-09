using Newtonsoft.Json;
using RestSharp;
using SmartWaiver.Net.Exceptions;
using SmartWaiver.Net.Interfaces;
using SmartWaiver.Net.Objects;

namespace SmartWaiver.Net.Clients
{
    public class SmsClient : ISmsClient
    {
        private readonly RestClient _client;

        public SmsClient(RestClient client)
        {
            _client = client;
        }

        public SendSmsResponse SendSms(SendSmsRequest sendSmsRequest)
        {
            var request = new RestRequest("v4/sms");

            request.AddJsonBody
            (
                JsonConvert.SerializeObject
                (
                    sendSmsRequest,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        DateFormatString = "yyyy-MM-dd"
                    }
                )
            );

            var response = _client.ExecuteAsync<SendSmsResponse>(request, Method.Post).Result;

            if (response.IsSuccessful)
            {
                return response.Data;
            }

            var ex = new FailedToFetchFromAPIException($"Failed to fetch sending result", response.ErrorException);
            ex.AddWebTrace(response.Content);
            throw ex;
        }
    }
}
