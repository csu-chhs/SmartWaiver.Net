using SmartWaiver.Net.Interfaces;
using RestSharp;
using SmartWaiver.Net.Objects;
using SmartWaiver.Net.Exceptions;
using System.Threading.Tasks;

namespace SmartWaiver.Net.Clients
{
    public class WaiverClient : IWaiverClient
    {
        private readonly RestClient _client;
        private readonly string _waiverBase;

        public WaiverClient(RestClient client,
            string waiverBase)
        {
            _client = client;
            _waiverBase = waiverBase;
        }

        public string GetAutoTaggedWaiverUrl(string waiverId, string tag)
        {
            return $"{_waiverBase}auto/?auto_waiverid={waiverId}&auto_tag={tag}";
        }

        public SignedWaiver GetSignedWaiver(string waiverId, bool includePdf = false)
        {
            var request = new RestRequest("v4/waivers/{id}", Method.GET);
            request.AddUrlSegment("id", waiverId);

            if (includePdf)
            {
                request.AddParameter("pdf", "true");
            }

            var response = _client.Execute<SignedWaiver>(request);

            if (response.IsSuccessful)
            {
                return response.Data;
            }

            throw new FailedToFetchFromAPIException($"Failed to fetch waiver {waiverId}",
                response.ErrorException);
        }

        public async Task<SignedWaiver> GetSignWaiverAsync(string waiverId, bool includePdf = false)
        {
            var request = new RestRequest("v4/waivers/{id}", Method.GET);
            request.AddUrlSegment("id", waiverId);

            if (includePdf)
            {
                request.AddParameter("pdf", "true");
            }
            
            var response = await _client.ExecuteAsync<SignedWaiver>(request);
            
            if(response.IsSuccessful)
            {
                return response.Data;
            }

            throw new FailedToFetchFromAPIException($"Failed to fetch waiver {waiverId}",
                response.ErrorException);
        }
    }
}