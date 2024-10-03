namespace Crowdy.DAL.Entities
{
    public class ProjectContribution
    {
        public required int Id { get; set; }
        public required Project Project { get; set; }
        public required User User { get; set; }
        public required decimal Amount { get; set; }
        public required DateTime CreatedAt { get; set; }  
    }
}
