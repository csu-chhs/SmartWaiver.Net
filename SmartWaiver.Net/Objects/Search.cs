namespace SmartWaiver.Net.Objects
{
    public class Search
    {
        public Search()
        {

        }

        /// <summary>
        /// GUID used to retrieve search results
        /// </summary>
        public string GUID { get; set; }

        /// <summary>
        /// The number of waivers in the search results
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// The number of pages in the search results
        /// </summary>
        public int Pages { get; set; }

        /// <summary>
        /// The number of waivers in each page of results
        /// Currently, always 100
        /// </summary>
        public int PageSize { get; set; }
    }
}