using Crowdy.BLL.Services;
using Crowdy.BLL.Services.Interfaces;
using Crowdy.DAL.Entities;
using Crowdy.Models;
using Crowdy.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace Crowdy.Controllers
{
    public class AuthController : Controller
    {
        private const string DEFAULT_AVATAR = "default.jpg";
        private const string AVATAR_PATH = @"\img\avatars";

        private readonly IUserService _userService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly FileService _fileService;
        private readonly AuthService _authService;

        public AuthController(IUserService userService, IWebHostEnvironment webHostEnvironment, FileService avatarService, AuthService authService)
        {
            _userService = userService;
            _webHostEnvironment = webHostEnvironment;
            _fileService = avatarService;
            _authService = authService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm] AuthLoginFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                User user = _userService.GetOneByEmail(model.Email);
                if (_authService.VerifyPassword(model.Password, user.Password))
                {
                    _authService.InitSession(user);

                    TempData["Success"] = "Connecté avec succès.";
                    return RedirectToAction(nameof(HomeController.Index), "Home");
                } else
                {
                    ViewBag.Error = "le nom d'utilisateur et le mot de passe sont incorrects.";
                    return View(model);
                }
            }catch(Exception e)
            {
                ViewBag.Error = $"Une erreur est survenue : {e.Message}";
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register([FromForm] AuthRegisterFormModel model, IFormFile? file)
        {
            if (!ModelState.IsValid) {
                return View(model);
            }

            try
            {
                // Handling avatar
                if(file != null)
                {
                    string wwwRootPath = _webHostEnvironment.WebRootPath + AVATAR_PATH;
                    model.Avatar = _fileService.SaveFile(wwwRootPath, file);
                } else
                {
                    model.Avatar = DEFAULT_AVATAR;
                }

                // Handling password
                model.Password = _authService.HashPassword(model.Password);

                // Saving User
                User user = model.ToUser();
                _userService.Create(user);

                return RedirectToAction("Index", "Home");

            } catch (Exception e)
            {
                TempData["Error"] = e.Message;
                return View(model);
            }
        }

        public IActionResult Logout()
        {
            _authService.ClearSession();

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}
