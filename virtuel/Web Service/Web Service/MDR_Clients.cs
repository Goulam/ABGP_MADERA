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
    
    public partial class MDR_Clients
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MDR_Clients()
        {
            this.MDR_Commandes = new HashSet<MDR_Commandes>();
            this.MDR_Devis = new HashSet<MDR_Devis>();
            this.MDR_Devis1 = new HashSet<MDR_Devis>();
        }
    
        public int Cli_Index { get; set; }
        public string Cli_Nom { get; set; }
        public string Cli_Prenom { get; set; }
        public string Cli_Adresse { get; set; }
        public string Cli_Email { get; set; }
        public string Cli_Phone { get; set; }
        public Nullable<int> Cli_Age { get; set; }
        public string Cli_Ville { get; set; }
        public string Cli_CP { get; set; }
        public Nullable<int> Cli_Actif { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MDR_Commandes> MDR_Commandes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MDR_Devis> MDR_Devis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MDR_Devis> MDR_Devis1 { get; set; }
    }
}