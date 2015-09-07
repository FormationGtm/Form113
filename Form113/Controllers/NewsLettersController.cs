using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Form113.Controllers
{
    public class NewsLettersController : BestArtController
    {

        BestArtEntities db = new BestArtEntities();

        // GET: NewsLetter
        public ActionResult Index()
        {
            
            var newsletter = new Form113.Models.NewsLettersViewModel();
            newsletter.Message = "Pas d'action possible";
            return View(newsletter);
        }
       

        public ActionResult Delete(string id)
        {
            var newsletter = new Form113.Models.NewsLettersViewModel();
            var identities = db.Identites.Where(x => x.Email == id);
            if (identities.Count() == 1)
            {
                identities.First().Newsletter = 0;
                db.Entry(identities).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
               newsletter.Message="Changement réussi";
            }
            else if (identities.Count() > 1)
            {
                newsletter.Message="Email non trouve contacter l'administrateur";
            }
            else { newsletter.Message="L'email specifie ne correspond a aucun email dans notre base de donnée"; }
            
            
            
            return View("Index", newsletter);
        }
    }

}