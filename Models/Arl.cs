using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OyG.Models
{
    public class Arl
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage ="Se requiere nombre ARL")]
        [Display(Name ="Nombre ARL")]
        public string Nombre_arl { get; set; }

        [Required(ErrorMessage ="Se requiere el estado de la arl")]
        public bool Estado_arl { get; set; }
    }
}
