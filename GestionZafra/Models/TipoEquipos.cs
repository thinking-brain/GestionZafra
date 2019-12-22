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
    
    public partial class TipoEquipos
    {
        public TipoEquipos()
        {
            this.ParqueEquipos = new HashSet<ParqueEquipos>();
        }
    
        public int id { get; set; }

        [Required(ErrorMessage = "Este Campo es requerido")]
        [Display(Name = "Tipo de Equipo")]
        [Remote("CheckTipoEquipo", "TipoEquipos", AdditionalFields = "id", ErrorMessage = "Ya existe este tipo de equipo")]
        public string descripcionEquipo { get; set; }
    
        public virtual ICollection<ParqueEquipos> ParqueEquipos { get; set; }
    }
}