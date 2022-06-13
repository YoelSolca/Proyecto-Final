using System.ComponentModel.DataAnnotations;

namespace CRUDNETBBDD.Models
{
    public class ModelPedido
    {
        public int id { get; set; }
        public int cCliente { get; set; }
        public DateTime fechaPedido { get; set; }

        [Required(ErrorMessage = "Ingresar la forma de pago es obligatorio")]
        public string? formadePago { get; set; }

        [Required(ErrorMessage = "Ingresar el articulo es obligatorio")]
        public int cArticulo { get; set; }

        public ModelArticulo? modelArticulo { get; set; }
        public ModelCliente? modelCliente { get; set; }
    }
}
