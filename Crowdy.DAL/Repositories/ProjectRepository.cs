using Crowdy.DAL.Database;
using Crowdy.DAL.Entities;
using Crowdy.DAL.Repositories.Interfaces;

namespace Crowdy.DAL.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ApplicationContext _context;

        public ProjectRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Project Create(Project entity)
        {
            _context.Projects.Add(entity);
            _context.SaveChanges();

            return entity;
        }

        public bool Delete(Project entity)
        {
            _context.Projects.Remove(entity);
            _context.SaveChanges();

            return true;
        }

        public List<Project> GetAll()
        {
            return _context.Projects.ToList();
        }

        public Project? GetOneById(int key)
        {
            return _context.Projects.FirstOrDefault(u => u.Id == key);
        }

        public Project Update(Project entity)
        {
            _context.Projects.Update(entity);
            _context.SaveChanges();

            return entity;
        }
    }
}
