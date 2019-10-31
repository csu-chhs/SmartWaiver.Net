using Newtonsoft.Json;

namespace SmartWaiver.Net.Objects
{
    public class SignedWaiver
    {
        public SignedWaiver()
        {

        }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        public string Version { get; set; }
        public string Type { get; set; }

        public Waiver Waiver { get; set; }

    }
}
