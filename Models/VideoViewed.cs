using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheSatoshiEra.Models
{
    public class VideoViewed
    {
        public Guid id { get; set; }
        public Guid userId { get; set; }
        public string videName { get; set; }
    }
}
