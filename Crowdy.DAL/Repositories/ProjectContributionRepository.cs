using Crowdy.DAL.Database;
using Crowdy.DAL.Entities;
using Crowdy.DAL.Repositories.Interfaces;

namespace Crowdy.DAL.Repositories
{
    public class ProjectContributionRepository : IProjectContributionRepository
    {
        private readonly ApplicationContext _context;

        public ProjectContributionRepository(ApplicationContext context)
        {
            _context = context;
        }

        public ProjectContribution Create(ProjectContribution entity)
        {
            _context.ProjectContributions.Add(entity);
            _context.SaveChanges();

            return entity;
        }

        public bool Delete(ProjectContribution entity)
        {
            _context.ProjectContributions.Remove(entity);
            _context.SaveChanges();

            return true;
        }

        public List<ProjectContribution> GetAll()
        {
            return _context.ProjectContributions.ToList();
        }

        public ProjectContribution? GetOneById(int key)
        {
            return _context.ProjectContributions.FirstOrDefault(u => u.Id == key);
        }

        public ProjectContribution Update(ProjectContribution entity)
        {
            _context.ProjectContributions.Update(entity);
            _context.SaveChanges();

            return entity;
        }
    }
}
