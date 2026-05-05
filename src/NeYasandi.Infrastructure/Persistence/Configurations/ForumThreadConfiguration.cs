using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeYasandi.Domain.Entities;

namespace NeYasandi.Infrastructure.Persistence.Configurations
{
    public class ForumThreadConfiguration : IEntityTypeConfiguration<ForumThread>
    {
        public void Configure(EntityTypeBuilder<ForumThread> builder)
        {
            builder.HasKey(f => f.Id);

            builder.HasIndex(f => new { f.DailyPageId, f.CategoryId });

            builder.Property(f => f.DailyPageId).IsRequired();
            builder.Property(f => f.CategoryId).IsRequired();
            builder.Property(f => f.Title).IsRequired().HasMaxLength(200);
            builder.Property(f => f.IsLocked).IsRequired().HasDefaultValue(false);
            builder.Property(f => f.IsPinned).IsRequired().HasDefaultValue(false);
            builder.Property(f => f.PostCount).IsRequired().HasDefaultValue(0);
            builder.Property(f => f.CreatedAt).IsRequired();
            builder.Property(f => f.LockedAt);
        }
    }
}
