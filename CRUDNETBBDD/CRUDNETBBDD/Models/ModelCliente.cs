using System.ComponentModel.DataAnnotations;

namespace CRUDNETBBDD.Models
{
    public class ModelCliente
    {
        //Estas son la representacion de los campos de la tabla
        public int id { get; set; }

        [Required(ErrorMessage = "Ingresar el nombre es obligatorio")]
        public string? nombre { get; set; }

        [Required(ErrorMessage = "Ingresar la direccion es obligatorio")]
        public string? direccion { get; set; }


        [Required(ErrorMessage = "Ingresar la poblacion es obligatorio")]
        public string? poblacion { get; set; }

        [Required(ErrorMessage = "Ingresar el telefono es obligatorio")]

        public string? telefono { get; set; }

        public List<ModelPedido>? modelPedido { get; set; }
    }
}
