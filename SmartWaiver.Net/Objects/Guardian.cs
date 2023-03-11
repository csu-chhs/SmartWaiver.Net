using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SmartWaiver.Net.Objects
{
    public class Guardian
    {
        public Guardian() 
        { 
        }

        /// <summary>
        /// The first name of the guardian
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The middle name of the guardian
        /// </summary>
        public string MiddleName { get; set; }
        /// <summary>
        /// The last name of the guardian
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// The phone number of the guardian
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// The relationship of the guardian to the minors
        /// </summary>
        public string Relationship { get; set; }
        /// <summary>
        /// Date of birth of the guardian. (1800-01-01 if checkbox is used)
        /// </summary>
        public DateTime DOB { get; set; }
    }
}
