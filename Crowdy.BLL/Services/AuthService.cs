using Crowdy.DAL.Entities;
using Isopoh.Cryptography.Argon2;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Text;

namespace Crowdy.BLL.Services
{
    public class AuthService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AuthService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        // Create method to fulfil session with username and id
        public void InitSession(User user)
        {
            var context = _httpContextAccessor.HttpContext;
            if (context != null)
            {
                byte[] usernameBytes = Encoding.UTF8.GetBytes(user.Username);
                context.Session.Set("Username", usernameBytes);

                byte[] idBytes = BitConverter.GetBytes(user.Id);
                context.Session.Set("UserId", idBytes);
            }
        }

        public string HashPassword(string plainPassword)
        {
            return Argon2.Hash(plainPassword);
        }

        public bool VerifyPassword(string plainPassword, string hashedPassword)
        {
            return Argon2.Verify(hashedPassword, plainPassword);
        }
    }
}
