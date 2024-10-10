namespace Crowdy.DAL.Entities
{
    public class ProjectThreshold
    {
        public int Id { get; set; }
        public Project Project { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}
