//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MinistreFin.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Evenement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Evenement()
        {
            this.Utilisateurs = new HashSet<Utilisateur>();
        }
    
        public int ID { get; set; }
        public string Titre_even { get; set; }
        public Nullable<int> Description { get; set; }
        public string Image { get; set; }
        public Nullable<System.DateTime> Date_debut { get; set; }
        public Nullable<System.DateTime> Date_fin { get; set; }
        public Nullable<bool> Statut { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Utilisateur> Utilisateurs { get; set; }
    }
}