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
    
    public partial class Article
    {
        public int ID { get; set; }
        public int UtilisateurID { get; set; }
        public string Titre_article { get; set; }
        public string Description { get; set; }
        public string Contenu_article { get; set; }
        public string Image { get; set; }
        public string Url_video { get; set; }
        public Nullable<System.DateTime> Date_creation { get; set; }
    
        public virtual Utilisateur Utilisateur { get; set; }
    }
}
