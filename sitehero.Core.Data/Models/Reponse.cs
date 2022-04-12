using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sitehero.Core.Data.Models
{
    public class Reponse
    {
        #region Propriétés
        /// <summary>
        /// Id de la réponse
        /// </summary>
        public int Id{get; set;}
        /// <summary>
        /// Proposition de réponse
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Liste des réponses possibles
        /// </summary>
        public List<Reponse> MesReponses { get; set; }
        #endregion
    }
}
