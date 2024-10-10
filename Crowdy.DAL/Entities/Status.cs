using System.ComponentModel.DataAnnotations.Schema;

namespace Crowdy.DAL.Entities
{
    public class Status
    {
        #region Constants
        [NotMapped]
        public const string TO_BE_VALIDATED = "A valider";
        [NotMapped]
        public const string VALIDATED = "Validé";
        [NotMapped]
        public const string REJECTED = "Rejeté";
        [NotMapped]
        public const string CLOSED = "Terminé";
        #endregion

        #region Props
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion
    }
}
