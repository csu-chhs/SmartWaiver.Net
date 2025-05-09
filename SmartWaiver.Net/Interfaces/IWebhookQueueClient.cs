using SmartWaiver.Net.Objects;

namespace SmartWaiver.Net.Interfaces
{
    public interface IWebhookQueueClient
    {
        /// <summary>
        /// Delete Account Message
        /// </summary>
        /// <param name="messageId"></param>
        /// <returns></returns>
        DeleteAccountMessageResponse DeleteAccountMessage(string messageId);

        /// <summary>
        /// Retrieve Account Message
        /// </summary>
        /// <returns></returns>
        RetrieveAccountMessageResponse RetrieveAccountMessage();
    }
}