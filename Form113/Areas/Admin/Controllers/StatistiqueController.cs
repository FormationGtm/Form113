using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Form113.Areas.Admin.Controllers
{
    public class StatistiqueController : Controller
    {
        public JsonResult GetJSONStatistique(string id)
        {
            BestArtEntities  db = new BestArtEntities();

            var val = id.Split('-');
            int min = int.Parse(val[0]);
            int max = int.Parse(val[1]);

            var V = db.Visibiliter.Where(pt => pt.DateVis >= new DateTime(min, 1, 1) && pt.DateVis < new DateTime(max, 12, 31))
                      .Join(db.Produits, pt => pt.ProduitRef, p => p.IdProduit, (pt, p) => new { pt.DateVis, p.Pays })
                      .GroupBy(x => x.Pays)
                      .Select(g => new { Nom = g.Key.Name.Trim(), NbVis = g.Count() })
                      .OrderBy(x => x.Nom);
            return Json(V, JsonRequestBehavior.AllowGet);
        }

        // GET: Admin/Statistique
        public ActionResult Index()
        {
            
            BestArtEntities  db = new BestArtEntities();
            ViewBag.min = db.Visibiliter.Min(x => x.DateVis);
            ViewBag.max = db.Visibiliter.Max(x => x.DateVis);


            return View();
        }
    }
}