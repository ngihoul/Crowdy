using Crowdy.DAL.Database.Configurations;
using Crowdy.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Crowdy.DAL.Database
{
    public class ApplicationContext : DbContext
    {
        #region DbSet
        public DbSet<Category> Categories { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectThreshold> ProjectThresholds { get; set; }
        public DbSet<ProjectContribution> ProjectContributions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Status> Statuss { get; set; }
        public DbSet<Role> Roles { get; set; }

        #endregion

        #region Constructor
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }
        #endregion

        #region Methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new ProjectConfig());
            modelBuilder.ApplyConfiguration(new ProjectContributionConfig());
            modelBuilder.ApplyConfiguration(new ProjectThresholdConfig());
            modelBuilder.ApplyConfiguration(new RoleConfig());
            modelBuilder.ApplyConfiguration(new StatusConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());
        }
        #endregion
    }
}
