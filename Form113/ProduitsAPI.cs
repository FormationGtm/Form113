using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Form113
{
    public class ProduitsAPI
    {
        public string Titre { get; set; }
        public string Description { get; set; }
        public string Prix { get; set; }
        public string Localisation { get; set; }
        public string Image { get; set; }
        public string url { get; set; }

        public ProduitsAPI(Produits prod)
        {
            Titre = prod.Nom;
            Description = prod.Description;
            Prix = prod.Prix.ToString();
            Localisation = prod.Pays.Name;
            Image = "/Uploads/" + prod.Photos.First().PhotoName;
            url ="http://Form113.dlucazeau.fr/Produit/Detail/"+ prod.IdProduit;
        }

        public ProduitsAPI() { }
    }
}