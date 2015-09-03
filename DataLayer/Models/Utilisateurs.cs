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
    
    public partial class Utilisateurs
    {
        public Utilisateurs()
        {
            this.Commandes = new HashSet<Commandes>();
        }
    
        public int IdUtilisateur { get; set; }
        public string IdAsp { get; set; }
        public int IdAdresse { get; set; }
        public Nullable<int> NbCommande { get; set; }
        public System.DateTime DateInscription { get; set; }
        public Nullable<System.DateTime> LastConnection { get; set; }
        public Nullable<int> IdIdentite { get; set; }
    
        public virtual Adresses Adresses { get; set; }
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual ICollection<Commandes> Commandes { get; set; }
        public virtual Identites Identites { get; set; }
    }
}
