using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OyG.Models
{
    public class Herramienta
    {
        
        [Key]
        public int Id_herramienta { get; set; }
        [MaxLength(20)]
        [Required(ErrorMessage ="Se requiere nombre de la herramienta")]
        [Display(Name ="Nombre Herramienta")]
        public string Nombre_herramineta { get; set; }

        [Required(ErrorMessage ="Se requiere Cantidad de Herramienta")]
        public int Cant_herramienta { get; set; }
        [Required(ErrorMessage ="Se reuqiere el estado de la herramienta")]
        public bool Est_hermienta { get; set; }
    }
}
