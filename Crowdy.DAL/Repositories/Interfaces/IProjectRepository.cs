using Crowdy.DAL.Entities;

namespace Crowdy.DAL.Repositories.Interfaces
{
    public interface IProjectRepository : IRepository<int, Project>
    {
        public List<Project> GetAllValidated();
        public List<Project> GetAllByKeyword(string keyword);
        public List<Project> GetLastProjectsToBeValidated(int nb);
        public List<Project> GetLastProjectsValidated(int nb);
        public List<Project> GetProjetsToValidate();
    }
}
