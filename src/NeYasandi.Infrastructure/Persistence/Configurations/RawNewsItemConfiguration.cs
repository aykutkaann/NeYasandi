using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeYasandi.Domain.Entities;

namespace NeYasandi.Infrastructure.Persistence.Configurations
{
    public class RawNewsItemConfiguration : IEntityTypeConfiguration<RawNewsItem>
    {
        public void Configure(EntityTypeBuilder<RawNewsItem> builder)
        {
            builder.HasKey(r => r.Id);

            builder.HasIndex(r => r.ExternalId).IsUnique();
            builder.HasIndex(r => new { r.IsProcessed, r.PublishedAt });

            builder.Property(r => r.RssSourceId).IsRequired();
            builder.Property(r => r.CategoryId).IsRequired();

            builder.Property(r => r.ExternalId).IsRequired().HasMaxLength(500);
            builder.Property(r => r.Title).IsRequired().HasMaxLength(500);
            builder.Property(r => r.Description).IsRequired().HasColumnType("text");
            builder.Property(r => r.SourceUrl).IsRequired().HasMaxLength(500);
            builder.Property(r => r.ImageUrl).HasMaxLength(500);

            builder.Property(r => r.PublishedAt).IsRequired();
            builder.Property(r => r.FetchedAt).IsRequired();

            builder.Property(r => r.IsProcessed).IsRequired().HasDefaultValue(false);
            builder.Property(r => r.ProcessedAt);
        }
    }
}
