using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SmartWaiver.Net.Objects
{
    public class Participant
    {
        public Participant() { }

        /// <summary>
        /// The first name of the participant
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The middle name of the participant
        /// </summary>
        public string MiddleName { get; set; }
        /// <summary>
        /// The last name of the participant
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Date of birth of the participant. Note: The DOB will be 1800-01-01 if the waiver is set up to use a checkbox for age verification.
        /// </summary>
        public DateTime DOB { get; set; }
        /// <summary>
        /// Whether or not this participant is a minor
        /// </summary>
        public bool IsMinor { get; set; }
        /// <summary>
        /// True if this participant is a minor and has passed age of majority and age of majority expiration turned on, false otherwise
        /// </summary>
        public bool MinorExpired { get; set; }
        /// <summary>
        /// Gender of the participant
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// Phone number of the participant
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// A list of tags for the participant
        /// </summary>
        public List<string> Tags { get; set; }
        /// <summary>
        /// Any custom participant fields on the waiver
        /// </summary>
        public CustomParticipantField CustomParticipantFields { get; set; }
        /// <summary>
        /// A list of flags for this participant
        /// </summary>
        public List<Flag> Flags { get; set; }  
    }
}
