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
        public int Id { get; set; }
        
        [MaxLength(25)]
        [Required(ErrorMessage ="Se requiere nombre de la herramienta")]
        [Display(Name ="Nombre Herramienta")]
        public string Nombre_herramineta { get; set; }

        [Required(ErrorMessage ="Se requiere Cantidad de Herramienta")]
        public int Cantidad_herramienta { get; set; }
        
        [Required(ErrorMessage ="Se reuqiere el estado de la herramienta")]
        public bool Estado_hermienta { get; set; }
    }
}
