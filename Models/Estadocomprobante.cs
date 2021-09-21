using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OyG.Models
{
    public class Estadocomprobante
    {
        [Key]
        int Id { get; set; }

        [MaxLength(30)]
        [Required(ErrorMessage ="campo requerido")]
        [Display(Name ="Nombre del estado de comprobante")]
        string Nombre_estado_comprobante { get; set; }
    }
}
