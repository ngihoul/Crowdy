using Crowdy.BLL.Services.Interfaces;
using Crowdy.DAL.Entities;
using Crowdy.DAL.Repositories.Interfaces;

namespace Crowdy.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _projectThresholdRepository;

        public UserService(IUserRepository userRepository)
        {
            _projectThresholdRepository = userRepository;
        }

        public List<User> GetAll()
        {
            return _projectThresholdRepository.GetAll().ToList();
        }

        public User GetOneById(int id)
        {
            User? user = _projectThresholdRepository.GetOneById(id);

            if (user == null)
            {
                throw new Exception("L'utilisateur n'existe pas.");
            }

            return user;
        }

        public User GetOneByEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentNullException(nameof(email));
            }

            User? user = _projectThresholdRepository.GetOneByEmail(email);

            if (user == null)
            {
                throw new Exception("L'utilisateur n'existe pas.");
            }

            return user;
        }

        public User Create(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            if (_projectThresholdRepository.GetOneByEmail(user.Email) != null || _projectThresholdRepository.GetOneByEmail(user.Username) != null)
            {
                throw new Exception("L'utilisateur existe déjà.");
            }

            if (_projectThresholdRepository.Create(user) == null)
            {
                throw new Exception("Erreur lors de l'enregistrement.");
            }

            return user;
        }

        public bool Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
