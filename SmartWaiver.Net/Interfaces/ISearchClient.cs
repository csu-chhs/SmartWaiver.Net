using SmartWaiver.Net.Objects;

namespace SmartWaiver.Net.Interfaces
{
    public interface ISearchClient
    {
        SearchResponse Search(string templateId = null, DateTime? fromDts = null, DateTime? toDts = null, string firstName = null, string lastName = null, bool? verified = null, string sort = null, string tag = null);

        Task<SearchResultsResponse> GetSearchAsync(string guid, int page = 0, bool? pdf = false);
    }
}
