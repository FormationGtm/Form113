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
    
    public partial class Commentaire
    {
        public Commentaire()
        {
            this.Commentaire1 = new HashSet<Commentaire>();
        }
    
        public int IdCommentaire { get; set; }
        public Nullable<int> ProduitRef { get; set; }
        public Nullable<int> CommRef { get; set; }
        public string Texte { get; set; }
        public Nullable<int> Num { get; set; }
        public System.DateTime DateComm { get; set; }
        public Nullable<int> UserRef { get; set; }
    
        public virtual ICollection<Commentaire> Commentaire1 { get; set; }
        public virtual Commentaire Commentaire2 { get; set; }
        public virtual Produits Produits { get; set; }
        public virtual Utilisateurs Utilisateurs { get; set; }
    }
}