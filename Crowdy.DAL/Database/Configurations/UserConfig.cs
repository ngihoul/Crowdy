using Crowdy.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crowdy.DAL.Database.Configurations
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Table
            builder.ToTable("user");

            // Properties
            builder.Property(u => u.Id)
                .ValueGeneratedOnAdd();

            builder.Property(u =>u.Username)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasIndex(u => u.Username)
                .IsUnique();

            builder.Property(u =>u.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasIndex(u => u.Email)
                .IsUnique();

            // Constraints
            builder.ToTable(t => t.HasCheckConstraint("CHK_User_DateOfBirth", "DateOfBirth <= DATEADD(year, -18, GETDATE())"));

            // Relationships
            builder.HasMany(u => u.Roles)
                   .WithMany(r => r.Users)
                   .UsingEntity(
                       "MM_user_role",
                       l => l.HasOne(typeof(Role))
                             .WithMany()
                             .HasForeignKey("RoleId")
                             .HasPrincipalKey(nameof(Role.Id)),
                       r => r.HasOne(typeof(User))
                             .WithMany()
                             .HasForeignKey("UserId")
                             .HasPrincipalKey(nameof(User.Id)),
                       j => j.HasKey("UserId", "RoleId")
                   );
        }
    }
}
