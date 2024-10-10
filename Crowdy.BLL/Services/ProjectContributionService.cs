using Crowdy.BLL.Services.Interfaces;
using Crowdy.DAL.Entities;
using Crowdy.DAL.Repositories.Interfaces;

namespace Crowdy.BLL.Services
{
    public class ProjectContributionService : IProjectContributionService
    {
        private readonly IProjectContributionRepository _projectContributionRepository;

        public ProjectContributionService(IProjectContributionRepository projectContributionRepository)
        {
            _projectContributionRepository = projectContributionRepository;
        }

        public List<ProjectContribution> GetAll()
        {
            throw new NotImplementedException();
        }

        public ProjectContribution GetOneById(int key)
        {
            throw new NotImplementedException();
        }

        public ProjectContribution Create(ProjectContribution projectContribution)
        {
            try
            {
                if(projectContribution.Project.Status.Id == 1)
                {
                    throw new Exception("Le projet n'est pas encore validé. Tu ne peux donc pas y contribuer");
                }

                if(projectContribution.Project.Status.Id == 3)
                {
                    throw new Exception("Le projet a été rejeté. Tu ne peux donc pas y contribuer");
                }

                if (projectContribution.Project.Status.Id == 3)
                {
                    throw new Exception("Le projet est clôturé. Tu ne peux donc plus y contribuer");
                }

                projectContribution.CreatedAt = DateTime.Now;
                _projectContributionRepository.Create(projectContribution);
                return projectContribution;
            }
            catch (Exception e) { 
                throw new Exception($"Une erreur est survenue lors de la création de la contribution : {e.Message}");
            }
            
        }

        public bool Delete(ProjectContribution projectContribution)
        {
            throw new NotImplementedException();
        }

        public bool Update(ProjectContribution projectContribution)
        {
            throw new NotImplementedException();
        }
        public decimal CalculateTotalContribution(List<ProjectContribution> contributions)
        {
            if(contributions.Count <= 0)
            {
                return 0;
            }

            decimal totalContribution = 0;
            foreach (var contribution in contributions)
            {
                totalContribution += contribution.Amount;
            }
            return totalContribution;
        }

        public int CalculateProgression(List<ProjectContribution> contributions, decimal objective)
        {
            if(contributions.Count <= 0 || objective <= 0)
            {
                return 0;
            }

            decimal totalContribution = CalculateTotalContribution(contributions);
            return (int) Math.Floor((totalContribution / objective) * 100);
        }
    }
}
