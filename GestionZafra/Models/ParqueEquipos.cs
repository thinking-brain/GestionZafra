//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace GestionZafra.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ParqueEquipos
    {
        public ParqueEquipos()
        {
            this.PlanEquiposAgricZafra = new HashSet<PlanEquiposAgricZafra>();
        }
    
        public int id { get; set; }
        
        [Display(Name = "Cantidad de Equipos")]
        [Range(0, Int64.MaxValue, ErrorMessage = "El valor debe ser positivo")]
        public int cantidadEquipos { get; set; }

        [Required(ErrorMessage = "Este Campo es requerido")]
        public int TipoEquiposid { get; set; }

        [Required(ErrorMessage = "Este Campo es requerido")]
        public int Suministradoresid { get; set; }
    
        public virtual Suministradores Suministradores { get; set; }
        public virtual TipoEquipos TipoEquipos { get; set; }
        public virtual ICollection<PlanEquiposAgricZafra> PlanEquiposAgricZafra { get; set; }
    }
}