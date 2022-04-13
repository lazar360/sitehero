using Microsoft.AspNetCore.Mvc;
using sitehero.Core.Data.Models;
using sitehero.Models;

namespace sitehero.Controllers
{
    public class AventureController : Controller
    {
        private readonly DefaultContext _context = null;
        public AventureController(DefaultContext context)
        {
            this._context = context;
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Aventures";

            var query = from item in _context.Aventure
                        select item;

            return View(query.ToList());
        }
    }
}
