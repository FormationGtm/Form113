﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer.Models;

namespace Form113.Areas.Admin.Controllers
{
    public class MarketingController : Controller
    {
        private BestArtEntities db = new BestArtEntities();
        // GET: Admin/Marketing
        public ActionResult Index()
        {
            // Recherche des produits mis en avant : 
            var listProduit = db.Produits.Where(c => c.MisEnAvant == 1).ToList();
            string message = WarningToGive(listProduit);
            ViewBag.Alert = message;
            return View(listProduit);
        }

        // Gestion des Produit
        public ActionResult Remove(string id)
        {
            int idProduit = int.Parse(id);
            var produit = db.Produits.Find(idProduit);
            produit.MisEnAvant = 0;
            db.Entry(produit).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult ChangePromotion(int idProduit, int Promotion)
        {
            var produit = db.Produits.Find(idProduit);
            produit.Promotion = (100 - Promotion) / 100;
            db.Entry(produit).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public string WarningToGive(List<Produits> listProduit)
        {
            int countWarning = 0;
            foreach(var item in listProduit)
            {
                if(item.Stock<=0)
                {
                    countWarning++;
                }
            }
            if (countWarning>0)
            {
                return ("Il y a "+countWarning.ToString() +" produit mis en avant sans stock");
            }
            return "";
        }


        

    }
}