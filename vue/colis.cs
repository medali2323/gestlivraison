//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace vue
{
    using System;
    using System.Collections.Generic;
    
    public partial class colis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public colis()
        {
            this.etatcolis = new HashSet<etatcolis>();
            this.Reclamation = new HashSet<Reclamation>();
        }
    
        public int codecolis { get; set; }
        public string nomclt { get; set; }
        public string gouvernemant { get; set; }
        public string ville { get; set; }
        public string adresseclt { get; set; }
        public string telclt { get; set; }
        public string telclt2 { get; set; }
        public string des { get; set; }
        public double prix { get; set; }
        public int nbartticle { get; set; }
        public string commentaire { get; set; }
        public string modepaiment { get; set; }
        public Nullable<int> Codeexpediteur { get; set; }
    
        public virtual expediteur expediteur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<etatcolis> etatcolis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reclamation> Reclamation { get; set; }
    }
}
