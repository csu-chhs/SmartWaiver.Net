using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWaiver.Net.Objects
{
    public class Participant
    {
        public Participant() { }    

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; } 
        public DateTime DOB { get; set; }
        public bool IsMinor { get; set; }   
        public bool MinorExpired { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public List<string> Tags { get; set; }
        public CustomParticipantField CustomParticipantFields { get; set; }
        public List<Flag> Flags { get; set; }  
    }
}
