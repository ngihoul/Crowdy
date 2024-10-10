using Crowdy.DAL.Entities;

namespace Crowdy.BLL.Services.Interfaces
{
    public interface IProjectContributionService : IService<int, ProjectContribution>
    {
        decimal CalculateTotalContribution(List<ProjectContribution> contributions);
        int CalculateProgression(List<ProjectContribution> contributions, decimal objective);
    }
}
