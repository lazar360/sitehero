using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sitehero.Core.Data.Models
{
    [Table("Reponse")]
    public class Reponse
    {
        #region Propriétés
        /// <summary>
        /// Id de la réponse
        /// </summary>
        [Key]
        public int Id{get; set;}
        /// <summary>
        /// Proposition de réponse
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "La descripion est obligatoire")]
        public string? Description { get; set; } = "description par défaut";

        public int QuestionId { get; set; }

        /// <summary>
        /// Liste des réponses possibles
        /// </summary>
        //[NotMapped]
        //public List<Reponse> MesReponses { get; set; }
        #endregion
    }
}
