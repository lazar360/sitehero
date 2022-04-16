using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sitehero.Core.Data.Models
{
    [Table("Aventure")]
    public class Aventure
    {
        #region Propriétés
        /// <summary>
        /// C'est l'id de l'aventure
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// C'est le titre de l'aventure
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Le titre est obligatoire")]
        public string Titre{ get; set; }
        #endregion
         
    }
}
