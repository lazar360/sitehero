using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace sitehero.Core.Data.DataLayer
{
    /// <summary>
    /// Layer gérant les échanges vers la base de données pour les paragraphes
    /// </summary>
    public class ParagrapheDataLayer
    {
        #region Fields
        private DefaultContext _context;
        #endregion

        #region Constructors
        public ParagrapheDataLayer(DefaultContext context)
        {
            _context = context;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Retourne le premier paragraphe
        /// </summary>
        /// <returns></returns>
        public Models.Paragraphe GetFirst()
        {
            //return new Models.Paragraphe() { 
            //Description = "escription Paragraphe en dur dans datatlayer",
            //    Titre = "Titre Paragraphe en dur dans datatlayer",
            //    MaQuestion = new Models.Question() { 
            //        Titre = "Ma Question en dur dans datatlayer",  
            //        MesReponses = new List<Models.Reponse>()
            //        {
            //        new Models.Reponse() { Description = "Reponse 1 en dur dans datalayer" },
            //        new Models.Reponse() { Description = "Reponse 2 en dur dans datalayer" }
            //        }
            //    }
            //};

#pragma warning disable CS8602 // Déréférencement d'une éventuelle référence null.
            return _context.Paragraphe
                .Include(item => item.MaQuestion)
                .ThenInclude(item => item.MesReponses)
                .First(item => item.EstInitial);
#pragma warning restore CS8602 // Déréférencement d'une éventuelle référence null.
        }

        /// <summary>
        /// Retourne un paragraphe 
        /// </summary>
        /// <param name="id">identifiant du paragraphe recherché</param>
        /// <returns></returns>
        public Models.Paragraphe GetOne(int id)
        {
            return _context.Paragraphe
                .Include(item => item.MaQuestion)
                .ThenInclude(item => item.MesReponses)
                .First(item => item.Id == id);
        }

    }
        #endregion
}

