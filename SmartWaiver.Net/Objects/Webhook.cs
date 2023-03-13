namespace SmartWaiver.Net.Objects
{
    public class Webhook
    {
        /// <summary>
        /// An object containing information about the template level webhook or null if no webhook is set up
        /// </summary>
        public Webhook() { }

        /// <summary>
        /// Endpoint URL for webhook
        /// </summary>
        public string Endpoint { get; set; }
        /// <summary>
        /// Webhook is sent after email verification (yes), before (no)
        /// </summary>
        public string EmailValidationRequired { get; set; }
    }
}
