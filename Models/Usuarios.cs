using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OyG.Models
{
    public class Usuarios
    {
        [Key]
        public string Usuario { get; set; }

        [MaxLength(15)]
        [Required(ErrorMessage ="Se requiere este campo ")]
        [Display(Name ="Contraseña")]
        public string Contraseña { get; set; }

        [MaxLength(20)]
        [Required(ErrorMessage = "Se requiere este campo ")]
        [Display(Name = "Rol del empleado")]
        public string Rol { get; set; }
       
        [Display(Name = "Estado")]
        [Required(ErrorMessage ="Se requiere este campo")]
        public bool Estado_usuario { get; set; }
    }
}
