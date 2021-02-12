using SmartWaiver.Net.Objects;
using System.Threading.Tasks;

namespace SmartWaiver.Net.Interfaces
{
    public interface IWaiverClient
    {
        /// <summary>
        /// This API call will return the SignedWaiver object.  Can pass
        /// includePdf = true in order to get a byte[] array of
        /// PDF data.
        /// </summary>
        /// <param name="waiverId"></param>
        /// <param name="includePdf"></param>
        /// <returns></returns>
        SignedWaiver GetSignedWaiver(string waiverId, bool includePdf = false);

        /// <summary>
        /// This API call will return the SignedWaiver object.  Can pass
        /// includePdf = true in order to get a byte[] array of
        /// PDF data.  Async
        /// </summary>
        /// <param name="waiverId"></param>
        /// <param name="includePdf"></param>
        /// <returns></returns>
        Task<SignedWaiver> GetSignWaiverAsync(string waiverId, bool includePdf = false);

        /// <summary>
        /// This is a helper method for creating a tagged URL.  This allows
        /// you to pass in custom customer data into the Smart Waiver system
        /// to map waivers to objects on the application side.
        /// </summary>
        /// <param name="waiverId"></param>
        /// <param name="tag"></param>
        /// <returns></returns>
        string GetAutoTaggedWaiverUrl(string waiverId, string tag);
    }
}