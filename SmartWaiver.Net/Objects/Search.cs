namespace SmartWaiver.Net.Objects
{
    public class Search
    {
        public Search()
        {

        }

        public string GUID { get; set; }
        public int Count { get; set; }
        public int Pages { get; set; }
        public int PageSize { get; set; }
    }
}