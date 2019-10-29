using System;
using System.Collections.Generic;
using System.Text;
using SmartWaiver.Net.Objects;

namespace SmartWaiver.Net
{
    public interface ISmartWaiver
    {
        SignedWaiver GetSignedWaiver(string waiverId);
    }
}
