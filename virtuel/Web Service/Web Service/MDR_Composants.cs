//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_Service
{
    using System;
    using System.Collections.Generic;
    
    public partial class MDR_Composants
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MDR_Composants()
        {
            this.MDR_Contient_Composants_Modules = new HashSet<MDR_Contient_Composants_Modules>();
            this.MDR_Devis = new HashSet<MDR_Devis>();
            this.MDR_Fournisseurs = new HashSet<MDR_Fournisseurs>();
            this.MDR_Sites = new HashSet<MDR_Sites>();
        }
    
        public int Comp_Index { get; set; }
        public string Comp_Nom { get; set; }
        public string Comp_Type { get; set; }
        public string Comp_Couleur { get; set; }
        public Nullable<int> Comp_Actif { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MDR_Contient_Composants_Modules> MDR_Contient_Composants_Modules { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MDR_Devis> MDR_Devis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MDR_Fournisseurs> MDR_Fournisseurs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MDR_Sites> MDR_Sites { get; set; }
    }
}
