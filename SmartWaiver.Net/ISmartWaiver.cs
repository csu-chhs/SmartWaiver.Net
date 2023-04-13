using SmartWaiver.Net.Interfaces;

namespace SmartWaiver.Net
{
    public interface ISmartWaiver
    {
        IWaiverClient Waiver {get;}

        ITemplateClient Template { get;}
    }
}
