using System;
using System.Collections.Generic;
using System.Text;

namespace NeYasandi.Domain.Entities
{

    public class ForumPost : BaseEntity
    {
        public Guid ForumThreadId { get; set; }
        public Guid UserId { get; set; }
        public string Content { get; set; }
        public bool IsEdited { get; set; }
        public DateTime? EditedAt { get; set; }
        public bool IsFlagged { get; set; }
        public int FlagCount { get; set; }
        public bool IsPinned { get; set; }
        public bool IsDeleted { get; set; }
        public Guid? DeletedByUserId { get; set; }
        public int UpvoteCount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
