using Crowdy.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crowdy.DAL.Database.Configurations
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("category");

            builder.Property(c => c.Id)
                .ValueGeneratedOnAdd();

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasIndex(c => c.Name)
                .IsUnique();
        }
    }
}
