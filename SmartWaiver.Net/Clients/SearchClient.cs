using SmartWaiver.Net.Interfaces;
using RestSharp;
using SmartWaiver.Net.Objects;
using SmartWaiver.Net.Exceptions;

namespace SmartWaiver.Net.Clients
{
    public class SearchClient : ISearchClient
    {
        private readonly RestClient _client;
        private readonly string _waiverBase;

        public SearchClient(RestClient client)
        {
            _client = client;
        }

        public SearchResponse Search(string templateId = null, DateTime? fromDts = null, DateTime? toDts = null, string firstName = null, string lastName = null, bool? verified = null, string sort = null, string tag = null)
        {
            var request = new RestRequest("v4/search");

            if(templateId != null)
            {
                request.AddParameter("templateId", templateId);
            }
            if(fromDts != null )
            {
                request.AddParameter("fromDts", ((DateTime)fromDts).ToString("yyyy-MM-ddTHH:mm:sszzz"));
            }

            if(toDts != null)
            {
                request.AddParameter("toDts", ((DateTime)toDts).ToString("yyyy-MM-ddTHH:mm:sszzz"));
            }

            if(firstName != null)
            {
                request.AddParameter("firstName", firstName);
            }

            if(lastName != null)
            {
                request.AddParameter("lastName", lastName);
            }

            if(verified != null)
            {
                request.AddParameter("verified", verified.ToString());
            }

            if(sort !=null)
            {
                request.AddParameter("sort", sort);
            }

            if(tag != null)
            {
                request.AddParameter("tag", tag);
            }

            var response = _client.ExecuteAsync<SearchResponse>(request).Result;

            if (response.IsSuccessful)
            {
                return response.Data;
            }

            var ex = new FailedToFetchFromAPIException($"Failed to fetch search",
                response.ErrorException);
            if(templateId != null)
            {
                ex.Data.Add("Template Id", templateId);
            }
            if(fromDts != null)
            {
                ex.Data.Add("From Dts", fromDts);
            }
            if(toDts != null)
            {
                ex.Data.Add("To Dts", toDts);
            }
            if(firstName != null)
            {
                ex.Data.Add("First name", firstName);
            }
            if(lastName != null)
            {
                ex.Data.Add("Last Name", lastName);
            }
            if(verified != null)
            {
                ex.Data.Add("Verified", verified);
            }
            if(sort != null)
            {
                ex.Data.Add("Sort", sort);
            }
            if(tag != null)
            {
                ex.Data.Add("Tag", tag);
            }            
            ex.AddWebTrace(response.Content);
            throw ex;
        }

        public async Task<SearchResultsResponse> GetSearchAsync(string guid, int page = 0, bool? pdf = false)
        {
            var request = new RestRequest("v4/search/{guid}/results");

            request.AddUrlSegment("guid", guid);

            request.AddParameter("page", page);

            if(pdf != null)
            {
                request.AddParameter("pdf", pdf.ToString().ToLower());
            }
            var response = await _client.ExecuteAsync<SearchResultsResponse>(request);

            if (response.IsSuccessful)
            {
                return response.Data;
            }

            var ex = new FailedToFetchFromAPIException($"Failed to fetch search results {guid}", response.ErrorException);
            
            ex.Data.Add("Guid", guid);
            ex.Data.Add("Page", page);
            if(pdf !=null){
                ex.Data.Add("Pdf", pdf);
            }
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
    }
}