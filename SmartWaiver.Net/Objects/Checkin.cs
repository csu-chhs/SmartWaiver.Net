namespace SmartWaiver.Net.Objects
{
    public class Checkin
    {
        /// <summary>
        /// The date this check-in occurred 
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// The Unique ID for the waiver this participant check-in is from
        /// </summary>
        public string WaiverId { get; set; }
        /// <summary>
        /// The position in the participant array if your retrieve this waiver's data. (Note: 0 based and -1 means this participant is the guardian)
        /// </summary>
        public int Position { get; set; }
        /// <summary>
        /// The first name of this participant
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The last name of this participant
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Whether this participant is a minor or not
        /// </summary>
        public bool IsMinor { get; set; }
        public Checkin() { }
    }
}
