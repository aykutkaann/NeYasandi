using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeYasandi.Domain.Entities;


namespace NeYasandi.Infrastructure.Persistence.Configurations
{
    public class RssSourceConfiguration :IEntityTypeConfiguration<RssSource>
    {
        public void Configure(EntityTypeBuilder<RssSource> builder)
        {
            builder.HasKey(r => r.Id);

            builder.HasIndex(r => r.CategoryId);

            builder.Property(r => r.CategoryId).IsRequired();
            builder.Property(r => r.Name).IsRequired().HasMaxLength(500);
            builder.Property(r => r.FeedUrl).IsRequired().HasMaxLength(500);
            builder.Property(r => r.IsActive).IsRequired().HasDefaultValue(true);

            builder.Property(r => r.FetchIntervalMinutes).IsRequired().HasDefaultValue(60);
            builder.Property(r => r.ReliabilityScore).IsRequired();





        }
    }
}
