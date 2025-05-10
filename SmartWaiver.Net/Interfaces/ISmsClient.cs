using SmartWaiver.Net.Objects;

namespace SmartWaiver.Net.Interfaces
{
    public interface ISmsClient
    {
        /// <summary>
        /// Send Sms
        /// </summary>
        /// <param name="sendSmsRequest"></param>
        /// <returns></returns>
        SendSmsResponse SendSms(SendSmsRequest sendSmsRequest);        
    }
}