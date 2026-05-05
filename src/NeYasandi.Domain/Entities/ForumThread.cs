using System;
using System.Collections.Generic;
using System.Text;

namespace NeYasandi.Domain.Entities
{

    public class ForumThread : BaseEntity
    {
        public Guid DailyPageId { get; set; }
        public Guid CategoryId { get; set; }
        public string Title { get; set; }
        public bool IsLocked { get; set; }
        public bool IsPinned { get; set; }
        public int PostCount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LockedAt { get; set; }
    }
}
