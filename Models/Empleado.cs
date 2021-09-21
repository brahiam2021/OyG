using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OyG.Models
{
    public class Empleado
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(20)]
        [Required(ErrorMessage ="Se requiere el campo Nombre de empleado ")]
        [Display(Name ="Nombre")]
        public string NombreEmpleado { get; set; }

        [MaxLength(40)]
        [Required(ErrorMessage = "Se requiere el campo Apellido de empleado ")]
        [Display(Name = "Apellido")]
        public  string ApellidoEmpleado { get; set; }

  
        [Required(ErrorMessage = "Se requiere el campo Edad empleado ")]
        public int  EdadEmpleado { get; set; }

        [MaxLength(20)]
        [Required(ErrorMessage = "Se requiere el campo E-mail de empleado ")]
        [Display(Name = "Correo electronico")]
        [EmailAddress]
        public string CorreoEmpleado { get; set; }

        [Required(ErrorMessage ="Se requiere el campo Telefono")]
        [Display(Name ="Telefono")]
        [Phone]
        public int Telefono { get; set; }

        [MaxLength(40)]
        [Required(ErrorMessage = "Se requiere el campo Direccion de empleado ")]
        [Display(Name = "Direccion")]
        public string Direccion { get; set; }

      [ForeignKey("ArlId")]
      public Arl Arl { get; set; }

      [ForeignKey("EpsIs")]
      public Eps Eps { get; set; }

         
      [Required(ErrorMessage = "Se requiere el campo Sueldo de empleado ")]
      [Display(Name ="Sueldo")]
      public double Sueldo { get; set; }


      [ForeignKey("Usuariosusuario")]
      public Usuarios Usuarios { get; set; }
        
    }
}
