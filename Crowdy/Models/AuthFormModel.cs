using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Crowdy.Models
{
    public class AuthLoginFormModel
    {
        [DisplayName("Votre E-mail")]
        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [DisplayName("Votre mot de passe")]
        [Required]
        [DataType(DataType.Password)]
        public required string Password { get; set; }
    }
    public class AuthRegisterFormModel
    {
        [DisplayName("Nom d'utilisateur")]
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public required string Username { get; set; }

        [DisplayName("E-mail")]
        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [DisplayName("Mot de passe")]
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).+$")]
        public required string Password { get; set; }

        [DisplayName("Confirmation du mot de passe")]
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public required string ConfirmPassword { get; set; }

        [DisplayName("Photo de profil")]
        [FileExtensions(Extensions = "jpg,jpeg,png")]
        public string? Avatar { get; set; }

        [DisplayName("Date de naissance")]
        [Required]
        [DataType(DataType.Date)]
        public required DateTime DateOfBirth { get; set; }
    }
}
