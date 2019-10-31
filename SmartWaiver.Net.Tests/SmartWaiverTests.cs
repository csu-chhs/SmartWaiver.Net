using Xunit;

namespace SmartWaiver.Net.Tests
{
    public class SmartWaiverTests
    {
        [Fact]
        public void VerifyAutoTag()
        {
            string waiverGUID = "4fc7d12601941";
            string autoTag = "1234";

            SmartWaiver smartWaiver = new SmartWaiver("laskdfj");

            Assert.Equal("https://waiver.smartwaiver.com/auto/?auto_waiverid=4fc7d12601941&auto_tag=1234",
                smartWaiver.GetAutoTaggedWaiverUrl(waiverGUID, autoTag));
        }
    }
}
