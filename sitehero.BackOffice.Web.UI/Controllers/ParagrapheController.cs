using Microsoft.AspNetCore.Mvc;
using sitehero.Core.Data.Models;

namespace sitehero.backoffice.Web.UI.Controllers
{
    public class ParagrapheController : Controller
    {
        #region A supprimer après entitities
        private List<Paragraphe> _maListe = new List<Paragraphe>()
        {
            new Paragraphe() { Id = 1, Numero = 1, Titre = "Titre 1"},
            new Paragraphe() { Id = 2, Numero = 10, Titre = "Titre 2"},
            new Paragraphe() { Id = 5, Numero = 14, Titre = "Titre 3"}
        };
        #endregion

        #region Méthodes publiques
        public ActionResult Index() {
            
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Paragraphe paragraphe)
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            Paragraphe paragraphe = null;
            
            paragraphe = _maListe.First(p => p.Id == id);

            return View(paragraphe);
        }
        #endregion

    }
}
