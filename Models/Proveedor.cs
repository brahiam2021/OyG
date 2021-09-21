using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OyG.Models
{
    public class Proveedor
    {
        [Key]
        public int Nit_proveedor { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage ="Se requiere este campo")]
        [Display(Name ="Nombre del proveedor")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        public string Nombre_proveedor { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Se requiere este campo")]
        [Display(Name = "Correo electronico")]
        [EmailAddress]
        public string Correo_proveedor { get; set; }
        [MaxLength(100)]
        [Required(ErrorMessage = "Se requiere este campo")]
        [Display(Name = "Direccion del proveedor")]
        public string Direccion_proveedor { get; set; }

        [Required(ErrorMessage ="Campo requerido")]
        [Phone]
        public int Telefono_proveedor { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public bool Estado_proveedor { get; set; } 
    }
}
