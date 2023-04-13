using SmartWaiver.Net.Objects;

namespace SmartWaiver.Net.Interfaces
{
    public  interface ITemplateClient
    {
        TemplatesResponse GetTemplates();

        TemplateResponse GetTemplate(string templateId);

        PrefillResponse Prefill(string templateId, PrefillRequest prefillRequest);
    }
}
