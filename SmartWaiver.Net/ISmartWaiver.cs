using SmartWaiver.Net.Objects;
using SmartWaiver.Net.Interfaces;
using System;

namespace SmartWaiver.Net
{
    public interface ISmartWaiver
    {
        [Obsolete("Use new Waiver client")]
        SignedWaiver GetSignedWaiver(string waiverId, bool includePdf = false);

        [Obsolete("Use new Waiver client")]
        string GetAutoTaggedWaiverUrl(string waiverId, string tag);
        IWaiverClient Waiver {get;}
    }
}
