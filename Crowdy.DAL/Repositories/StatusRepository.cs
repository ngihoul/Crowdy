using Crowdy.DAL.Database;
using Crowdy.DAL.Entities;
using Crowdy.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Crowdy.DAL.Repositories
{
    public class StatusRepository : IStatusRepository
    {
        private readonly ApplicationContext _context;

        public StatusRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Status Create(Status entity)
        {
            _context.Statuses.Add(entity);
            _context.SaveChanges();

            return entity;
        }

        public bool Delete(Status entity)
        {
            _context.Statuses.Remove(entity);
            _context.SaveChanges();

            return true;
        }

        public List<Status> GetAll()
        {
            return _context.Statuses.ToList();
        }

        public Status? GetOneById(int key)
        {
            return _context.Statuses.FirstOrDefault(s => s.Id == key);
        }

        public Status? GetOneByName(string name)
        {
            return _context.Statuses.FirstOrDefault(s => s.Name == name);
        }

        public Status Update(Status entity)
        {
            _context.Statuses.Update(entity);
            _context.SaveChanges();

            return entity;
        }
    }
}
