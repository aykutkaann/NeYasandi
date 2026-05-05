using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeYasandi.Domain.Entities;

namespace NeYasandi.Infrastructure.Persistence.Configurations
{
    public class DailySectionConfiguration : IEntityTypeConfiguration<DailySection>
    {
        public void Configure(EntityTypeBuilder<DailySection> builder)
        {
            builder.HasKey(d => d.Id);

            builder.HasIndex(d => new { d.DailyPageId, d.CategoryId });

            builder.Property(d => d.DailyPageId).IsRequired();
            builder.Property(d => d.CategoryId).IsRequired();

            builder.Property(d => d.AiGeneratedContent).IsRequired().HasColumnType("text");
            builder.Property(d => d.PublishedContent).IsRequired().HasColumnType("text");

            builder.Property(d => d.SectionStatus).IsRequired().HasConversion<int>();
            builder.Property(d => d.AudioStatus).IsRequired().HasConversion<int>();

            builder.Property(d => d.AudioUrl).HasMaxLength(500);
            builder.Property(d => d.AudioDurationSeconds);

            builder.Property(d => d.EditorId);
            builder.Property(d => d.PublishedAt);
            builder.Property(d => d.AutoPublishedAt);
            builder.Property(d => d.DisplayOrder).IsRequired();
            builder.Property(d => d.CreatedAt).IsRequired();
            builder.Property(d => d.UpdatedAt);
        }
    }
}
