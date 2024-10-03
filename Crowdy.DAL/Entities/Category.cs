namespace Crowdy.DAL.Entities
{
    public class Category
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public List<Project>? Projects { get; set; }
    }
}
