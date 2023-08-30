using SmartWaiver.Net.Objects;

namespace SmartWaiver.Net.Interfaces
{
    public interface ISearchClient
    {
        SearchResponse Search(string templateId, DateTime? fromDts, DateTime? toDts, string firstName, string lastName, bool? verified, string sort, string tag);

        SearchResultsResponse GetSearch(string guid, int page, bool? pdf);
    }
}
