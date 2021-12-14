using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheSatoshiEra.Models
{
    public class TutorialVideos
    {
        public Guid Id { get; set; }
        public Guid VideoId { get; set; }
        public Guid UserId { get; set; }
        public Guid LibraryId { get; set; }
        public Guid ViewingId { get; set; }
        public string VideoUrl { get; set; }
        public string Description { get; set; }
    }
}
