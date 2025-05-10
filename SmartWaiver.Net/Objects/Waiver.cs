namespace SmartWaiver.Net.Objects
{
    public class Waiver
    {
        /// <summary>
        /// Signed waiver information
        /// </summary>
        public Waiver()
        {

        }
        /// <summary>
        /// Unique ID of signed waiver
        /// </summary>
        public string WaiverId { get; set; }
        /// <summary>
        /// Unique ID of template for this signed waiver
        /// </summary>
        public string TemplateId { get; set; }
        /// <summary>
        /// Title of waiver
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// PrefillId for waiver if it exist, null if there is not one
        /// </summary>
        public string PrefillId { get; set; }
        /// <summary>
        /// Date waiver was signed
        /// </summary>
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// Date waiver will expire. Note: This value is always empty if your account does not have the days to expiration setting enabled in the waiver console
        /// </summary>
        public DateTime ExpirationDate { get; set; }
        /// <summary>
        /// If this waiver is older than your account's static expiration date or is past your account setting for days to expiration from signing date
        /// </summary>
        public bool Expired { get; set; }
        /// <summary>
        /// If the waiver has been verified
        /// </summary>
        public bool Verified { get; set; }
        /// <summary>
        /// If the waiver was signed at a kiosk
        /// </summary>
        public bool Kiosk { get; set; }
        /// <summary>
        /// First name of the first participant on the waiver
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Middle name of the first participant on the waiver
        /// </summary>
        public string MiddleName { get; set; }
        /// <summary>
        /// Last name of the first participant on the waiver
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Date of birth of the first participant on the waiver. Note: The DOB will be 1800-01-01 if the waiver is set up to use a checkbox for age verification.
        /// </summary>
        public DateTime Dob { get; set; }
        /// <summary>
        /// Whether the first participant is a minor or not
        /// </summary>
        public bool IsMinor { get; set; }
        /// <summary>
        /// Auto tag on the waiver if there is one, otherwise it will be blank
        /// </summary>
        public string AutoTag { get; set; }
        /// <summary>
        /// A list of tags for the waiver
        /// </summary>
        public List<string> Tags { get; set; }
        /// <summary>
        /// A list of flags for all participants
        /// </summary>
        public List<Flag> Flags { get; set; }
        /// <summary>
        /// A list of participants on the waiver
        /// </summary>
        public List<Participant> Participants { get; set; }
        /// <summary>
        /// Any custom waiver fields on the waiver
        /// </summary>
        public Dictionary<string, GUID> CustomWaiverFields { get; set; }
        /// <summary>
        /// If there are only minors on the waiver, this field contains the guardian information, otherwise it will be null
        /// </summary>
        public Guardian Guardian { get; set; }
        /// <summary>
        /// The primary email for the waiver
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Whether the user allows marketing to be sent to their email
        /// </summary>
        public bool MarketingAllowed { get; set; }
        public bool MarketingAllowedCheckbox { get; set; }
        /// <summary>
        /// The first line of the address
        /// </summary>
        public string AddressLineOne { get; set; }
        /// <summary>
        /// The second line of the address
        /// </summary>
        public string AddressLineTwo { get; set; }
        /// <summary>
        /// The city of the address
        /// </summary>
        public string AddressCity { get; set; }
        /// <summary>
        /// The state of the address
        /// </summary>
        public string AddressState { get; set; }
        /// <summary>
        /// The zip code of the address
        /// </summary>
        public string AddressZip { get; set; }
        /// <summary>
        /// The country of the address
        /// </summary>
        public string AddressCountry { get; set; }
        /// <summary>
        /// The name of the emergency contact
        /// </summary>
        public string EmergencyContactName { get; set; }
        /// <summary>
        /// The phone number of the emergency contact
        /// </summary>
        public string EmergencyContactPhone { get; set; }
        /// <summary>
        /// The name of the insurance carrier
        /// </summary>
        public string InsuranceCarrier { get; set; }
        /// <summary>
        /// The policy number of the insurance
        /// </summary>
        public string InsurancePolicyNumber { get; set; }
        /// <summary>
        ///  The number of the drivers license
        /// </summary>
        public string DriversLicenseNumber { get; set; }
        /// <summary>
        /// The state of the drivers license
        /// </summary>
        public string DriversLicenseState { get; set; }
        /// <summary>
        /// P Address from which the waiver was submitted
        /// </summary>
        public string ClientIp { get; set; }
        /// <summary>
        /// Number of photos attached to this waiver
        /// </summary>
        public int Photos { get; set; }
        /// <summary>
        /// A Base 64 encoded string of the PDF document
        /// </summary>

        public string Pdf { get; set; }

    }
}
