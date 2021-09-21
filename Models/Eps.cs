using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OyG.Models
{
    public class Eps
    {
        
        [Key]
        public int Id_eps { get; set;}

        [MaxLength(50)]
        [Required(ErrorMessage ="Se requiere nombre eps")]
        [Display(Name ="EPS")]
        public string Nombre_eps { get; set; }

        [Required(ErrorMessage ="Se requiere Estado de la eps")]
        public bool Estado_eps { get; set; }
    }
}
