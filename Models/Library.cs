using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheSatoshiEra.Models
{
    public class Library
    {
        public Guid id { get; set; }
        public Guid userId { get; set; }
        public Guid openedId { get; set; }
        public string link { get; set; }
        public string description { get; set; }
        public string category { get; set; }
    }
}
