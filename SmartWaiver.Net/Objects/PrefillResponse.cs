namespace SmartWaiver.Net.Objects
{
    public class PrefillResponse : ResponseBase
    {
        public PrefillResponse() { }

        /// <summary>
        /// Waiver template information
        /// </summary>
        public Prefill Prefill { get; set; }
    }
}
