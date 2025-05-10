using Newtonsoft.Json;
using System.Xml;

namespace SmartWaiver.Net.Objects
{
    public class RetrieveAccountMessageResponse : ResponseBase
    {
        public class PayloadInfo
        {
            /// <summary>
            /// The unique ID of the waiver
            /// </summary>
            [JsonProperty(PropertyName = "unique_id")]
            public string UniqueId { get; set; }

            /// <summary>
            /// The event causing this webhook to be fired
            /// </summary>
            [JsonProperty(PropertyName = "event")]
            public string Event { get; set; }
        }

        public class AccoutnMessageInfo
        {
            public AccoutnMessageInfo() { }

            /// <summary>
            /// Message ID (can be used to delete message)
            /// </summary>
            [JsonProperty(PropertyName = "messageId")]
            public string MessageId { get; set; }

            /// <summary>
            /// The payload containing the payload of the message
            /// </summary>
            [JsonProperty(PropertyName = "payload")]
            public PayloadInfo Payload { get; set; }
        }

        [JsonProperty(PropertyName = "api_webhook_account_message_get")]
        public AccoutnMessageInfo ApiWebhookAccountMessageGet { get; set; }
    }
}