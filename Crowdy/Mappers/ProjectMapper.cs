using Crowdy.DAL.Entities;
using Crowdy.Models;

namespace Crowdy.Mappers
{
    public static class ProjectMapper
    {
        public static Project ToProject(this ProjectFormView model)
        {
            return new Project
            {
                Title = model.Title,
                Description = model.Description,
                Objective = model.Objective,
                ImageUrl = model.ImageUrl,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                Categories = new List<Category>(),
                ProjectThresholds = model.ProjectThresholds.Select(pt => pt.ToProjectThreshold()).ToList(),
                ProjectContributions = new List<ProjectContribution>(),
                Owner = new User(),
                Status = new Status(),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
        }

        public static ProjectViewModel ToProjectViewModel(this Project model)
        {
            return new ProjectViewModel
            {
                Id = model.Id,
                Title = model.Title,
                Description = model.Description,
                Objective = model.Objective,
                ImageUrl = model.ImageUrl,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                Categories = model.Categories,
                ProjectThresholds = model.ProjectThresholds,
                Contributions = model.ProjectContributions,
                Owner = model.Owner,
                Status = model.Status,
                CreatedAt = model.CreatedAt,
                UpdatedAt = model.UpdatedAt

            };
        }
    }

    public static class ProjectThresholdMapper
    {
        public static ProjectThreshold ToProjectThreshold(this ProjectThresholdFormView model)
        {
            return new ProjectThreshold
            {
                Amount = model.Amount,
                Description = model.Description
            };
        }
    }
}
