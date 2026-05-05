using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeYasandi.Domain.Entities;

namespace NeYasandi.Infrastructure.Persistence.Configurations
{
    public class DailyPageConfiguration : IEntityTypeConfiguration<DailyPage>
    {
        public void Configure(EntityTypeBuilder<DailyPage> builder)
        {
            builder.HasKey(d => d.Id);

            builder.HasIndex(d => d.Date).IsUnique();

            builder.Property(d => d.Date).IsRequired();
            builder.Property(d => d.PageStatus).IsRequired().HasConversion<int>();
            builder.Property(d => d.FrozenAt);
            builder.Property(d => d.ViewCount).IsRequired().HasDefaultValue(0L);
            builder.Property(d => d.CreatedAt).IsRequired();
            builder.Property(d => d.UpdatedAt);
        }
    }
}
