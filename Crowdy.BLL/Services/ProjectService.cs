using Crowdy.BLL.Services.Interfaces;
using Crowdy.DAL.Entities;
using Crowdy.DAL.Repositories.Interfaces;

namespace Crowdy.BLL.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IStatusService _statusService;

        public ProjectService(IProjectRepository projectRepository, IStatusService statusService)
        {
            _projectRepository = projectRepository;
            _statusService = statusService;
        }

        public List<Project> GetAll()
        {
            List<Project>? projects = _projectRepository.GetAll();

            if (projects.Count <= 0)
            {
                throw new Exception("Aucun projet n'a été trouvé.");
            }

            return projects;
        }

        public List<Project> GetAllByKeyword(string keyword)
        {
            List<Project>? projects = _projectRepository.GetAllByKeyword(keyword);

            if (projects.Count <= 0)
            {
                throw new Exception("Aucun projet n'a été trouvé.");
            }

            return projects;
        }
        public List<Project> GetAllValidated()
        {
            List<Project>? projects = _projectRepository.GetAllValidated();

            if (projects.Count <= 0)
            {
                throw new Exception("Aucun projet n'a été trouvé.");
            }

            return projects;
        }

        public Project GetOneById(int id)
        {
            Project? project = _projectRepository.GetOneById(id);

            if (project == null)
            {
                throw new Exception("Le projet n'existe pas.");
            }

            return project;
        }

        public List<Project> GetLastProjectsToBeValidated(int nb)
        {
            List<Project>? projects = _projectRepository.GetLastProjectsToBeValidated(nb);

            if (projects.Count <= 0)
            {
                throw new Exception("Aucun projet n'a été trouvé.");
            }

            return projects;
        }

        public List<Project> GetLastProjectsValidated(int nb)
        {
            List<Project>? projects = _projectRepository.GetLastProjectsValidated(nb);

            if (projects.Count <= 0)
            {
                throw new Exception("Aucun projet n'a été trouvé.");
            }

            return projects;
        }

        public List<Project> GetProjetsToValidate()
        {
            List<Project>? projects = _projectRepository.GetProjetsToValidate();

            if (projects.Count <= 0)
            {
                throw new Exception("Aucun projet n'a été trouvé.");
            }

            return projects;
        }

        public Project Validate(Project project, User admin)
        {
            project.Status = _statusService.GetOneByName(Status.VALIDATED);
            project.ValidatedBy = admin;
            _projectRepository.Update(project);

            return project;
        }

        public Project Refuse(Project project, User admin)
        {
            project.Status = _statusService.GetOneByName(Status.REJECTED);
            project.ValidatedBy = admin;
            _projectRepository.Update(project);

            return project;
        }

        public Project Create(Project project)
        {
            // Set default status
            project.Status = _statusService.GetOneByName(Status.TO_BE_VALIDATED);

            _projectRepository.Create(project);

            return project;
        }

        public bool Update(Project project)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Project project)
        {
            throw new NotImplementedException();
        }
    }
}
