using NeYasandi.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeYasandi.Domain.Entities
{
    public class DailyPage : BaseEntity
    {
        public DateOnly Date { get; set; }
        public DailyPageStatus PageStatus { get; set; }
        public DateTime? FrozenAt { get; set; }
        public long ViewCount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
