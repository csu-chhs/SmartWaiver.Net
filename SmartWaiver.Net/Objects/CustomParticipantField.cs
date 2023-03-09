using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWaiver.Net.Objects
{
    public class CustomParticipantField
    {
        public CustomParticipantField() { }

        /// <summary>
        /// The custom participant field, each GUID is unique
        /// </summary>
        public List<GUID> GUID { get; set; }
    }
}
