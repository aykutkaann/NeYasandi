using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeYasandi.Domain.Entities;

namespace NeYasandi.Infrastructure.Persistence.Configurations
{
    public class ForumPostConfiguration : IEntityTypeConfiguration<ForumPost>
    {
        public void Configure(EntityTypeBuilder<ForumPost> builder)
        {
            builder.HasKey(f => f.Id);

            builder.HasIndex(f => new { f.ForumThreadId, f.CreatedAt });

            builder.Property(f => f.ForumThreadId).IsRequired();
            builder.Property(f => f.UserId).IsRequired();
            builder.Property(f => f.Content).IsRequired().HasMaxLength(2000);
            builder.Property(f => f.IsEdited).IsRequired().HasDefaultValue(false);
            builder.Property(f => f.EditedAt);
            builder.Property(f => f.IsFlagged).IsRequired().HasDefaultValue(false);
            builder.Property(f => f.FlagCount).IsRequired().HasDefaultValue(0);
            builder.Property(f => f.IsPinned).IsRequired().HasDefaultValue(false);
            builder.Property(f => f.IsDeleted).IsRequired().HasDefaultValue(false);
            builder.Property(f => f.DeletedByUserId);
            builder.Property(f => f.UpvoteCount).IsRequired().HasDefaultValue(0);
            builder.Property(f => f.CreatedAt).IsRequired();
            builder.Property(f => f.UpdatedAt).IsRequired();
        }
    }
}
