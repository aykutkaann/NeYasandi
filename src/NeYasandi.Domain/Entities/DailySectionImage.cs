using System;
using System.Collections.Generic;
using System.Text;

namespace NeYasandi.Domain.Entities
{
    public class DailySectionImage : BaseEntity
    {
        public Guid DailySectionId { get; set; }
        public string ImageUrl { get; set; }
        public string OriginalSourceUrl { get; set; }
        public string? Caption { get; set; }
        public string? AltText { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
