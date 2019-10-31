using SmartWaiver.Net.Objects;

namespace SmartWaiver.Net.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartWaiver smartWaiver = new SmartWaiver("34e446e551c172f97870effec2a84ac5");

            SignedWaiver waiver = smartWaiver.GetSignedWaiver("52jUgokGxvJFdnhkw7zJHF");
        }
    }
}
