using Azure.Identity;

namespace Crowdy.DAL.Entities
{
    public class User
    {
        #region
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Avatar { get; set; } 
        public DateTime DateOfBirth { get; set; }
        public List<Role>? Roles { get; set; } = new List<Role>();
        public List<Project>? OwnedProjects { get; set; } = new List<Project>();
        /*public List<ProjectContribution>? Contributions { get; set; } = new List<ProjectContribution>();*/
        #endregion

        #region Constructors
        public User()
        {
        }
        public User(string username, string email, string password, string avatarPath, DateTime dateOfBirth)
        {
            Id = 0;
            Username = username;
            Email = email;
            Password = password;
            Avatar = avatarPath;
            DateOfBirth = dateOfBirth;
        }

        public User(int id, string username, string email, string password, string? avatar, DateTime dateOfBirth, List<Role>? roles, List<Project>? ownedProjects)
        {
            Id = id;
            Username = username;
            Email = email;
            Password = password;
            Avatar = avatar;
            DateOfBirth = dateOfBirth;
            Roles = roles;
            OwnedProjects = ownedProjects;
        }
        #endregion
    }
}
