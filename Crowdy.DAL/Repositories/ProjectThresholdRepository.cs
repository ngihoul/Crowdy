

using Crowdy.DAL.Database;
using Crowdy.DAL.Entities;
using Crowdy.DAL.Repositories.Interfaces;

namespace Crowdy.DAL.Repositories
{
    public class ProjectThresholdRepository : IProjectThresholdRepository
    {
        private readonly ApplicationContext _context;

        public ProjectThresholdRepository(ApplicationContext context)
        {
            _context = context;
        }

        public ProjectThreshold Create(ProjectThreshold entity)
        {
            _context.ProjectThresholds.Add(entity);
            _context.SaveChanges();

            return entity;
        }

        public bool Delete(ProjectThreshold entity)
        {
            _context.ProjectThresholds.Remove(entity);
            _context.SaveChanges();

            return true;
        }

        public List<ProjectThreshold> GetAll()
        {
            return _context.ProjectThresholds.ToList();
        }

        public ProjectThreshold? GetOneById(int key)
        {
            return _context.ProjectThresholds.FirstOrDefault(u => u.Id == key);
        }

        public ProjectThreshold Update(ProjectThreshold entity)
        {
            _context.ProjectThresholds.Update(entity);
            _context.SaveChanges();

            return entity;
        }
    }
}

