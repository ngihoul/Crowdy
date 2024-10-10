using Crowdy.BLL.Services;
using Crowdy.BLL.Services.Interfaces;
using Crowdy.DAL.Entities;
using Crowdy.Mappers;
using Crowdy.Models;
using Microsoft.AspNetCore.Mvc;

namespace Crowdy.Controllers
{
    public class ProjectController : Controller
    {
        private const string PROJECT_PATH = @"\img\thumbnails";

        private readonly IProjectService _projectService;
        private readonly ICategoryService _categoryService;
        private readonly IUserService _userService;
        private readonly IStatusService _statusService;
        private readonly IProjectThresholdService _projectThresholdService;
        private readonly IProjectContributionService _projectContributionService;

        private readonly IWebHostEnvironment _webHostEnvironment;

        private readonly FileService _fileService;
        private readonly AuthService _authService;

        public ProjectController(IProjectService projectService, ICategoryService categoryService, IWebHostEnvironment webHostEnvironment, FileService fileService, IUserService userService, IStatusService statusService, IProjectThresholdService projectThresholdService, IProjectContributionService projectContributionService, AuthService authService)
        {
            _projectService = projectService;
            _categoryService = categoryService;
            _userService = userService;
            _statusService = statusService;
            _projectThresholdService = projectThresholdService;
            _projectContributionService = projectContributionService;

            _webHostEnvironment = webHostEnvironment;
            _fileService = fileService;
            _authService = authService;
        }

        public IActionResult Index()
        {
            try
            {
                List<Project> projects = _projectService.GetAllValidated();

                List<ProjectViewModel> projectsViewModel = projects.Select(p => p.ToProjectViewModel()).ToList();

                return View(projectsViewModel);
            }
            catch (Exception e)
            {
                TempData["error"] = e.Message;
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }

        public IActionResult Details(int id)
        {
            try
            {
                Project project = _projectService.GetOneById(id);

                return View(project);
            }
            catch (Exception e)
            {
                TempData["error"] = e.Message;
                return RedirectToAction(nameof(ProjectController.Index), "Home");
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            ProjectFormView model = new ProjectFormView();
            getCategories();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create([FromForm] ProjectFormView model, IFormFile? file)
        {
            if (!ModelState.IsValid)
            {
                getCategories();
                return View(model);
            }

            try
            {
                Project project = model.ToProject();

                // Handling image
                if (file != null)
                {
                    string path = _webHostEnvironment.WebRootPath + PROJECT_PATH;
                    project.ImageUrl = _fileService.SaveFile(path, file);
                }

                // Handling category
                string selectedCategories = model.Categories;
                var selectedCategoriesId = selectedCategories.Split(',');

                foreach (string categoryId in selectedCategoriesId)
                {
                    Category category = _categoryService.GetOneById(int.Parse(categoryId));
                    project.Categories.Add(category);
                }

                // Handling Thresholds
                foreach (var threshold in project.ProjectThresholds)
                {
                    threshold.Project = project;
                }

                // Handling User
                // TODO : get connected User
                User user = _userService.GetOneByEmail("ngihoul@hotmail.com");
                project.Owner = user;

                _projectService.Create(project);

                return RedirectToAction(nameof(ProjectController.Index), "Project");
            }
            catch (Exception e)
            {
                TempData["Error"] = e.Message;
                getCategories();
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Contribute(int id)
        {
            try
            {
                ProjectThreshold threshold = _projectThresholdService.GetOneById(id);
                User user = _authService.GetUser();

                ProjectContribution contribution = new(threshold.Project, user, threshold.Amount);

                _projectContributionService.Create(contribution);
                Project project = _projectService.GetOneById(threshold.Project.Id);

                TempData["Success"] = $"Votre participation de {threshold.Amount}€ a bien été prise en compte. {project.Owner.Username} vous remercie !";
                return View(nameof(ProjectController.Details), project);
            }
            catch (Exception e)
            {
                TempData["Error"] = e.Message;
                return RedirectToAction(nameof(HomeController), "Home");
            }
        }

        [HttpPost]
        public IActionResult Contribute([FromForm] ContributionFormView model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ProjectContribution contribution = new ProjectContribution();

                    contribution.Project = _projectService.GetOneById(model.ProjectId);
                    contribution.User = _userService.GetOneByEmail("ngihoul@hotmail.com");
                    contribution.Amount = model.Amount;

                    _projectContributionService.Create(contribution);

                    TempData["Success"] = $"Merci pour votre participation de {contribution.Amount}€ au projet {contribution.Project.Title} !";

                    return RedirectToAction(nameof(ProjectController.Details), new { id = model.ProjectId });
                }
            }
            catch (Exception e)
            {
                TempData["Error"] = e.Message;
            }

            return View(model);
        }

        private void getCategories()
        {
            ViewBag.categories = _categoryService.GetAll();
        }

    }
}
