using Crowdy.DAL.Entities;

namespace Crowdy.BLL.Services.Interfaces
{
    public interface IStatusService : IService<int, Status>
    {
        public Status? GetOneByName(string name);
    }
}
