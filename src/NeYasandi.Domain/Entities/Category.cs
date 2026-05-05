using System;
using System.Collections.Generic;
using System.Text;

namespace NeYasandi.Domain.Entities
{
    public class Category :BaseEntity
    {
        public string Name { get; set; } //Spor Ekonomi Siyaset Dünya Teknoloji
        public string Slug { get; set; } //spor ekonomi vb.
        public int DisplayOrder { get; set; }
        public string? IconUrl { get; set; }
        public bool IsActive { get; set; }
    }
}
