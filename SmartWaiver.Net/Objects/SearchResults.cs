namespace SmartWaiver.Net.Objects
{
    public class SearchResults
    {
        public SearchResults()
        {

        }

        public string WaiverId { get; set; }
        public string TemplateId { get; set; }
        public string Title { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool Expired { get; set; }
        public bool Verfified { get; set; }
        public bool Kiosk { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }
        public bool IsMinor { get; set; }
        public string AutoTag { get; set; }
        public string ClientIP { get; set; }
        public string[] Tags { get; set; }
        public Flag[] Flags { get; set; }
        public int Photos { get; set; }
        public Participant[] Participants { get; set; }
        public string Email { get; set; }
        public bool MarketingAllowed { get; set; }
        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressZip { get; set; }
        public string AddresCountry { get; set; }
        public string EmergencyContactName{ get; set; }
        public string EmergencyContactPhone { get; set; }
        public string InsuranceCarrier { get; set; }
        public string InsurancePolicyNumber { get; set; }
        public string DriversLicenseNumber { get; set; }
        public string DriversLicenseState { get; set; }
        /// <summary>
        /// Any custom waiver fields on the waiver
        /// </summary>
        public Dictionary<string, GUID> CustomWaiverFields { get; set; }
        public Guardian Guardian { get; set; }
    }
}