using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Models.Paragraphe GetFirst()
        {
            return new Models.Paragraphe() { 
            Description = "escription Paragraphe en dur dans datatlayer",
                Titre = "Titre Paragraphe en dur dans datatlayer",
                MaQuestion = new Models.Question() { 
                    Titre = "Ma Question en dur dans datatlayer",  
                    MesReponses = new List<Models.Reponse>()
                    {
                    new Models.Reponse() { Description = "Reponse 1 en dur dans datalayer" },
                    new Models.Reponse() { Description = "Reponse 2 en dur dans datalayer" }
                    }
                }
            };

        }
    }
        #endregion
}

