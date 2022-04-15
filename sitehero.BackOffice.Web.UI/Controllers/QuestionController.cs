using Microsoft.AspNetCore.Mvc;
using sitehero.Core.Data.Models;

namespace sitehero.backoffice.Web.UI.Controllers
{
    public class QuestionController : Controller
    {
        #region Champs privés
        private DefaultContext _context;
        #endregion
        
        #region Constructeurs
        public QuestionController(DefaultContext context)
        {
            this._context = context;
        }
        #endregion

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            ViewBag.QuestionListe = this._context.Question.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Add(Question question)
        {
            if (this.ModelState.IsValid)
            {
                this._context.Question.Add(question);
                this._context.SaveChanges();
            }

            this.ViewBag.QuestionListe = this._context.Question.ToList();

            return this.View(question);
           
        }
    }
}
