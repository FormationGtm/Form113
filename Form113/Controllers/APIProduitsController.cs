using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using DataLayer.Models;
using System.Xml.Serialization;
using System.IO;

namespace Form113.Controllers
{
    public class APIProduitsController : ApiController
    {
        private BestArtEntities db = new BestArtEntities();

        // GET: api/APIProduits
        public IQueryable<Produits> GetProduits()
        {
            return db.Produits;
        }

        // GET: api/APIProduits/5
        [ResponseType(typeof(Produits))]
        public IHttpActionResult GetProduits(int id)
        {
            var produits = db.Produits.Where(p=>p.IdProduit==id).First();
            if (produits == null)
            {
                return NotFound();
            }
            ProduitsAPI produit = new ProduitsAPI(produits);
            var xmlSerializer = new XmlSerializer(typeof(ProduitsAPI));
            var writer = new StringWriter();
            xmlSerializer.Serialize(writer, produit);
            return Ok(writer.ToString());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProduitsExists(int id)
        {
            return db.Produits.Count(e => e.IdProduit == id) > 0;
        }
    }
}