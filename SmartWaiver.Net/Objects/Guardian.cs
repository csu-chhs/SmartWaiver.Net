using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWaiver.Net.Objects
{
    public class Guardian
    {
        public Guardian() 
        { 
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Relationship { get; set; }
        public DateTime DOB { get; set; }
    }
}
