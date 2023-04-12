using Newtonsoft.Json;

namespace SmartWaiver.Net.Objects
{
    public class GUID
    {
        public GUID() { }

        /// <summary>
        /// The value of the custom participant field
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        /// <summary>
        /// The display text of the custom participant field
        /// (Not used in prefill)
        /// </summary>
        [JsonProperty(PropertyName = "displayText")]
        public string DisplayText { get; set; }
    }
}
