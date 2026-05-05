using NeYasandi.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeYasandi.Domain.Entities
{
    public class DailySection : BaseEntity
    {
        public Guid DailyPageId { get; set; }
        public Guid CategoryId { get; set; }
        public string AiGeneratedContent { get; set; }
        public string PublishedContent { get; set; }
        public DailySectionStatus SectionStatus { get; set; }
        public string? AudioUrl { get; set; }
        public AudioStatus AudioStatus { get; set; }
        public int? AudioDurationSeconds { get; set; }
        public ContentSource ContentSource { get; set; }
        public Guid? EditorId { get; set; }
        public DateTime? PublishedAt { get; set; }
        public DateTime? AutoPublishedAt { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }


    }
}
