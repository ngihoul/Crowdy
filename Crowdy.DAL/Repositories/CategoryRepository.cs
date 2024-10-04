using Crowdy.DAL.Database;
using Crowdy.DAL.Entities;
using Crowdy.DAL.Repositories.Interfaces;

namespace Crowdy.DAL.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationContext _context;

        public CategoryRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Category Create(Category entity)
        {
            _context.Categories.Add(entity);
            _context.SaveChanges();

            return entity;
        }

        public bool Delete(Category entity)
        {
            _context.Categories.Remove(entity);
            _context.SaveChanges();

            return true;
        }

        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Category? GetOneById(int key)
        {
            return _context.Categories.FirstOrDefault(u => u.Id == key);
        }

        public Category Update(Category entity)
        {
            _context.Categories.Update(entity);
            _context.SaveChanges();

            return entity;
        }
    }
}
