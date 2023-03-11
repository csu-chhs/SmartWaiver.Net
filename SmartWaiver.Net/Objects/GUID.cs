using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWaiver.Net.Objects
{
    public class GUID
    {
        public GUID() { }

        /// <summary>
        /// The value of the custom participant field
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// The display text of the custom participant field
        /// </summary>
        public string DisplayText { get; set; }
    }
}
