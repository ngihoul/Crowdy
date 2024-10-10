using Crowdy.BLL.Services.Interfaces;
using Crowdy.DAL.Entities;
using Isopoh.Cryptography.Argon2;
using Microsoft.AspNetCore.Http;
using System.Text;

namespace Crowdy.BLL.Services
{
    public class AuthService
    {
        private readonly IHttpContextAccessor _context;

        private readonly IUserService _userService;

        public AuthService(IHttpContextAccessor httpContextAccessor, IUserService userService)
        {
            _context = httpContextAccessor;
            _userService = userService;
        }

        public string HashPassword(string plainPassword)
        {
            return Argon2.Hash(plainPassword);
        }

        public bool VerifyPassword(string plainPassword, string hashedPassword)
        {
            return Argon2.Verify(hashedPassword, plainPassword);
        }

        // Create method to fulfil session with username and id
        public void InitSession(User user)
        {
            var context = _context.HttpContext;
            if (context != null)
            {
                byte[] usernameBytes = Encoding.UTF8.GetBytes(user.Username);
                context.Session.Set("Username", usernameBytes);

                byte[] idBytes = BitConverter.GetBytes(user.Id);
                context.Session.Set("UserId", idBytes);
            }
        }

        public bool IsConnected()
        {
            var context = _context.HttpContext;
            bool isIdStocked = context.Session.TryGetValue("UserId", out _);
            bool isUsernameStocked = context.Session.TryGetValue("Username", out _);

            return isIdStocked && isUsernameStocked;
        }

        public List<Role>? GetUserRole()
        {
            User? user = GetUser();

            if(user == null)
            {
                return null;
            }

            return user.Roles;
        }

        public User? GetUser()
        {
            var context = _context.HttpContext;
            if (context == null)
            {
                return null;
            }

            if (!IsConnected())
            {
                return null;
            }

            context.Session.TryGetValue("UserId", out byte[] idBytes);
            int userId = BitConverter.ToInt32(idBytes, 0);

            return _userService.GetOneById(userId);
        }

        public bool IsAdmin()
        {
            List<Role>? roles = GetUserRole();
            if(roles == null)
            {
                return false;
            }

            bool isAdmin = roles.Any(role => role.Name == "Admin");

            return isAdmin;
        }

        public void ClearSession()
        {
            var context = _context.HttpContext;
            context.Session.Clear();
        }
        public bool IsGrantedAccess()
        {
            if (IsAdmin())
            {
                return true;
            }

            return false;
        }

    }
}
