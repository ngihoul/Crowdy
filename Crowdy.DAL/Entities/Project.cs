namespace Crowdy.DAL.Entities
{
    public class Project
    {
        #region Props
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Objective { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<ProjectThreshold> ProjectThresholds { get; set; } = new List<ProjectThreshold>();
        public List<ProjectContribution>? ProjectContributions { get; set; } = new List<ProjectContribution>();
        public User Owner { get; set; } = new User();
        public Status Status { get; set; } = new Status();
        public string? Comment { get; set; }
        public User? ValidatedBy { get; set; } = new User();
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        #endregion

        #region Construcrors
        public Project() {}

        public Project(string title, string description, decimal objective, string? imageUrl, DateTime startDate, DateTime endDate, List<Category> categories, List<ProjectThreshold> projectThresholds)
        {
            Id = 0;
            Title = title;
            Description = description;
            Objective = objective;
            ImageUrl = imageUrl;
            StartDate = startDate;
            EndDate = endDate;
            Categories = categories;
            ProjectThresholds = projectThresholds;
            ProjectContributions = new List<ProjectContribution>();
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        public Project(int id, string title, string description, decimal objective, string? imageUrl, DateTime startDate, DateTime endDate, List<Category> categories, List<ProjectThreshold> projectThresholds, List<ProjectContribution> projectContributions, User owner, Status status, User? validatedBy, DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
            Title = title;
            Description = description;
            Objective = objective;
            ImageUrl = imageUrl;
            StartDate = startDate;
            EndDate = endDate;
            Categories = categories;
            ProjectThresholds = projectThresholds;
            ProjectContributions = projectContributions;
            Owner = owner;
            Status = status;
            ValidatedBy = validatedBy;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
        #endregion
    }
}
