namespace Crowdy.DAL.Entities
{
    public class ProjectContribution
    {
        public int Id { get; set; }
        public Project Project { get; set; }
        public User User { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; }

        public ProjectContribution() { }
        public ProjectContribution(int id, Project project, User user, decimal amount, DateTime createdAt)
        {
            Id = id;
            Project = project;
            User = user;
            Amount = amount;
            CreatedAt = createdAt;
        }

        public ProjectContribution(Project project, User user, decimal amount)
        {
            Id = 0;
            Project = project;
            User = user;
            Amount = amount;
        }
    }
}
