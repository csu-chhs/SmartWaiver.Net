using Newtonsoft.Json;

namespace SmartWaiver.Net.Objects
{
    public class PrefillRequest
    {
        public PrefillRequest() { }

        [JsonProperty(PropertyName = "expiration")]
        public int Expiration { get; set; }
        [JsonProperty(PropertyName = "kiosk")]
        public bool? Kiosk { get; set; }
        [JsonProperty(PropertyName = "adult")]
        public bool? Adult { get; set; }
        [JsonProperty(PropertyName = "anyoneElseHidden")]
        public bool? AnyoneElseHidden { get; set; }
        [JsonProperty(PropertyName = "participants")]
        public List<Participant> Participants { get; set; }
        [JsonProperty(PropertyName = "guardian")]
        public Guardian Guardian { get; set; }
        [JsonProperty(PropertyName = "addressLineOne")]
        public string AddressLineOne { get; set; }
        [JsonProperty(PropertyName = "addressLineTwo")] 
        public string AddressLineTwo { get; set;}
        [JsonProperty(PropertyName = "addressCity")]
        public string AddressCity { get; set; }
        [JsonProperty(PropertyName = "addressCountry")]
        public string AddressCountry { get; set; }
        [JsonProperty(PropertyName = "addressState")]
        public string AddressState { get; set; }
        [JsonProperty(PropertyName = "addressZip")]
        public string AddressZip { get; set; }
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
        [JsonProperty(PropertyName = "emergencyContactName")]
        public string EmergencyContactName { get; set; }
        [JsonProperty(PropertyName = "emergencyContactPhone")]
        public string EmergencyContactPhone { get; set; }
        [JsonProperty(PropertyName = "insuranceCarrier")]
        public string InsuranceCarrier { get; set; }
        [JsonProperty(PropertyName = "insurancePolicyNumber")]
        public string InsurancePolicyNumber { get; set; }
        [JsonProperty(PropertyName = "driversLicenseState")]
        public string DriversLicenseState { get; set; }
        [JsonProperty(PropertyName = "driversLicenseNumber")]
        public string DriversLicenseNumber { get; set; }
        [JsonProperty(PropertyName = "customWaiverFields")]
        public Dictionary<string, string> CustomWaiverFields { get; set; }

    }
}
