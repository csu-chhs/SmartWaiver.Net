using Newtonsoft.Json;

namespace SmartWaiver.Net.Objects
{
    public class SignedWaivers : ResponseBase
    {
        public SignedWaivers()
        {

        }

        public List<Waiver> Waivers { get; set; }

    }
}
