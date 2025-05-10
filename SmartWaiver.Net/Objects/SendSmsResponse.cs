using Newtonsoft.Json;

namespace SmartWaiver.Net.Objects
{
    public class SendSmsResponse : ResponseBase
    {
        public class TemplateInfo
        {
            /// <summary>
            /// Sms template information
            /// </summary>
            public TemplateInfo() { }

            /// <summary>
            /// Unique Id of the waiver sent
            /// </summary>
            [JsonProperty(PropertyName = "uuid")]
            public string Uuid { get; set; }
            /// <summary>
            /// Title of waiver sent
            /// </summary>
            [JsonProperty(PropertyName = "title")]
            public string Title { get; set; }
        }

        public class SmsInfo
        {
            /// <summary>
            /// Sms result information
            /// </summary>
            public SmsInfo() { }

            /// <summary>
            /// Unique ID of SMS message
            /// </summary>
            [JsonProperty(PropertyName = "id")]
            public string Id { get; set; }
            /// <summary>
            /// Formatted Number Waiver was sent to
            /// </summary>
            [JsonProperty(PropertyName = "phone")]
            public string Phone { get; set; }
            /// <summary>
            /// Waiver Template Details
            /// </summary>
            [JsonProperty(PropertyName = "template")]
            public TemplateInfo Template { get; set; }
            /// <summary>
            /// Status code of SMS sending protocol (1: Success)
            /// </summary>           
            [JsonProperty(PropertyName = "status")]
            public string Status { get; set; }
            /// <summary>
            /// Date the SMS message was sent.
            /// </summary>
            [JsonProperty(PropertyName = "date")]
            public string Date { get; set; }
        }

        [JsonProperty(PropertyName = "sms")]
        public SmsInfo Sms {get; set;}
    }
}
