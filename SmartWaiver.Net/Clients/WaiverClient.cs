using SmartWaiver.Net.Interfaces;
using RestSharp;
using SmartWaiver.Net.Objects;
using SmartWaiver.Net.Exceptions;

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
            var request = new RestRequest("v4/waivers/{id}");
            request.AddUrlSegment("id", waiverId);

            if (includePdf)
            {
                request.AddParameter("pdf", "true");
            }

            var response = _client.ExecuteAsync<SignedWaiver>(request).Result;

            if (response.IsSuccessful)
            {
                return response.Data;
            }

            var ex = new FailedToFetchFromAPIException($"Failed to fetch waiver {waiverId}",
                response.ErrorException);
            ex.Data.Add("Waiver Id", waiverId);
            ex.AddWebTrace(response.Content);
            throw ex;
        }

        public SignedWaivers GetSignedWaivers(int? limit = null, bool? verified = null, string? templateId = null, DateTime? fromDts = null, DateTime? toDts = null, string? firstName = null, string? lastName = null, string? tag = null)
        {
            var request = new RestRequest("v4/waivers");

            if (limit != null)
            {
                request.AddParameter("limit", limit.ToString());
            }
            if (verified != null)
            {
                request.AddParameter("verified", verified.ToString().ToLower());
            }
            if (templateId != null)
            {
                request.AddParameter("templateId", templateId.ToString().ToLower());
            }
            if (fromDts != null)
            {
                request.AddParameter("fromDts", ((DateTime)fromDts).ToString("yyyy-MM-ddTHH:mm:ss.zzz"));
            }
            if (toDts != null)
            {
                request.AddParameter("toDts", ((DateTime)toDts).ToString("yyyy-MM-ddTHH:mm:ss.zzz"));
            }
            if (firstName != null)
            {
                request.AddParameter("firstName", firstName);
            }
            if (lastName != null)
            {
                request.AddParameter("lastName", lastName);
            }
            if (tag != null)
            {
                request.AddParameter("tag", tag);
            }

            var response = _client.ExecuteAsync<SignedWaivers>(request).Result;

            if (response.IsSuccessful)
            {
                return response.Data;
            }

            var ex = new FailedToFetchFromAPIException($"Failed to fetch waiver list", response.ErrorException);
            if (limit != null)
            {
                ex.Data.Add("limit", limit);
            }
            if (verified != null)
            {
                ex.Data.Add("verified", verified);
            }
            if (templateId != null)
            {
                ex.Data.Add("templateId", templateId);
            }
            if (fromDts != null)
            {
                ex.Data.Add("fromDts", fromDts);
            }
            if (toDts != null)
            {
                ex.Data.Add("toDts", toDts);
            }
            if (firstName != null)
            {
                ex.Data.Add("firstName", firstName);
            }
            if (lastName != null)
            {
                ex.Data.Add("lastName", lastName);
            }
            if (tag != null)
            {
                ex.Data.Add("tag", tag);
            }

            ex.AddWebTrace(response.Content);
            throw ex;
        }

        public async Task<SignedWaiver> GetSignedWaiverAsync(string waiverId, bool includePdf = false)
        {
            var request = new RestRequest("v4/waivers/{id}");
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

            var ex = new FailedToFetchFromAPIException($"Failed to fetch waiver {waiverId}",
                response.ErrorException);
            ex.Data.Add("Waiver Id", waiverId);
            ex.AddWebTrace(response.Content);
            throw ex;
        }

        public async Task<SignedWaivers> GetSignedWaiverListAsync(int? limit = null, bool? verified = null, string? templateId = null, DateTime? fromDts = null, DateTime? toDts = null, string? firstName = null, string? lastName = null, string? tag = null)
        {
            var request = new RestRequest("v4/waivers");

            if (limit!=null)
            {
                request.AddParameter("limit", limit.ToString());
            }
            if(verified!=null)
            {
                request.AddParameter("verified", verified.ToString().ToLower());
            }
            if(templateId!=null)
            {
                request.AddParameter("templateId", templateId.ToString().ToLower());
            }
            if(fromDts!=null)
            {
                request.AddParameter("fromDts", ((DateTime)fromDts).ToString("yyyy-MM-ddThh:mm:ss.zzz"));
            }
            if (toDts != null)
            {
                request.AddParameter("toDts", ((DateTime)toDts).ToString("yyyy-MM-ddThh:mm:ss.zzz"));
            }
            if(firstName!=null)
            {
                request.AddParameter("firstName", firstName);
            }
            if(lastName!=null)
            {
                request.AddParameter("lastName", lastName);
            }
            if(tag!=null)
            {
                request.AddParameter("tag", tag);
            }

            var response = await _client.ExecuteAsync<SignedWaivers>(request);

            if (response.IsSuccessful)
            {
                return response.Data;
            }

            var ex = new FailedToFetchFromAPIException($"Failed to fetch waiver list", response.ErrorException);
            if (limit != null)
            {
                ex.Data.Add("limit", limit);
            }

            ex.AddWebTrace(response.Content);
            throw ex;
        }

    }
}