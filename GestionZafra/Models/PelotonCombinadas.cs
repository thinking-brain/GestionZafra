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
    
    public partial class PelotonCombinadas
    {
        public PelotonCombinadas()
        {
            this.OperadorCombinada = new HashSet<OperadorCombinada>();
        }
    
        public int id { get; set; }

        [Required(ErrorMessage = "Este Campo es requerido")]
        [Display(Name = "Cantidad de Combinadas")]
        [Range(0, Double.MaxValue, ErrorMessage = "El valor debe ser positivo")]
        public int parque { get; set; }

        [Required(ErrorMessage = "Este Campo es requerido")]
        public int Suministradoresid { get; set; }

    
        public virtual ICollection<OperadorCombinada> OperadorCombinada { get; set; }
        public virtual Suministradores Suministradores { get; set; }
    }
}
