using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeYasandi.Domain.Entities;

namespace NeYasandi.Infrastructure.Persistence.Configurations
{
    public class DailySectionImageConfiguration : IEntityTypeConfiguration<DailySectionImage>
    {
        public void Configure(EntityTypeBuilder<DailySectionImage> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(d => d.DailySectionId).IsRequired();
            builder.Property(d => d.ImageUrl).IsRequired().HasMaxLength(500);
            builder.Property(d => d.OriginalSourceUrl).IsRequired().HasMaxLength(500);
            builder.Property(d => d.Caption).HasMaxLength(500);
            builder.Property(d => d.AltText).HasMaxLength(200);
            builder.Property(d => d.DisplayOrder).IsRequired();
            builder.Property(d => d.CreatedAt).IsRequired();
        }
    }
}
