using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWaiver.Net.Objects
{
    public class Checkins
    {
        public Checkins() { }

        /// <summary>
        /// The requested from date
        /// </summary>
        public DateTime FromDts { get; set; }
        /// <summary>
        /// The requested to date
        /// </summary>
        public DateTime ToDts { get; set; }
        /// <summary>
        /// Whether there are more checkins to retrieve from this
        /// </summary>
        public bool MoreCheckins { get; set; }

        /// <summary>
        /// The array of checkins
        /// </summary>
        public List<Checkin> CheckIns { get; set; }
    }
}
