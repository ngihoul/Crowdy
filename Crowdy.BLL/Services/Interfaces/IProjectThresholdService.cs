using Crowdy.DAL.Entities;

namespace Crowdy.BLL.Services.Interfaces
{
    public interface IProjectThresholdService : IService<int, ProjectThreshold>
    {
        public List<ProjectThreshold> GetAllByProject(int id);
    }
}
