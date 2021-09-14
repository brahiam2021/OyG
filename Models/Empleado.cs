using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OyG.Models
{
    public class Empleado
    {
        [Key]
        public int Idempleado { get; set; }

        [MaxLength(20)]
        [Required(ErrorMessage ="Se requiere el campo Nombre de empleado ")]
        [Display(Name ="Nombre")]
        public string NombreEmpleado { get; set; }

        [MaxLength(40)]
        [Required(ErrorMessage = "Se requiere el campo Apellido de empleado ")]
        [Display(Name = "Apellido")]
        public  string ApellidoEmpleado { get; set; }

  
        [Required(ErrorMessage = "Se requiere el campo Nombre de empleado ")]
        public int  EdadEmpleado { get; set; }

        [MaxLength(20)]
        [Required(ErrorMessage = "Se requiere el campo E-mail de empleado ")]
        [Display(Name = "E-mail")]
        public string CorreoEmpleado { get; set; }

        [Required(ErrorMessage ="Se requiere el campo Telefono")]
        [Display(Name ="Telefono")]
        [Phone]
        public int Telefono { get; set; }

        [MaxLength(40)]
        [Required(ErrorMessage = "Se requiere el campo Direccion de empleado ")]
        [Display(Name = "Direccion")]
        public string Direccion { get; set; }

        [MaxLength(20)]
        [Required(ErrorMessage = "Se requiere el campo Eps del empleado ")]
        [Display(Name = "Eps")]
        public string Eps { get; set; }

        [MaxLength(20)]
        [Required(ErrorMessage = "Se requiere el campo Arl de empleado ")]
        [Display(Name = "Arl")]
        public string Arl { get; set; }

        
        [Required(ErrorMessage = "Se requiere el campo Sueldo de empleado ")]
        [Display(Name ="Sueldo")]
        public double Sueldo { get; set; }


        [Required(ErrorMessage = "Se requiere el campo Estado de empleado ")]
        [Display(Name = "Estado")]
        public bool EstadoEmpleado { get; set; }
        
    }
}
