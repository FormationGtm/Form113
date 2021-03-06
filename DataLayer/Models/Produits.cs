//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produits
    {
        public Produits()
        {
            this.Commandes_details = new HashSet<Commandes_details>();
            this.Photos = new HashSet<Photos>();
            this.Commentaire = new HashSet<Commentaire>();
            this.Visibiliter = new HashSet<Visibiliter>();
        }
    
        public int IdProduit { get; set; }
        public string Nom { get; set; }
        public string Couleur { get; set; }
        public string Description { get; set; }
        public int Prix { get; set; }
        public int IdSousCategorie { get; set; }
        public System.DateTime DateMiseEnVente { get; set; }
        public Nullable<double> Promotion { get; set; }
        public byte MisEnAvant { get; set; }
        public string CodePays { get; set; }
        public Nullable<int> Stock { get; set; }
        public Nullable<int> NbVues { get; set; }
    
        public virtual ICollection<Commandes_details> Commandes_details { get; set; }
        public virtual Pays Pays { get; set; }
        public virtual ICollection<Photos> Photos { get; set; }
        public virtual SousCategories SousCategories { get; set; }
        public virtual ICollection<Commentaire> Commentaire { get; set; }
        public virtual ICollection<Visibiliter> Visibiliter { get; set; }

        
    }
}
