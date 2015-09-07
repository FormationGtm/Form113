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
        public JsonResult GetJSONStatistique()
        {
            BestArtEntities  db = new BestArtEntities();

            var V = db.Visibiliter.Where(pt => pt.DateVis >= new DateTime(2015, 1, 1) && pt.DateVis < new DateTime(2015, 12, 31))
                      .Join(db.Produits, pt => pt.ProduitRef, p => p.IdProduit, (pt, p) => new { pt.DateVis, p.Nom })
                      .GroupBy(x => x.Nom)
                      .Select(g => new { Nom = g.Key.Trim(), NbVis = g.Count() })
                      .OrderBy(x => x.Nom);
            return Json(V, JsonRequestBehavior.AllowGet);
        }

        // GET: Admin/Statistique
        public ActionResult Index()
        {
            return View();
        }
    }
}