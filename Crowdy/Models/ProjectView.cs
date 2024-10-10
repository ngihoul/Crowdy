using Crowdy.DAL.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Crowdy.Models
{
    public class ProjectFormView
    {
        [DisplayName("Titre du projet")]
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [DisplayName("Description du projet")]
        [Required]
        public string Description { get; set; }

        [DisplayName("Objectif financier du projet")]
        [Required]
        [DataType(DataType.Currency)]
        [Range(0, double.MaxValue)]
        public decimal Objective { get; set; }

        [DisplayName("Photo du projet")]
        [FileExtensions(Extensions = "jpg,jpeg,png")]
        public string? ImageUrl { get; set; }

        [DisplayName("Date de début")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DisplayName("Date de fin")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [DisplayName("Catégories")]
        public string Categories { get; set; }

        [DisplayName("Paliers des contre-parties")]
        public List<ProjectThresholdFormView> ProjectThresholds { get; set; } = new List<ProjectThresholdFormView> {
                                                                                    new ProjectThresholdFormView(),
                                                                                    new ProjectThresholdFormView(),
                                                                                    new ProjectThresholdFormView()
                                                                            };
    }

    public class ProjectViewModel
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Titre du projet")]
        [MaxLength(100)]
        public string Title { get; set; }

        [DisplayName("Description du projet")]
        public string Description { get; set; }

        [DisplayName("Objectif financier du projet")]
        [DataType(DataType.Currency)]
        [Range(0, double.MaxValue)]
        public decimal Objective { get; set; }

        [DisplayName("Photo du projet")]
        [FileExtensions(Extensions = "jpg,jpeg,png")]
        public string? ImageUrl { get; set; }

        [DisplayName("Date de début")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime StartDate { get; set; }

        [DisplayName("Date de fin")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime EndDate { get; set; }

        [DisplayName("Catégories")]
        public List<Category> Categories { get; set; }

        [DisplayName("Paliers des contre-parties")]
        public List<ProjectThreshold> ProjectThresholds { get; set; }

        public List<ProjectContribution> Contributions { get; set; }

        [DisplayName("Créateur")]
        public User Owner { get; set; }

        [DisplayName("Statut")]
        public Status Status { get; set; }

        [DisplayName("Date de création")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreatedAt { get; set; }

        [DisplayName("Date de mise à jour")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}")]
        public DateTime UpdatedAt { get; set; }
    }

    public class ProjectThresholdFormView
    {
        [DisplayName("Montant")]
        [Required]
        public decimal Amount { get; set; }

        /*[ValidateNever]
        public Project? Project { get; set; }*/

        [DisplayName("Description")]
        [Required]
        public string Description { get; set; }
    }

    public class RefuseFormView
    {
        [DisplayName("Raison")]
        [Required]
        public string Comment { get; set; }

        [Required]
        public int ProjectId { get; set; }
    }
}
