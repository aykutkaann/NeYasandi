using NeYasandi.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeYasandi.Domain.Entities
{

    public class ForumPostVote : BaseEntity
    {
        public Guid ForumPostId { get; set; }
        public Guid UserId { get; set; }
        public VoteType VoteType { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
