using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeYasandi.Domain.Entities;

namespace NeYasandi.Infrastructure.Persistence.Configurations
{
    public class AuditLogConfiguration : IEntityTypeConfiguration<AuditLog>
    {
        public void Configure(EntityTypeBuilder<AuditLog> builder)
        {
            builder.HasKey(a => a.Id);

            builder.HasIndex(a => new { a.EntityType, a.EntityId });

            builder.Property(a => a.UserId);
            builder.Property(a => a.Action).IsRequired().HasMaxLength(100);
            builder.Property(a => a.EntityType).IsRequired().HasMaxLength(100);
            builder.Property(a => a.EntityId).IsRequired();
            builder.Property(a => a.OldValues).HasColumnType("jsonb");
            builder.Property(a => a.NewValues).HasColumnType("jsonb");
            builder.Property(a => a.IpAddress).HasMaxLength(45);
            builder.Property(a => a.CreatedAt).IsRequired();
        }
    }
}
