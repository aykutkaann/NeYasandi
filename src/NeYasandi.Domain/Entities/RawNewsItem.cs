using System;
using System.Collections.Generic;
using System.Text;

namespace NeYasandi.Domain.Entities
{
    public class RawNewsItem : BaseEntity
    {
        public Guid RssSourceId { get;  set; }
        public Guid CategoryId { get; set; }
        public string ExternalId { get; set; } //RSS Item
        public string Title { get; set; }
        public string Description { get; set; }
        public string SourceUrl { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime PublishedAt { get; set; }
        public DateTime FetchedAt { get; set; }
        public bool IsProcessed { get; set; }
        public DateTime ProcessedAt { get; set; }
    }
}
