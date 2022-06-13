using CRUDNETBBDD.Datos;
using CRUDNETBBDD.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace CRUDNETBBDD.Controllers
{
    public class PedidoController : Controller
    {
        ClienteDatos clienteDatos = new ClienteDatos();
        PedidoDatos pedidoDatos = new PedidoDatos();
        ProductoDatos productoDatos = new ProductoDatos();

        public IActionResult Listar()
        {

            var oLista = pedidoDatos.ListarPedidos();

            foreach (var item in oLista)
            {
                var oArticulo = productoDatos.ObtenerArticulo(item.cArticulo);
                item.modelArticulo.nombreArticulo = oArticulo.nombreArticulo;

                var oCliente = clienteDatos.ObtenerCliente(item.cCliente);
                item.modelCliente.nombre = oCliente.nombre;
            }


            return View(oLista);
        }

        public IActionResult GuardarForm()
        {
            var oListaArticulo = productoDatos.ListarArticulo();
            ViewBag.articulos = oListaArticulo;
            return View();
        }

        [HttpPost]
        public IActionResult GuardarForm(ModelPedido oPedido, int id)
        {
            bool IsInserted = false;

            try
            {
                if (ModelState.IsValid)
                {
                    oPedido.fechaPedido = DateTime.Now;
                    oPedido.cCliente = id;
                    oPedido.id = 0;
                    IsInserted = pedidoDatos.CrearPedido(oPedido);

                    if (IsInserted)
                        TempData["SuccesMessage"] = "Pedido agregado correctamente";
                    else
                        TempData["ErrorMessage"] = "No se pudo agregar el pedido";

                }
                return RedirectToAction("Listar", "CRUD");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return View();
            }
        }

        public IActionResult Editar(int id)
        {

            var oPedido = pedidoDatos.ObtenerPedido(id);

            return View(oPedido);
        }

        [HttpPost]
        public IActionResult Editar(ModelPedido oPedido)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = pedidoDatos.EditarPedido(oPedido);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }

        public IActionResult Eliminar(int id)
        {
            var oPedido = pedidoDatos.ObtenerPedido(id);

            return View(oPedido);
        }

        [HttpPost]
        public IActionResult Eliminar(ModelPedido oPedido)
        {
            var respuesta = pedidoDatos.EliminarPedido(oPedido.id);

            if (respuesta)
            {
                TempData["SuccesMessage"] = "Pedido eliminado correctamente";
                return RedirectToAction("Listar");

            }
            else
                TempData["ErrorMessage"] = "No se pudo eliminar el pedido correctamente";
                return View();

        }

    }
}
