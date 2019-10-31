using Newtonsoft.Json;
using RestSharp;
using SmartWaiver.Net.Objects;

namespace SmartWaiver.Net
{
    public class SmartWaiver : ISmartWaiver
    {
        private string _apiKey;
        private readonly string _apiBase = "https://api.smartwaiver.com";
        private readonly string _waiverBase = "https://waiver.smartwaiver.com/";

        public SmartWaiver(string apiKey)
        {
            _apiKey = apiKey;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="waiverId"></param>
        /// <param name="includePdfs"></param>
        /// <returns></returns>
        public SignedWaiver GetSignedWaiver(string waiverId, bool includePdfs = false)
        {
            var client = new RestClient(_apiBase);
            var request = new RestRequest("v4/waivers/{id}", Method.GET);
            request.AddUrlSegment("id", waiverId);
            request.AddParameter("pdf", "true");
            
            // Set the API Key Header
            request.AddHeader("sw-api-key", _apiKey);

            var response = client.Execute<SignedWaiver>(request);

            SignedWaiver waiver = JsonConvert.DeserializeObject<SignedWaiver>(response.Content);
            
            return waiver;
        }

        /// <summary>
        /// 
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
