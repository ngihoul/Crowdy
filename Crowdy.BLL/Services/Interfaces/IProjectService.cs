using Crowdy.DAL.Entities;

namespace Crowdy.BLL.Services.Interfaces
{
    public interface IProjectService : IService<int, Project>
    {
        public List<Project> GetAllValidated();
        public List<Project> GetLastProjectsToBeValidated(int nb);
        public List<Project> GetProjetsToValidate();
        public List<Project> GetLastProjectsValidated(int nb);
        public Project Validate(Project project, User admin);
        public Project Refuse(Project project, User admin);
    }
}
