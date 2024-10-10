using Crowdy.BLL.Services.Interfaces;
using Crowdy.DAL.Entities;
using Crowdy.DAL.Repositories;
using Crowdy.DAL.Repositories.Interfaces;

namespace Crowdy.BLL.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public List<Category> GetAll()
        {
            List<Category>? categories = _categoryRepository.GetAll().ToList();

            if (categories.Count <= 0)
            {
                throw new Exception("Aucune categorie n'a été trouvée.");
            }

            return categories;
        }

        public Category GetOneById(int id)
        {
            Category? category = _categoryRepository.GetOneById(id);

            if (category == null)
            {
                throw new Exception("La catégorie n'existe pas.");
            }

            return category;
        }

        public Category Create(Category category)
        {
            throw new NotImplementedException();
        }

        public bool Update(Category category)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
