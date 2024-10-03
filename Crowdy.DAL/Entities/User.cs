namespace Crowdy.DAL.Entities
{
    public class User
    {
        public required int Id { get; set; }
        public required string Username { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string Avatar { get; set; } 
        public required DateTime DateOfBirth { get; set; }
        public required List<Role> Roles { get; set; }
        public List<Project>? OwnedProjects { get; set; }
    }
}
