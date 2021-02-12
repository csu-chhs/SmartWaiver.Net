using SmartWaiver.Net.Objects;
using SmartWaiver.Net.Interfaces;

namespace SmartWaiver.Net
{
    public interface ISmartWaiver
    {
        SignedWaiver GetSignedWaiver(string waiverId, bool includePdf = false);
        string GetAutoTaggedWaiverUrl(string waiverId, string tag);
        IWaiverClient Waiver {get;}
    }
}
