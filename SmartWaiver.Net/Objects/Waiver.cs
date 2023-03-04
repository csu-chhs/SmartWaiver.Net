using System;
using System.Collections.Generic;

namespace SmartWaiver.Net.Objects
{
    public class Waiver
    {
        public Waiver()
        {

        }

        public string WaiverId { get; set; }
        public string TemplateId { get; set; }
        public string Title { get; set; }
        public string PrefillId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ExpirationDate { get; set; }   
        public bool Expired { get; set; }
        public bool Verified { get; set; }
        public bool Kiosk { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public bool IsMinor { get; set; }
        public string AutoTag { get; set; }

        public List<string> Tags { get; set; }
        public List<Flag> Flags { get; set; }   
        public List<Participant> Participants { get; set; }
        public Dictionary<string, CustomWaiverField> CustomerWaiverFields { get; set; }
        public Guardian Guardian { get; set; }
        public string Email { get; set; }
        public bool MarketingAllowed { get; set; }
        public bool MarketingAllowedCheckbox { get; set; }
        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressZip { get; set; }
        public string AddressCountry { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactPhone { get; set; }
        public string InsuranceCarrier { get; set; }
        public string InsurancePolicyNumber { get; set; }
        public string DriversLicenceNumber { get; set; }
        public string DriversLicenceState { get; set; }
        public string ClientIp { get; set; }
        public int Photos { get; set; }
        public string PDF { get; set; }
    }
}
