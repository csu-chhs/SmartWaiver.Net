using SmartWaiver.Net.Objects;
using System;
using System.Runtime.CompilerServices;
using Xunit;

namespace SmartWaiver.Net.Tests
{
    public class SmartWaiverTests
    {
        readonly string _apiKey = "";
        [Fact]
        public void VerifyAutoTagUpdate()
        {
            string waiverGUID = "4fc7d12601941";
            string autoTag = "1234";

            ISmartWaiver smartWaiver = new SmartWaiver(_apiKey);

            Assert.Equal("https://waiver.smartwaiver.com/auto/?auto_waiverid=4fc7d12601941&auto_tag=1234",
                smartWaiver.Waiver.GetAutoTaggedWaiverUrl(waiverGUID, autoTag));
        }

        [Fact(Skip = "Account needed, cannot run with GH Actions")]
        public void GetTemplates()
        {
            ISmartWaiver smartWaiver = new SmartWaiver(_apiKey);
            var templates = smartWaiver.Template.GetTemplates();
            if (templates.Templates.Count == 0)
                return;

            var exception = Record.Exception(() => smartWaiver.Template.GetTemplate(templates.Templates.First().TemplateId));
            Assert.Null(exception);
        }

        [Fact(Skip = "Account needed, cannot run with GH Actions")]
        public void PrefillTemplate()
        {
            ISmartWaiver smartWaiver = new SmartWaiver(_apiKey);
            var templates = smartWaiver.Template.GetTemplates();
            if (templates.Templates.Count==0)
                return;

            var prefillRequest = new PrefillRequest
            {
                Expiration = 300,
                Kiosk = true,
                Adult = true,
                AnyoneElseHidden = false,
                Participants = new List<Participant>
                {
                    new Participant()
                    {
                        FirstName = "John",
                        LastName = "Doe",
                        Phone = "1-417-577-1884",
                        Gender = "male", // Case-senstive!
                        DOB = new DateTime(1969, 4, 1)
                    }
                },
                // Guardian not working
                Guardian = new Guardian()
                {
                    Participant = false,
                    FirstName = "James",
                    LastName = "Doe",
                    Relationship = "Father",
                    Phone = "1-555-555-5555",
                    Gender = "male", // Case-senstive!
                    DOB = new DateTime(1939, 1, 1)
                },
                AddressLineOne = "1",
                AddressLineTwo = "Main Street",
                AddressCity = "Springfield",
                AddressState = "MO",
                AddressCountry = "US",
                AddressZip = "80085",
                Email = "john.doe@gmail.com",
                EmergencyContactName = "Jane Doe",
                EmergencyContactPhone = "1-555-555-5555",
                InsuranceCarrier = "Geico",
                InsurancePolicyNumber = "1",
                DriversLicenseState = "MO",
                DriversLicenseNumber = "1"
            };

            var exception = Record.Exception(() => smartWaiver.Template.Prefill(templates.Templates.Last().TemplateId, prefillRequest));
            Assert.Null(exception);
        }

        [Fact(Skip = "Account needed, cannot run with GH Actions")]
        public void GetWaiver()
        {
            string waiverID = "XmxzAWtVX6BBqNdcZtknyj";

            ISmartWaiver smartWaiver = new SmartWaiver(_apiKey);
            var exception = Record.Exception(() => smartWaiver.Waiver.GetSignedWaiver(waiverID, true));
            Assert.Null(exception);
        }

        [Fact(Skip = "Account needed, cannot run with GH Actions")]
        public void GetWaivers()
        {
            ISmartWaiver smartWaiver = new SmartWaiver(_apiKey);
            var exception = Record.Exception(() => smartWaiver.Waiver.GetSignedWaivers());
            Assert.Null(exception);
        }

        [Fact(Skip = "Account needed, cannot run with GH Actions")]
        public void GetSignedWaivers()
        {
            ISmartWaiver smartWaiver = new SmartWaiver(_apiKey);
            var exception = Record.Exception(() => smartWaiver.Waiver.GetSignedWaivers(fromDts: new DateTime(2023, 3, 4, 0, 0, 0, 0), toDts: new DateTime(2023, 3, 4, 23, 59, 59)));
            Assert.Null(exception);
        }
    }
}
