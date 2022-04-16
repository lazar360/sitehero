using Microsoft.AspNetCore.Mvc;
using sitehero.Core.Data.DataLayer;
using sitehero.Core.Data.Models;
using sitehero.Models;

namespace sitehero.Controllers
{
    public class AventureController : Controller
    {
        private readonly DefaultContext _context;
        private ParagrapheDataLayer _paragrapheLayer;
        public AventureController(DefaultContext context, ParagrapheDataLayer paragrapheLayer)
        {
            this._context = context;
            this._paragrapheLayer = paragrapheLayer;
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Aventures";

            var query = from item in _context.Aventure
                        select item;

            return View(query.ToList());
        }

        public ActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Create(Aventure aventure)
        {            
            if (ModelState.IsValid)
            {
                _context.Aventure.Add(aventure);
                _context.SaveChanges();
                return RedirectToAction("BeginNewOne");
            }
            
            return View(aventure);
        }

        public ActionResult BeginNewOne()
        {            
            return View(this._paragrapheLayer.GetFirst());
        }

        public ActionResult Edit(int id)
        {
            //this.HttpContext.Session.SetInt32("id", id);

            return View();
        }

    }
}
