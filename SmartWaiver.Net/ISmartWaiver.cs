using SmartWaiver.Net.Objects;

namespace SmartWaiver.Net
{
    public interface ISmartWaiver
    {
        SignedWaiver GetSignedWaiver(string waiverId, bool includePdf = false);
        string GetAutoTaggedWaiverUrl(string waiverId, string tag);
    }
}
