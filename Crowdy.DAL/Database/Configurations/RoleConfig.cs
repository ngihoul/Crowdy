using Crowdy.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crowdy.DAL.Database.Configurations
{
    public class RoleConfig : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            // Table
            builder.ToTable("role");

            // Properties
            builder.Property(r => r.Id)
                .ValueGeneratedOnAdd();

            builder.Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasIndex(r => r.Name)
                .IsUnique();

            builder.HasData(
                new
                {
                    Id = 1,
                    Name = "Admin"
                },
                new
                {
                    Id = 2,
                    Name = "User"
                }
            );
        }
    }
}
