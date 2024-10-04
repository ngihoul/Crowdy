using Crowdy.DAL.Entities;
using Crowdy.Models;

namespace Crowdy.Mappers
{
    public static class UserMapper
    {
        public static User ToUser(this AuthRegisterFormModel model)
        {
            return new User
            {
                Username = model.Username,
                Email = model.Email,
                Password = model.Password,
                Avatar = model.Avatar ?? string.Empty,
                DateOfBirth = model.DateOfBirth
            };
        }
    }
}
