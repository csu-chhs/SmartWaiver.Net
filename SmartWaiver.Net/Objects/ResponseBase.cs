namespace SmartWaiver.Net.Objects
{
    public class ResponseBase
    {
        public ResponseBase() { }

        /// <summary>
        /// API version number
        /// </summary>
        public int Version { get; set; }
        /// <summary>
        /// Uuid for request (32 characters)
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Timestamp of request
        /// </summary>
        public DateTime TS { get; set; }
        /// <summary>
        /// Type of response given
        /// </summary>
        public string Type { get; set; }
    }
}
