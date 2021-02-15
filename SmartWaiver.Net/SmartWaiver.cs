using Newtonsoft.Json;
using RestSharp;
using SmartWaiver.Net.Interfaces;
using SmartWaiver.Net.Objects;
using SmartWaiver.Net.Clients;

namespace SmartWaiver.Net
{
    public class SmartWaiver : ISmartWaiver
    {
        private string _apiKey;
        private readonly string _apiBase = "https://api.smartwaiver.com";
        private readonly string _waiverBase = "https://waiver.smartwaiver.com/";

        public IWaiverClient Waiver {get;}
        
        public SmartWaiver(string apiKey)
        {
            _apiKey = apiKey;
            var client = new RestClient(_apiBase);
            client.AddDefaultHeader("sw-api-key", _apiKey);
            Waiver = new WaiverClient(client, _waiverBase);
        }

        /// <summary>
        /// This API call will return the SignedWaiver object.  Can pass
        /// includePdf = true in order to get a byte[] array of
        /// PDF data.
        /// </summary>
        /// <param name="waiverId"></param>
        /// <param name="includePdf"></param>
        /// <returns></returns>
        public SignedWaiver GetSignedWaiver(string waiverId, bool includePdf = false)
        {
            var client = new RestClient(_apiBase);
            var request = new RestRequest("v4/waivers/{id}", Method.GET);
            request.AddUrlSegment("id", waiverId);

            if (includePdf)
            {
                request.AddParameter("pdf", "true");
            }
            
            // Set the API Key Header
            request.AddHeader("sw-api-key", _apiKey);

            var response = client.Execute<SignedWaiver>(request);

            SignedWaiver waiver = JsonConvert.DeserializeObject<SignedWaiver>(response.Content);
            
            return waiver;
        }

        /// <summary>
        /// This is a helper method for creating a tagged URL.  This allows
        /// you to pass in custom customer data into the Smart Waiver system
        /// to map waivers to objects on the application side.
        /// </summary>
        /// <param name="waiverId"></param>
        /// <param name="tag"></param>
        /// <returns></returns>
        public string GetAutoTaggedWaiverUrl(string waiverId, string tag)
        {
            return $"{_waiverBase}auto/?auto_waiverid={waiverId}&auto_tag={tag}";
        }
    }
}
