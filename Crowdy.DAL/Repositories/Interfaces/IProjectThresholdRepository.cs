using Crowdy.DAL.Entities;

namespace Crowdy.DAL.Repositories.Interfaces
{
    public interface IProjectThresholdRepository : IRepository<int, ProjectThreshold>
    {
        public List<ProjectThreshold> GetAllByProject(int id);
    }
}
