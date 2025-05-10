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
            var retryAfter = response.Headers.FirstOrDefault(fod=>fod.Name=="Retry-After");
            if(retryAfter != null)
                ex.Data.Add("Retry after", retryAfter.Value);
            ex.AddWebTrace(response.Content);
            throw ex;
        }

        public SignedWaivers GetSignedWaivers(int? limit = null, bool? verified = null, string templateId = null, DateTime? fromDts = null, DateTime? toDts = null, string firstName = null, string lastName = null, string tag = null)
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
                request.AddParameter("fromDts", ((DateTime)fromDts).ToString("yyyy-MM-ddTHH:mm:sszzz"));
            }
            if (toDts != null)
            {
                request.AddParameter("toDts", ((DateTime)toDts).ToString("yyyy-MM-ddTHH:mm:sszzz"));
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
            var retryAfter = response.Headers.FirstOrDefault(fod => fod.Name == "Retry-After");
            if (retryAfter != null)
                ex.Data.Add("Retry after", retryAfter.Value);
            ex.AddWebTrace(response.Content);
            throw ex;
        }

        public WaiverCheckins GetWaiverCheckins(DateTime fromDts, DateTime toDts, int? limit = null, int? offset = null)
        {
            var request = new RestRequest("v4/checkins");

            request.AddParameter("fromDts", ((DateTime)fromDts).ToString("yyyy-MM-ddTHH:mm:sszzz"));
            if(toDts.Date == DateTime.Today && toDts.TimeOfDay == TimeSpan.MinValue)
            {
                toDts = toDts.AddHours(DateTime.Now.Hour);
            }
            request.AddParameter("toDts", ((DateTime) toDts).ToString("yyyy-MM-ddTHH:mm:sszzz"));
            if (limit != null)
            {
                request.AddParameter("limit", limit.ToString());
            }
            if (offset != null)
            {
                request.AddParameter("offset", offset.ToString());
            }

            var response = _client.ExecuteAsync<WaiverCheckins>(request).Result;

            if (response.IsSuccessful)
            {
                return response.Data;
            }

            var ex = new FailedToFetchFromAPIException($"Failed to fetch waiver list", response.ErrorException);

            ex.Data.Add("fromDts",fromDts);
            ex.Data.Add("toDts", fromDts);

            if (limit != null)
            {
                ex.Data.Add("limit", limit);
            }
            if (offset != null)
            {
                ex.Data.Add("offset", offset);
            }

            ex.AddWebTrace(response.Content);
            throw ex;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="waiverId"></param>
        /// <returns></returns>
        public WaiverFiles GetWaiverFiles(string waiverId)
        {
            var request = new RestRequest("v4/waivers/{id}/files");
            request.AddUrlSegment("id", waiverId);

            var response = _client.ExecuteAsync<WaiverFiles>(request).Result;

            if (response.IsSuccessful)
            {
                return response.Data;
            }

            var ex = new FailedToFetchFromAPIException($"Failed to fetch waiver files", response.ErrorException);
            ex.AddWebTrace(response.Content);
            throw ex;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="waiverId"></param>
        /// <returns></returns>
        public WaiverPhotos GetWaiverPhotos(string waiverId)
        {
            var request = new RestRequest("v4/waivers/{id}/photos");
            request.AddUrlSegment("id", waiverId);

            var response = _client.ExecuteAsync<WaiverPhotos>(request).Result;

            if (response.IsSuccessful)
            {
                return response.Data;
            }

            var ex = new FailedToFetchFromAPIException($"Failed to fetch waiver photos", response.ErrorException);
            ex.AddWebTrace(response.Content);
            throw ex;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="waiverId"></param>
        /// <returns></returns>
        public WaiverSignatures GetWaiverSignatures(string waiverId)
        {
            var request = new RestRequest("v4/waivers/{id}/signatures");
            request.AddUrlSegment("id", waiverId);

            var response = _client.ExecuteAsync<WaiverSignatures>(request).Result;

            if (response.IsSuccessful)
            {
                return response.Data;
            }

            var ex = new FailedToFetchFromAPIException($"Failed to fetch waiver signatures", response.ErrorException);
            ex.AddWebTrace(response.Content);
            throw ex;
        }
    }
}