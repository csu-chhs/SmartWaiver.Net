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
        public DateTime CreatedOn { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Dob { get; set; }
        public string ClientIp { get; set; }
        public string Email { get; set; }
        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressZip { get; set; }
        public string AddressCountry { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactPhone { get; set; }
        public byte[] Pdf { get; set; }
        public List<string> Tags { get; set; }
    }
}
