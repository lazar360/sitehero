using Microsoft.AspNetCore.Mvc;
using sitehero.Models;

namespace sitehero.Controllers
{
    public class AventureController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Aventures";

            List<Aventure> myArray = new List<Aventure>();

            myArray.Add(new Aventure
            {
                Id = 1,
                Titre = "Ma première aventure",
            });
            
            myArray.Add(new Aventure
            {
                Id = 1,
                Titre = "Ma seconde aventure",
            });
            
            return View(myArray);
        }
    }
}
