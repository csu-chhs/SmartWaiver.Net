using Newtonsoft.Json;

namespace SmartWaiver.Net.Objects
{
    public class SendSmsRequest
    {
        public SendSmsRequest() { }

        [JsonProperty(PropertyName = "templateId")]
        public string TemplateId { get; set; }
        [JsonProperty(PropertyName = "number")]
        public string Number { get; set; }
    }
}
