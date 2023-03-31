using Newtonsoft.Json;

namespace SmartWaiver.Net.Objects
{
    public class Participant
    {
        public Participant() { }

        /// <summary>
        /// The first name of the participant
        /// </summary>
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }
        /// <summary>
        /// The middle name of the participant
        /// </summary>
        [JsonProperty(PropertyName = "middleName")]
        public string MiddleName { get; set; }
        /// <summary>
        /// The last name of the participant
        /// </summary>
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }
        /// <summary>
        /// Date of birth of the participant. Note: The DOB will be 1800-01-01 if the waiver is set up to use a checkbox for age verification.
        /// </summary>
        [JsonProperty(PropertyName = "dob")]
        public DateTime? DOB { get; set; }
        /// <summary>
        /// Whether or not this participant is a minor
        /// </summary>
        [JsonProperty(PropertyName = "isMinor")]
        public bool? IsMinor { get; set; }
        /// <summary>
        /// True if this participant is a minor and has passed age of majority and age of majority expiration turned on, false otherwise
        /// </summary>
        [JsonProperty(PropertyName = "minorExpired")]
        public bool? MinorExpired { get; set; }
        /// <summary>
        /// Gender of the participant
        /// </summary>        
        [JsonProperty(PropertyName = "gender")]
        public string Gender { get; set; }
        /// <summary>
        /// Phone number of the participant
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }
        /// <summary>
        /// A list of tags for the participant
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public List<string> Tags { get; set; }
        /// <summary>
        /// Any custom participant fields on the waiver
        /// </summary>
        [JsonProperty(PropertyName = "customParticipantFields")]
        public Dictionary<string, GUID> CustomParticipantFields { get; set; }
        /// <summary>
        /// A list of flags for this participant
        /// </summary>
        [JsonProperty(PropertyName = "flags")]
        public List<Flag> Flags { get; set; }  
    }
}
