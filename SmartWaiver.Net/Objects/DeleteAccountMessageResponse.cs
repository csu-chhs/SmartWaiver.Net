using Newtonsoft.Json;

namespace SmartWaiver.Net.Objects
{
    public class DeleteAccountMessageResponse : ResponseBase
    {
        public class ApiWebhookAccountMessageDeleteInfo
        {
            /// <summary>
            /// Whether the delete was successful
            /// </summary>
            [JsonProperty(PropertyName = "success")]
            public string Success { get; set; }
        }

        [JsonProperty(PropertyName = "api_webhook_account_message_delete")]
        public ApiWebhookAccountMessageDeleteInfo ApiWebhookAccountMessageDelete { get; set; }
    }
}