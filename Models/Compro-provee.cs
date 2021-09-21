using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OyG.Models
{
    public class Compro_provee
    {
        [Key]
        public int Id { get; set; }


        [ForeignKey("ComprobanteId")]
        public Comprobante Comprobante { get; set; }

        [ForeignKey("EmpleadoId")]
        public Empleado Empleado { get; set; }

    }
}
