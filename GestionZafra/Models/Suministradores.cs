//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace GestionZafra.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Suministradores
    {
        public Suministradores()
        {
            this.Campo = new HashSet<Campo>();
            this.ParqueEquipos = new HashSet<ParqueEquipos>();
            this.PelotonCombinadas = new HashSet<PelotonCombinadas>();
        }
    
        public int id { get; set; }

        [Required(ErrorMessage = "Este Campo es requerido")]
        [Display(Name = "Suministrador")]
        [Remote("CheckSuministrador", "Suministradores", AdditionalFields = "id", ErrorMessage = "Ya existe este Suministrador")]
        public string nombreSuministrador { get; set; }

        [Required(ErrorMessage = "Este Campo es requerido")]
        public int TiposSectorPropiedadid { get; set; }

        [Display(Name = "Activo")]
        public bool activo { get; set; }
    
        public virtual ICollection<Campo> Campo { get; set; }
        public virtual ICollection<ParqueEquipos> ParqueEquipos { get; set; }
        public virtual ICollection<PelotonCombinadas> PelotonCombinadas { get; set; }
        public virtual TiposSectorPropiedad TiposSectorPropiedad { get; set; }
    }
}