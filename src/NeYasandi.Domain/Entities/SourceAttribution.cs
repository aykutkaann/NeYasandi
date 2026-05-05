using System;
using System.Collections.Generic;
using System.Text;

namespace NeYasandi.Domain.Entities
{

    public class SourceAttribution : BaseEntity
    {
        public Guid DailySectionId { get; set; }
        public Guid RawNewsItemId { get; set; }
        public string SourceName { get; set; }
        public string SourceUrl { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
