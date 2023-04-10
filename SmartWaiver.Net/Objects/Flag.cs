namespace SmartWaiver.Net.Objects
{
    public class Flag
    {
        public Flag() { }

        /// <summary>
        /// The display text for the flagged question
        /// </summary>
        public string DisplayText { get; set; }
        /// <summary>
        /// The reason this answer was flagged
        /// </summary>
        public string Reason { get; set; }
    }
}
