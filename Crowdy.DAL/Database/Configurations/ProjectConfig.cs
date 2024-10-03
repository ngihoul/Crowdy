using Azure;
using Crowdy.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crowdy.DAL.Database.Configurations
{
    public class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            // Table
            builder.ToTable("project");

            // Properties
            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Description)
                .IsRequired();

            builder.Property(p => p.Objective)
                .HasPrecision(12, 2)
                .IsRequired();

            builder.Property(p => p.StartDate)
                .IsRequired();

            builder.Property(p => p.EndDate)
                .IsRequired();

            builder.Property(p => p.CreatedAt)
                .HasDefaultValueSql("GETDATE()")
                .IsRequired();

            builder.Property(p => p.UpdatedAt)
                .HasDefaultValueSql("GETDATE()")
                .IsRequired();

            // Constraints
            builder.ToTable(t => t.HasCheckConstraint("CK_Project_Objective", "Objective > 0"));

            builder.ToTable(t => t.HasCheckConstraint("CK_Project_StartDate", $"StartDate >= GETDATE()"));

            builder.ToTable(t => t.HasCheckConstraint("CK_Project_EndDate", $"EndDate > GETDATE()"));

            // Relationships
            builder.HasMany(p => p.Categories)
                .WithMany(c => c.Projects)
                .UsingEntity(
                    "MM_project_category",
                    l => l.HasOne(typeof(Category)).WithMany().HasForeignKey("CategoryId").HasPrincipalKey(nameof(Category.Id)),
                    r => r.HasOne(typeof(Project)).WithMany().HasForeignKey("ProjectId").HasPrincipalKey(nameof(Project.Id)),
                    j => j.HasKey("ProjectId", "CategoryId")
                );

            builder.HasMany(p => p.ProjectThresholds)
                .WithOne(pt => pt.Project)
                .HasForeignKey("ProjectId")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(p => p.ProjectContributions)
                .WithOne(pc => pc.Project)
                .HasForeignKey("ProjectId")
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();

            builder.HasOne(p => p.Owner)
                .WithMany(u => u.OwnedProjects)
                .HasForeignKey("OwnerId")
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();

            builder.HasOne(p => p.Status)
                .WithMany()
                .HasForeignKey("StatusId")
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();

            builder.HasOne(p => p.ValidatedBy)
                .WithMany()
                .HasForeignKey("ValidatedById")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
