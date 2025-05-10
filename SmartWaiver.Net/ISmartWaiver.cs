using SmartWaiver.Net.Interfaces;

namespace SmartWaiver.Net
{
    public interface ISmartWaiver
    {
        IWaiverClient Waiver {get;}

        ITemplateClient Template { get;}

        ISearchClient Search { get; }

        ISmsClient Sms { get; }

        IWebhookQueueClient WebhookQueue { get; }
    }
}
