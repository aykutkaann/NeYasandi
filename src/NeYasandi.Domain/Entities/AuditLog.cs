using System;
using System.Collections.Generic;
using System.Text;

namespace NeYasandi.Domain.Entities
{

    public class AuditLog : BaseEntity
    {
        public Guid? UserId { get; set; }
        public string Action { get; set; }
        public string EntityType { get; set; }
        public Guid EntityId { get; set; }
        public string? OldValues { get; set; } // JSON string (jsonb)
        public string? NewValues { get; set; } // JSON string (jsonb)
        public string? IpAddress { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
