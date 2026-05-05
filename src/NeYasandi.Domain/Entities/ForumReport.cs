using NeYasandi.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeYasandi.Domain.Entities
{

    public class ForumReport : BaseEntity
    {
        public Guid ForumPostId { get; set; }
        public Guid ReportedByUserId { get; set; }
        public ForumReportReason Reason { get; set; }
        public string? Description { get; set; }
        public ForumReportStatus Status { get; set; }
        public Guid? ReviewedByUserId { get; set; }
        public DateTime? ReviewedAt { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
