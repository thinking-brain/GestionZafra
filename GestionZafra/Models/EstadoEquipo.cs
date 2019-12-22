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
    
    public partial class EstadoEquipo
    {
        public EstadoEquipo()
        {
            this.DiarioOperadorCombinadas = new HashSet<DiarioOperadorCombinadas>();
        }
    
        public int id { get; set; }

        [Required(ErrorMessage = "Este Campo es requerido")]
        [Display(Name = "Estado")]
        [Remote("CheckEstadoEquipo", "EstadoEquipo", AdditionalFields = "id", ErrorMessage = "Ya existe esta zafra")]
        public string nombreEstado { get; set; }
    
        public virtual ICollection<DiarioOperadorCombinadas> DiarioOperadorCombinadas { get; set; }
    }
}
