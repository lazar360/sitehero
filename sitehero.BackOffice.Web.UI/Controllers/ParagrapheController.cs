using Microsoft.AspNetCore.Mvc;
using sitehero.Core.Data.Models;

namespace sitehero.backoffice.Web.UI.Controllers
{
    public class ParagrapheController : Controller
    {
        #region Champs privés
        private DefaultContext _context;
        #endregion

        #region Constructeurs
        public ParagrapheController(DefaultContext context)
        {
            this._context = context;
        }
        #endregion

        #region Méthodes publiques
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Paragraphe paragraphe)
        {
            if (ModelState.IsValid)
            {
                this._context.Paragraphe.Add(paragraphe);
                this._context.SaveChanges();
                return RedirectToAction("Index");

            }

            return View(paragraphe);
        }

        public ActionResult Edit(int id)
        {
            Paragraphe paragraphe = this._context.Paragraphe.First(item => item.Id == id);

            return View(paragraphe);
        }

        [HttpPost]
        public ActionResult Edit(Paragraphe paragraphe)
        {
            if (ModelState.IsValid)
            {
                this._context.Attach<Paragraphe>(paragraphe);
                this._context.Paragraphe.Update(paragraphe);
                this._context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(paragraphe);
        }
        #endregion

    }
}
