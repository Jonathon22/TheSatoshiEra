using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheSatoshiEra.Models
{
    public class LogOpened
    {
        public Guid id { get; set; }
        public Guid userId { get; set; }
        public string NameOfLog { get; set; }
    }
}
