//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DE_Recrutement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Status_Dde
    {
        public int Id { get; set; }
        public string Status_Dde_demandeur { get; set; }
        public Nullable<System.DateTime> Date_Crea_demandeur { get; set; }
        public string Status_Dde_chef { get; set; }
        public Nullable<System.DateTime> Date_Dde_chef { get; set; }
        public string Motif_Ref_chef { get; set; }
        public string Status_Dde_rh { get; set; }
        public Nullable<System.DateTime> Date_Dde_rh { get; set; }
        public string Motif_Ref_rh { get; set; }
        public string Status_Dde_ds { get; set; }
        public Nullable<System.DateTime> Date_Dde_ds { get; set; }
        public string Motif_Ref_ds { get; set; }
        public string StatusDemandeFinal { get; set; }
        public int IdDemande { get; set; }
    
        public virtual Dde_Recrutement Dde_Recrutement { get; set; }
    }
}
