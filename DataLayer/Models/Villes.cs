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
    
    public partial class Villes
    {
        public Villes()
        {
            this.ZipCodes = new HashSet<ZipCodes>();
        }
    
        public string CodeINSEE { get; set; }
        public string Commune { get; set; }
        public string Statut { get; set; }
        public Nullable<int> AltitudeMoyenne { get; set; }
        public Nullable<double> Superficie { get; set; }
        public Nullable<double> Population { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Longitude { get; set; }
        public string CodeCommune { get; set; }
        public string CodeCanton { get; set; }
        public string CodeArrondissement { get; set; }
        public string NumDep { get; set; }
        public string Nom { get; set; }
        public string NomTri { get; set; }
        public string Prefixe { get; set; }
    
        public virtual Departements Departements { get; set; }
        public virtual ICollection<ZipCodes> ZipCodes { get; set; }
    }
}
