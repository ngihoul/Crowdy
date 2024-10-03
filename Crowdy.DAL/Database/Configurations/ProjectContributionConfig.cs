using Crowdy.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crowdy.DAL.Database.Configurations
{
    public class ProjectContributionConfig : IEntityTypeConfiguration<ProjectContribution>
    {
        public void Configure(EntityTypeBuilder<ProjectContribution> builder)
        {
            // Table
            builder.ToTable("project_contribution");

            // Properties
            builder.Property(pc =>pc.Id)
                .ValueGeneratedOnAdd();

            builder.Property(pc => pc.CreatedAt)
                .HasDefaultValueSql("GETDATE()")
                .IsRequired();

            // Constraints
            builder.ToTable(t => t.HasCheckConstraint("CK_ProjectContribution_Amount", "Amount > 0"));
        }


    }
}
