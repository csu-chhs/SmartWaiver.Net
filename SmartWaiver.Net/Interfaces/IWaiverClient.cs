using SmartWaiver.Net.Objects;

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
        Task<SignedWaiver> GetSignedWaiverAsync(string waiverId, bool includePdf = false);

        /// <summary>
        /// This API call will return a SignedWaivers object.  
        /// Which contains a list of SignedWaiver objects
        /// PDF data.
        /// </summary>
        /// <param name="limit">Max number of waivers to return. Default: 20 Max: 300 (Optional)</param>
        /// <param name="verified">Limit selection to waiver that have been verified or not (Optional)</param>
        /// <param name="templateId">Limit selection to signed waivers of the given template ID (Optional)</param>
        /// <param name="fromDts">Show only waivers signed between given dates (Requires 'toDts' parameter). Must be in ISO 8601 format (Optional)</param>
        /// <param name="toDts">Show only waivers signed between given dates (Requires 'fromDts' parameter). Must be in ISO 8601 format (Optional)</param>
        /// <param name="firstName">Limit to waivers with a participant having this First Name (Case Insensitive) (Optional)</param>
        /// <param name="lastName">Limit to waivers with a participant having this Last Name (Case Insensitive) (Optional)</param>
        /// <param name="tag">Limit to waivers with a participant having this as their primary tag (Optional)</param>
        /// <returns></returns>
        SignedWaivers GetSignedWaivers(int? limit = null, bool? verified = null, string templateId = null, DateTime? fromDts = null, DateTime? toDts = null, string firstName = null, string lastName = null, string tag = null);

        /// <summary>
        /// This is a helper method for creating a tagged URL.  This allows
        /// you to pass in custom customer data into the Smart Waiver system
        /// to map waivers to objects on the application side.
        /// </summary>
        /// <param name="waiverId"></param>
        /// <param name="tag"></param>
        /// <returns></returns>
        string GetAutoTaggedWaiverUrl(string waiverId, string tag);

        /// <summary>
        /// List checkins for waivers
        /// </summary>
        /// <param name="fromDts">Limit to checkins after this date(Must not be within the current hour) (If not provided time will default to 00:00:00).</param>
        /// <param name="toDts">Limit to checkins before this date (Must not be within the current hour) (If not provided time will default to 00:00:00).</param>
        /// <param name="limit">Limit to this number of checkins. Default value: 20 Allowed values: 1-100</param>
        /// <param name="offset">Offset to be combined with limit to page results.Default value: 0 Allowed values 0-1000</param>
        /// <returns></returns>
        WaiverCheckins GetWaiverCheckins(DateTime fromDts, DateTime toDts, int? limit = null, int? offset = null);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="waiverId"></param>
        /// <returns></returns>
        WaiverFiles GetWaiverFiles(string waiverId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="waiverId"></param>
        /// <returns></returns>
        WaiverPhotos GetWaiverPhotos(string waiverId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="waiverId"></param>
        /// <returns></returns>
        WaiverSignatures GetWaiverSignatures(string waiverId);
    }
}