using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeYasandi.Domain.Entities;


namespace NeYasandi.Infrastructure.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasIndex(c => c.Slug).IsUnique();

            builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Slug).IsRequired().HasMaxLength(50);
            builder.Property(c => c.DisplayOrder).IsRequired();
            builder.Property(c => c.IsActive).IsRequired().HasDefaultValue(true);
        }
    }
}
