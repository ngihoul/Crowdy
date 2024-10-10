

using Crowdy.DAL.Database;
using Crowdy.DAL.Entities;
using Crowdy.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Crowdy.DAL.Repositories
{
    public class ProjectThresholdRepository : IProjectThresholdRepository
    {
        private readonly ApplicationContext _context;

        public ProjectThresholdRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<ProjectThreshold> GetAll()
        {
            return _context.ProjectThresholds.ToList();
        }

        public ProjectThreshold? GetOneById(int key)
        {
            return _context.ProjectThresholds.Include(pt => pt.Project).FirstOrDefault(pt => pt.Id == key);
        }

        public List<ProjectThreshold> GetAllByProject(int id)
        {
            return _context.ProjectThresholds.Include(pt => pt.Project).Where(pt => pt.Project.Id == id).ToList();
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

        public ProjectThreshold Update(ProjectThreshold entity)
        {
            _context.ProjectThresholds.Update(entity);
            _context.SaveChanges();

            return entity;
        }
    }
}

