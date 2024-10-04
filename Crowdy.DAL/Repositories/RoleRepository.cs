using Crowdy.DAL.Database;
using Crowdy.DAL.Entities;
using Crowdy.DAL.Repositories.Interfaces;

namespace Crowdy.DAL.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationContext _context;

        public RoleRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Role Create(Role entity)
        {
            _context.Roles.Add(entity);
            _context.SaveChanges();

            return entity;
        }

        public bool Delete(Role entity)
        {
            _context.Roles.Remove(entity);
            _context.SaveChanges();

            return true;
        }

        public List<Role> GetAll()
        {
            return _context.Roles.ToList();
        }

        public Role? GetOneById(int key)
        {
            return _context.Roles.FirstOrDefault(u => u.Id == key);
        }

        public Role Update(Role entity)
        {
            _context.Roles.Update(entity);
            _context.SaveChanges();

            return entity;
        }
    }
}
