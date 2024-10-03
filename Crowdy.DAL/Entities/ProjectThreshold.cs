namespace Crowdy.DAL.Entities
{
    public class ProjectThreshold
    {
        public required int Id { get; set; }
        public required Project Project { get; set; }
        public required decimal Amount { get; set; }
        public required string Description { get; set; }
    }
}
