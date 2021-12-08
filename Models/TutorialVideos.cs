using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheSatoshiEra.Models
{
    public class TutorialVideos
    {
        public Guid id { get; set; }
        public Guid videoId { get; set; }
        public Guid userId { get; set; }
        public Guid libraryId { get; set; }
        public Guid viewingId { get; set; }
        public string videoUrl { get; set; }
        public string description { get; set; }
    }
}
