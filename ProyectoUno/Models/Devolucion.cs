//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoUno.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Devolucion
    {
        [Display(Name = "Cedula")]
        public int Cedula { get; set; }
        [Display(Name = "Codigo")]
        public int Codigo { get; set; }
        [Display(Name = "Fecha de devolucion")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyu/MM/dd}")]
        [DataType(DataType.DateTime)]
        public System.DateTime Devolucion1 { get; set; }
        [Display(Name = "Cantidad")]
        public int Cantidad { get; set; }
    }
}
