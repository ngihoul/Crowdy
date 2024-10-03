namespace Crowdy.DAL.Entities
{
    public class Project
    {
        public required int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required decimal Objective { get; set; }
        public required DateTime StartDate { get; set; }
        public required DateTime EndDate { get; set; }
        public required List<Category> Categories { get; set; }
        public required List<ProjectThreshold> ProjectThresholds { get; set; }
        public required List<ProjectContribution> ProjectContributions { get; set; }
        public required User Owner { get; set; }
        public required Status Status { get; set; }
        public User? ValidatedBy { get; set; }
        public required DateTime CreatedAt { get; set; }
        public required DateTime UpdatedAt { get; set; }
    }
}
