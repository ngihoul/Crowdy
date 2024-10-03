using Crowdy.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crowdy.DAL.Database.Configurations
{
    public class StatusConfig : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            // Table
            builder.ToTable("status");

            // Properties
            builder.Property(s => s.Id)
                .ValueGeneratedOnAdd();

            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasIndex(s => s.Name)
                .IsUnique();

            builder.HasData(
                new
                {
                    Id = 1,
                    Name = "To be validated"
                },
                new
                {
                    Id = 2,
                    Name = "Validated"
                },
                new
                {
                    Id = 3,
                    Name = "Rejected"
                },
                new
                {
                    Id = 4,
                    Name = "Closed"
                }
            );
        }
    }
}
