using Microsoft.AspNetCore.Mvc;
using sitehero.Core.Data.Models;

namespace sitehero.backoffice.Web.UI.Controllers
{
    public class ReponseController : Controller
    {
        #region Champs privés
        private DefaultContext _context;
        #endregion

        #region Constructeurs
        public ReponseController(DefaultContext context)
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
            this.SetQuestionList();
            return View();
        }

        [HttpPost]
        public IActionResult Add(Reponse reponse)
        {
            if (this.ModelState.IsValid)
            {
                this._context.Reponse.Add(reponse);
                this._context.SaveChanges();
            }

            this.SetQuestionList();
            return this.View(reponse);

        }
        private void SetQuestionList()
        {
            this.ViewBag.QuestionListe = this._context.Question.ToList();
        }

    }
}
