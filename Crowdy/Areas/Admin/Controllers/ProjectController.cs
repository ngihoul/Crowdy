using Crowdy.BLL.Services;
using Crowdy.BLL.Services.Interfaces;
using Crowdy.DAL.Entities;
using Crowdy.Mappers;
using Crowdy.Models;
using Crowdy.Tools;
using Microsoft.AspNetCore.Mvc;

namespace Crowdy.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AdminOnly]
    public class ProjectController : Controller
    {
        private readonly IProjectService _projectService;
        private readonly IProjectContributionService _projectContributionService;

        private readonly AuthService _authService;

        public ProjectController(IProjectService projectService, IProjectContributionService projectContributionService, AuthService authService)
        {
            _projectService = projectService;
            _projectContributionService = projectContributionService;
            _authService = authService;
        }

        public IActionResult Index()
        {
            try
            {
                List<Project> projects = _projectService.GetAll();
                List<ProjectViewModel> projectsViewModel = projects.Select(p => p.ToProjectViewModel()).ToList();

                @ViewBag.nbProjects = projects.Count();

                return View(projectsViewModel);
            }
            catch (Exception e)
            {
                TempData["Error"] = e.Message;
                return RedirectToAction(nameof(HomeController.Index), new { area = "" });
            }

        }

        public IActionResult Details(int id)
        {
            try
            {
                Project project = _projectService.GetOneById(id);

                return View("../../Views/Project/Details", project);
            }
            catch (Exception e)
            {
                TempData["Error"] = e.Message;
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }

        }
        public IActionResult ToBeValidated()
        {
            try
            {
                List<Project> projectsToBeValidated = _projectService.GetProjetsToValidate();
                List<ProjectViewModel> projectsToBeValidatedViewModel = projectsToBeValidated.Select(p => p.ToProjectViewModel()).ToList();

                int nbProjectsToValidate = projectsToBeValidatedViewModel.Count();

                ViewBag.nbProjectsToValidate = nbProjectsToValidate;

                return View(projectsToBeValidatedViewModel);
            }
            catch (Exception e)
            {
                TempData["Error"] = e.Message;
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }

        }

        [HttpGet]
        public IActionResult Validate(int id)
        {
            try
            {
                Project project = _projectService.GetOneById(id);
                User? admin = _authService.GetUser();
                _projectService.Validate(project, admin);

                TempData["Success"] = $"Le projet {project.Title} a bien été validé !";
                return View("../../Views/Project/Details", project);
            }
            catch (Exception e)
            {
                TempData["Error"] = e.Message;
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }

        [HttpGet]
        public IActionResult Refuse(int id)
        {
            RefuseFormView model = new();
            model.ProjectId = id;
            return View(model);
        }

        [HttpPost]
        public IActionResult Refuse([FromForm] RefuseFormView model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Project project = _projectService.GetOneById(model.ProjectId);
                    project.Comment = model.Comment;

                    User admin = _authService.GetUser();

                    _projectService.Refuse(project, admin);

                    TempData["Error"] = $"Le projet {project.Title} a été refusé.";

                    return View("../../Views/Project/Details", project);
                }

                return View(model);
            }catch(Exception e)
            {
                TempData["Error"] = e.Message;
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
            
        }
    }
}
