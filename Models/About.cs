using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheSatoshiEra.Models
{
    public class About
    {
        public Guid id { get; set; }
        public string about { get; set; }
        public string github { get; set; }
        public string twitter { get; set; }
        public string linkedIn { get; set; }
    }
}
