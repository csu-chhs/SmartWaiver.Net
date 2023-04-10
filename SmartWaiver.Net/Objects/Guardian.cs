using Newtonsoft.Json;

namespace SmartWaiver.Net.Objects
{
    public class Guardian
    {
        public Guardian() 
        { 
        }

        /// <summary>
        /// Whether the guardian is a participant or not (Default value: false)
        /// (Only used with prefill)
        /// </summary>
        [JsonProperty(PropertyName = "participant")]
        public bool? Participant { get; set; }
        /// <summary>
        /// The first name of the guardian
        /// </summary>
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }
        /// <summary>
        /// The middle name of the guardian
        /// </summary>
        [JsonProperty(PropertyName = "middleName")]
        public string MiddleName { get; set; }
        /// <summary>
        /// The last name of the guardian
        /// </summary>
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }
        /// <summary>
        /// The phone number of the guardian
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }
        /// <summary>
        /// The guardian's gender (if they are a participant)
        /// </summary>
        [JsonProperty(PropertyName = "gender")]
        public string Gender { get; set; }
        /// <summary>
        /// The relationship of the guardian to the minors
        /// </summary>
        [JsonProperty(PropertyName = "relationship")]
        public string Relationship { get; set; }
        /// <summary>
        /// Date of birth of the guardian. (1800-01-01 if checkbox is used)
        /// </summary>
        [JsonProperty(PropertyName = "dob")]
        public DateTime? DOB { get; set; }
    }
}
