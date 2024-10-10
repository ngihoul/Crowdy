using Crowdy.DAL.Database;
using Crowdy.DAL.Entities;
using Crowdy.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Crowdy.DAL.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ApplicationContext _context;

        public ProjectRepository(ApplicationContext context)
        {
            _context = context;
        }
        public List<Project> GetAll()
        {
            return _context.Projects.Include(p => p.Categories)
                                    .Include(p => p.ProjectContributions)
                                    .Include(p => p.Status)
                                    .OrderBy(p => p.StartDate)
                                    .ToList();
        }


        public List<Project> GetAllByKeyword(string keyword)
        {
            return _context.Projects.Include(p => p.Categories)
                                    .Include(p => p.ProjectContributions)
                                    .Include(p => p.Status)
                                    .Where(p => p.Title.Contains(keyword) || p.Description.Contains(keyword))
                                    .OrderBy(p => p.StartDate)
                                    .ToList();
        }
        public List<Project> GetAllValidated()
        {
            return _context.Projects.Include(p => p.Categories)
                                    .Include(p => p.ProjectContributions)
                                    .Include(p => p.Status)
                                    .Where(p => p.Status.Name == Status.VALIDATED)
                                    .OrderBy(p => p.StartDate)
                                    .ToList();
        }

        public Project? GetOneById(int key)
        {
            return _context.Projects.Include(p => p.ProjectThresholds)
                                    .Include(p => p.ProjectContributions)
                                    .Include(p => p.Status)
                                    .Include(p => p.Owner)
                                    .FirstOrDefault(u => u.Id == key);
        }

        public List<Project> GetLastProjectsToBeValidated(int nb)
        {
            return _context.Projects.Include(p => p.Status)
                                    .Where(p => p.Status.Name == Status.TO_BE_VALIDATED)
                                    .OrderBy(p => p.StartDate)
                                    .Take(nb)
                                    .ToList();
        }

        public List<Project> GetLastProjectsValidated(int nb)
        {
            return _context.Projects.Include(p => p.Status)
                                    .Include(p => p.ProjectContributions)
                                    .Where(p => p.Status.Name == Status.VALIDATED)
                                    .OrderByDescending(p => p.CreatedAt)
                                    .Take(nb)
                                    .ToList();
        }
        public List<Project> GetProjetsToValidate()
        {
            return _context.Projects.Include(p => p.Status)
                                    .Where(p => p.Status.Name == Status.TO_BE_VALIDATED)
                                    .OrderBy(p => p.StartDate)
                                    .ToList();
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

        public Project Update(Project entity)
        {
            _context.Projects.Update(entity);
            _context.SaveChanges();

            return entity;
        }
    }
}
