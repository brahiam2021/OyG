using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OyG.Models
{
    public class HerramientaEmpl
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey ("HerramientaId")]
        public Herramienta Herramienta { get; set; }
        [ForeignKey ("EmpleadoId")]
        public Empleado Empleado { get; set; }

        [Required(ErrorMessage ="Se requiere el campo")]
        public bool Estado { get; set; }
    }
}
