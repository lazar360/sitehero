using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sitehero.Core.Data.Models
{
    public class Question
    {
        #region Propriété
        /// <summary>
        /// Id venant de la base de données
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Titre de la question
        /// </summary>
        public string Titre { get; set; }
        /// <summary>
        /// Contenu de la question du paragraphe
        /// </summary>
        public Question MaQuestion { get; set; }
        /// <summary>
        /// Liste des réponses possibles à la question
        /// </summary>
        public List<Reponse> MesReponses { get; set; }
        #endregion

    }
}
