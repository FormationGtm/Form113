using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Form113.Controllers
{
    public class NewsLetterController : Controller
    {

        BestArtEntities db = new BestArtEntities();

        // GET: NewsLetter
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index(string msg)
        {
            return View(msg);
        }

        public ActionResult Delete(string id)
        {
            var identities = db.Identites.Where(x => x.Email == id);
            if (identities.Count() == 1)
            {
                identities.First().Newsletter = 0;
                db.Entry(identities).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Changement réussi");
            }
            if (identities.Count()>1)
            {
                return RedirectToAction("Index", "Email non trouve contacter l'administrateur");
            }
            return RedirectToAction("Index", "L'email specifie ne correspond a aucun email dans notre base de donnée");

        }
    }

}