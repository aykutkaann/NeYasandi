using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeYasandi.Domain.Entities;

namespace NeYasandi.Infrastructure.Persistence.Configurations
{
    public class SourceAttributionConfiguration : IEntityTypeConfiguration<SourceAttribution>
    {
        public void Configure(EntityTypeBuilder<SourceAttribution> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.DailySectionId).IsRequired();
            builder.Property(s => s.RawNewsItemId).IsRequired();
            builder.Property(s => s.SourceName).IsRequired().HasMaxLength(200);
            builder.Property(s => s.SourceUrl).IsRequired().HasMaxLength(500);
            builder.Property(s => s.CreatedAt).IsRequired();
        }
    }
}
