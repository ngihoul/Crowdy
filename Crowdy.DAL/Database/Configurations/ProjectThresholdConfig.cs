using Crowdy.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crowdy.DAL.Database.Configurations
{
    public class ProjectThresholdConfig : IEntityTypeConfiguration<ProjectThreshold>
    {
        public void Configure(EntityTypeBuilder<ProjectThreshold> builder)
        {
            // Table
            builder.ToTable("project_threshold");

            // Properties
            builder.Property(pt => pt.Id)
                .ValueGeneratedOnAdd();

            builder.Property(pt => pt.Amount)
                .HasPrecision(12, 2)
                .IsRequired();

            // Constraints
            builder.ToTable(pt => pt.HasCheckConstraint("CK_ProjectThreshold_Amount", "Amount > 0"));
        }
    }
}
