using Crowdy.DAL.Entities;

namespace Crowdy.DAL.Repositories.Interfaces
{
    public interface IStatusRepository : IRepository<int, Status>
    {
        public Status? GetOneByName(string name);
    }
}
