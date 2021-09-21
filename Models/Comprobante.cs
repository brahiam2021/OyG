using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OyG.Models
{
    public class Comprobante
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Se requiere el campo")]
        [Display(Name ="Valor del comprobante")]
        public double Valor_comprobante { get; set; }

        [Required(ErrorMessage ="se requiere el campo")]
        [Display(Name ="Fecha")]
        [DataType(DataType.Date)]
        public DateTime Fecharegistro { get; set; }


        [Required(ErrorMessage = "se requiere el campo")]
        [Display(Name = "Fecha cancelacion")]
        [DataType(DataType.Date)]
        public DateTime Fechacancelacion { get; set; }

        [MaxLength(25)]
        [Required(ErrorMessage = "se requiere el campo")]
        [Display(Name = "Tipo de Comprobante")]
        public string Tipocomprobante { get; set; }



        [MaxLength(25)]
        [Required(ErrorMessage = "se requiere el campo")]
        [Display(Name = "Estado del comprobante")]
        string Estadocomprobante { get; set; }



    }
}
