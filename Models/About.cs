using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheSatoshiEra.Models
{
    public class About
    {
        public Guid Id { get; set; }
        public string AboutSatoshi { get; set; }
        public string Github { get; set; }
        public string Twitter { get; set; }
        public string LinkedIn { get; set; }
    }
}
