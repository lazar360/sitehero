using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sitehero.Core.Data.Models
{
    [Table("Question")]
    public class Question
    {
        #region Propriété
        /// <summary>
        /// Id venant de la base de données
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Titre de la question
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Le titre est obligatoire")]
        public string? Titre { get; set; } = "Titre par défaut";

        /// <summary>
        /// Id du paragraphe
        /// </summary>
        public int ParagrapheId { get; set; }

        /// <summary>
        /// Liste des réponses possibles à la question
        /// </summary>
        public List<Reponse>? MesReponses { get; set; }
        #endregion

    }
}
