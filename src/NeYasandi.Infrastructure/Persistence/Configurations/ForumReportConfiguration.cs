using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeYasandi.Domain.Entities;
using NeYasandi.Domain.Enums;

namespace NeYasandi.Infrastructure.Persistence.Configurations
{
    public class ForumReportConfiguration : IEntityTypeConfiguration<ForumReport>
    {
        public void Configure(EntityTypeBuilder<ForumReport> builder)
        {
            builder.HasKey(f => f.Id);

            builder.Property(f => f.ForumPostId).IsRequired();
            builder.Property(f => f.ReportedByUserId).IsRequired();
            builder.Property(f => f.Reason).IsRequired().HasConversion<int>();
            builder.Property(f => f.Description).HasMaxLength(1000);
            builder.Property(f => f.Status).IsRequired().HasConversion<int>().HasDefaultValue(ForumReportStatus.Pending);
            builder.Property(f => f.ReviewedByUserId);
            builder.Property(f => f.ReviewedAt);
            builder.Property(f => f.CreatedAt).IsRequired();
        }
    }
}
