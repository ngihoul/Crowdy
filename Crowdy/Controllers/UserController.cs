using Crowdy.BLL.Services;
using Crowdy.DAL.Entities;
using Crowdy.Tools;
using Microsoft.AspNetCore.Mvc;

namespace Crowdy.Controllers
{
    [ConnectedOnly]
    public class UserController : Controller
    {
        private readonly AuthService _authService;

        public UserController(AuthService authService)
        {
            _authService = authService;
        }

        public IActionResult Index()
        {
            User user = _authService.GetUser()!;

            return View(user);
        }
    }
}
