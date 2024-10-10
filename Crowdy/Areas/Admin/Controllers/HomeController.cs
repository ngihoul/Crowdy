using Microsoft.AspNetCore.Mvc;
using Crowdy.DAL.Entities;
using Crowdy.BLL.Services.Interfaces;
using Crowdy.Models;
using Crowdy.Mappers;
using Crowdy.BLL.Services;
using Crowdy.Tools;

namespace Crowdy.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AdminOnly]
    public class HomeController : Controller
    {
        private readonly IProjectService _projectService;
        private readonly AuthService _authService;

        public HomeController(IProjectService projectService, AuthService authService)
        {
            _projectService = projectService;
            _authService = authService;
        }

        public IActionResult Index()
        {
            try
            {
                List<Project>? lastTenProjectsToBeValidated = _projectService.GetLastProjectsToBeValidated(5);

                List<ProjectViewModel> lastTenProjectsToBeValidatedFormView = lastTenProjectsToBeValidated.Select(p => p.ToProjectViewModel()).ToList();

                int nbProjectsToBeValidated = _projectService.GetProjetsToValidate().Count();
                ViewBag.nbProjectsToValidate = nbProjectsToBeValidated;

                return View(lastTenProjectsToBeValidatedFormView);

            }
            catch(Exception e)
            {
                TempData["Error"] = e.Message;
                return View();
            }
            
        }
    }
}
