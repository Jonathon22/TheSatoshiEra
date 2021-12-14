using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheSatoshiEra.Models
{
    public class LogOpened
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string NameOfLog { get; set; }
    }
}
