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
    
    public partial class ParametrosGenerales
    {
        [Required(ErrorMessage = "Este Campo es requerido")]
        [Display(Name = "Codigo de la Empresa")]
        [Range(0, int.MaxValue, ErrorMessage = "El valor debe ser entero positivo")]
        public int codigoEmpresa { get; set; }

        [Required(ErrorMessage = "Este Campo es requerido")]
        [Display(Name = "Nombre de la Empresa")]
        public string nombreEmpresa { get; set; }

        [Required(ErrorMessage = "Este Campo es requerido")]
        [Display(Name = "Fecha Actual")]
        [DataType(DataType.Date)]
        public System.DateTime fechaActual { get; set; }

        [Display(Name = "Zafra Actual")]
        public int zafraAct { get; set; }
    
        public virtual Zafras Zafras { get; set; }
    }
}
