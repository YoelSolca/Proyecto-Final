using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDNETBBDD.Models
{
    public class ModelArticulo
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Ingresar la sección es obligatorio")]

        public string? seccion { get; set; }

        [Required(ErrorMessage = "Ingresar el nombre es obligatorio")]

        public string? nombreArticulo { get; set; }

        [Required(ErrorMessage = "Ingresar el precio es obligatorio")]
        public double precio { get; set; }


        public DateTime fecha { get; set; }


        [Required(ErrorMessage = "Ingresar el pais de origen es obligatorio")]
        public string? paisOrigen { get; set; }
    }
}
