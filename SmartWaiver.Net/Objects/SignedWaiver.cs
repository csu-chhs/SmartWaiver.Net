using Newtonsoft.Json;

namespace SmartWaiver.Net.Objects
{
    public class SignedWaiver : ResponseBase
    {
        public SignedWaiver()
        {

        }

        public Waiver Waiver { get; set; }

    }
}
