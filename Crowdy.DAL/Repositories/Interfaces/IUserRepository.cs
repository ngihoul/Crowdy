using Crowdy.DAL.Entities;

namespace Crowdy.DAL.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<int, User>
    {
        public User? GetOneByEmail(string email);
    }
}
