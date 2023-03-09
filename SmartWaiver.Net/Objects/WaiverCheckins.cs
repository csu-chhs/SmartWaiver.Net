using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWaiver.Net.Objects
{
    public class WaiverCheckins : ResponseBase
    {
        public WaiverCheckins() { }

        public Checkins Checkins { get; set; }
    }
}
