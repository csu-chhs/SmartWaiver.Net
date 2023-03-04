using Newtonsoft.Json;

namespace SmartWaiver.Net.Objects
{
    public class SignedWaivers
    {
        public SignedWaivers()
        {

        }

        public string Id { get; set; }
        public DateTime TS { get; set; }
        public string Version { get; set; }
        public string Type { get; set; }

        public List<Waiver> Waivers { get; set; }

    }
}
