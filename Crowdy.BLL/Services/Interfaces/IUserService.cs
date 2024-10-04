using Crowdy.DAL.Entities;

namespace Crowdy.BLL.Services.Interfaces
{
    public interface IUserService : IService<int, User>
    {
        public User GetOneByEmail(string email);
    }
}
