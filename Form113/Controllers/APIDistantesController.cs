using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Form113.Controllers
{
    public class APIDistantesController : Controller
    {
        // GET: APIDistantes
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult partenaire()
        {
            return PartialView("_partenaire");
        } 
    }
}