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
    
    public partial class Initiative
    {
        public int ID { get; set; }
        public int UtilisateurID { get; set; }
        public string Nom_init { get; set; }
        public Nullable<bool> Statu_init { get; set; }
        public Nullable<System.DateTime> Date_debu { get; set; }
        public Nullable<System.DateTime> Date_fin { get; set; }
        public string Objectifs_generaux { get; set; }
        public string Obgectifs_specifiques { get; set; }
        public string Description_court { get; set; }
        public string Description_detaillee { get; set; }
        public Nullable<float> Budget { get; set; }
        public string Approbateur { get; set; }
        public string Cofinancement { get; set; }
        public string Regions { get; set; }
    
        public virtual Utilisateur Utilisateur { get; set; }
    }
}
