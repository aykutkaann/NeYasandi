using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeYasandi.Domain.Entities;

namespace NeYasandi.Infrastructure.Persistence.Configurations
{
    public class ForumPostVoteConfiguration : IEntityTypeConfiguration<ForumPostVote>
    {
        public void Configure(EntityTypeBuilder<ForumPostVote> builder)
        {
            builder.HasKey(f => f.Id);

            // A user can only vote once per post
            builder.HasIndex(f => new { f.ForumPostId, f.UserId }).IsUnique();

            builder.Property(f => f.ForumPostId).IsRequired();
            builder.Property(f => f.UserId).IsRequired();
            builder.Property(f => f.VoteType).IsRequired().HasConversion<int>();
            builder.Property(f => f.CreatedAt).IsRequired();
        }
    }
}
