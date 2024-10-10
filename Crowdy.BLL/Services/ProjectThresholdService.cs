using Crowdy.BLL.Services.Interfaces;
using Crowdy.DAL.Entities;
using Crowdy.DAL.Repositories.Interfaces;

namespace Crowdy.BLL.Services
{
    public class ProjectThresholdService : IProjectThresholdService
    {
        private readonly IProjectThresholdRepository _projectThresholdRepository;

        public ProjectThresholdService(IProjectThresholdRepository userRepository)
        {
            _projectThresholdRepository = userRepository;
        }

        public List<ProjectThreshold> GetAll()
        {
            return _projectThresholdRepository.GetAll().ToList();
        }

        public ProjectThreshold GetOneById(int id)
        {
            ProjectThreshold? projectThreshold = _projectThresholdRepository.GetOneById(id);

            if (projectThreshold == null)
            {
                throw new Exception("La récompense n'existe pas.");
            }

            return projectThreshold;
        }

        public List<ProjectThreshold> GetAllByProject(int id)
        {
            List<ProjectThreshold> thresholds = _projectThresholdRepository.GetAllByProject(id);

            if(thresholds.Count <= 0)
            {
                throw new Exception("Aucune récompense n'a été trouvée pour ce projet.");
            }

            return thresholds;
        }

        public ProjectThreshold Create(ProjectThreshold projectThreshold)
        {
            if (projectThreshold == null)
            {
                throw new ArgumentNullException(nameof(projectThreshold));
            }

            _projectThresholdRepository.Create(projectThreshold);


            return projectThreshold;
        }

        public bool Update(ProjectThreshold projectThreshold)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ProjectThreshold projectThreshold)
        {
            throw new NotImplementedException();
        }
    }
}
