using Crowdy.BLL.Services.Interfaces;
using Crowdy.DAL.Entities;
using Crowdy.DAL.Repositories.Interfaces;

namespace Crowdy.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll().ToList();
        }

        public User GetOneById(int id)
        {
            User? user = _userRepository.GetOneById(id);

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

            User? user = _userRepository.GetOneByEmail(email);

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

            if (_userRepository.GetOneByEmail(user.Email) != null || _userRepository.GetOneByEmail(user.Username) != null)
            {
                throw new Exception("L'utilisateur existe déjà.");
            }

            if (_userRepository.Create(user) == null)
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
