using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OyG.Models
{
    public class Materiales
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(25)]
        [Required(ErrorMessage ="Campo requerido")]
        [Display(Name ="Nombre del material")]
        public string Nombre_material { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "Cantidad de material")]
        public int Cantidad_material { get; set; }
        [Display(Name = "Estado del material")]
        [Required(ErrorMessage = "Campo requerido")]
        public bool Estado_material { get; set; }


        
    }
}
