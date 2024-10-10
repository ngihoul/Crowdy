using Crowdy.DAL.Database;
using Crowdy.DAL.Entities;
using Crowdy.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Crowdy.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _context;

        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User? GetOneById(int key)
        {
            return _context.Users.Include(u => u.Roles)
                                 .FirstOrDefault(u => u.Id == key);
        }

        public User? GetOneByEmail(string email)
        {
            return _context.Users.FirstOrDefault(u => u.Email == email);
        }

        public User Create(User entity)
        {
            _context.Users.Add(entity);
            _context.SaveChanges();

            return entity;
        }

        public bool Delete(User entity)
        {
            _context.Users.Remove(entity);
            _context.SaveChanges();

            return true;
        }

        public User Update(User entity)
        {
            _context.Users.Update(entity);
            _context.SaveChanges();

            return entity;
        }
    }
}
