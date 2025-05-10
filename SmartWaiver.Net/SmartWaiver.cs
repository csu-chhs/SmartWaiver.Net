using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using SmartWaiver.Net.Interfaces;
using SmartWaiver.Net.Clients;

namespace SmartWaiver.Net
{
    public class SmartWaiver : ISmartWaiver
    {
        private string _apiKey;
        private readonly string _apiBase = "https://api.smartwaiver.com";
        private readonly string _waiverBase = "https://waiver.smartwaiver.com/";

        public IWaiverClient Waiver {get;}

        public ITemplateClient Template { get; }

        public ISearchClient Search { get; }

        public ISmsClient Sms { get; }

        public IWebhookQueueClient WebhookQueue { get; }

        public SmartWaiver(string apiKey)
        {
            _apiKey = apiKey;
            var client = new RestClient(_apiBase,
                configureSerialization: s => s.UseNewtonsoftJson());
            client.AddDefaultHeader("sw-api-key", _apiKey);
            Waiver = new WaiverClient(client, _waiverBase);
            Template = new TemplateClient(client);
            Search = new SearchClient(client);
            Sms = new SmsClient(client);
            WebhookQueue = new WebhookQueueClient(client);
        }
    }
}
