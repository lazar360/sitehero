using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sitehero.Core.Data.Models
{
    [Table("Paragraphe")]
    public class Paragraphe
    {
        
        #region Propriétés
        /// <summary>
        /// Id venant de la base
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Numéro à afficher pour le jeu
        /// </summary>
        [Range(1, 500, ErrorMessage = "Le numéro doit être compris entre 1 et 500")]
        public int Numero { get; set; }

        /// <summary>
        ///  C'est le titre du paragraphe
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Le titre est obligatoire")]
        public string? Titre { get; set; } = "Titre par défaut";

        /// <summary>
        /// Description du paragraphe
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "La description est obligatoire")]
        public string? Description { get; set; } = "Description par défaut";

        /// <summary>
        /// Indique si c'est le paragraphe de démarrage
        /// <summary>
        public bool EstInitial { get; set; }


        /// <summary>
        /// Ce sont les questions
        /// </summary>
        public Question? MaQuestion { get; set; }

        /// <summary>
        /// Liste des réponses possibles
        /// </summary>
        public IEnumerable<Reponse> Reponses { get; set; }

        public string? Image { get; set; }
        #endregion


    }
}
