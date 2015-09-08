using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Form113
{
    public class ProduitsAPI
    {
        public string Nom { get; set; }
        public string Description { get; set; }
        public int Prix { get; set; }
        public string Pays { get; set; }
        public string Photo { get; set; }
        public ProduitsAPI(Produits prod)
        {
            Nom = prod.Nom;
            Description = prod.Description;
            Prix = prod.Prix;
            Pays = prod.Pays.Name;
            Photo = "Uploads/"+prod.Photos.First().PhotoName;

        }
        public ProduitsAPI() { }
    }
}