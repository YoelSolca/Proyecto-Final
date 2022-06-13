using Microsoft.AspNetCore.Mvc;
using CRUDNETBBDD.Datos;
using CRUDNETBBDD.Models;

namespace CRUDNETBBDD.Controllers
{
    public class CRUDController : Controller
    {

        ClienteDatos clienteDatos = new ClienteDatos();
        PedidoDatos pedidoDatos = new PedidoDatos();
        ProductoDatos productoDatos = new ProductoDatos();

        public IActionResult Listar()
        {
            var oLista = clienteDatos.ListarClientes();

        

            return View(oLista);
        }


        public IActionResult GuardarForm()
        {
            return View();
        }


        [HttpPost]
        public IActionResult GuardarForm(ModelCliente oCliente)
        {
            bool IsInserted = false;

            try
            {
                if (ModelState.IsValid)
                {

                    IsInserted = clienteDatos.CrearCliente(oCliente);

                    if (IsInserted)
                        TempData["SuccesMessage"] = "Cliente creado correctamente";
                    else
                        TempData["ErrorMessage"] = "No se pudo crear el cliente";

                    return RedirectToAction("Listar");

                }
                else
                    return View();
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return View();
            }
        }


        public IActionResult Editar(int id)
        {
            //Solo devuelve la vista
            var oCliente = clienteDatos.ObtenerCliente(id);

            var oPedidoLista = pedidoDatos.ListarPedidosCliente(id);

            var oArticuloLista = productoDatos.ListarArticulosCliente(id);

            oCliente.modelPedido = oPedidoLista;

            var count = oArticuloLista.Count() - oArticuloLista.Count();

            foreach (var item in oCliente.modelPedido)
            {
                item.modelArticulo = oArticuloLista[count];
                count++;
            }

            return View(oCliente);
        }

        [HttpPost]
        public IActionResult Editar(ModelCliente oCliente)
        {
            bool IsInserted = false;


            if (ModelState.IsValid)
            {
                IsInserted = clienteDatos.EditarCliente(oCliente);


                if (IsInserted)
                {
                    TempData["SuccesMessage"] = "Cliente editado correctamente";
                }
                 else
                    {
                    TempData["ErrorMessage"] = "No se pudo editado el cliente correctamente";
                    }

            return RedirectToAction("Listar");
            }
            else
            {
                return View();
            }
        }


        public IActionResult Eliminar(int id)
        {
            var oCliente = clienteDatos.ObtenerCliente(id);

            return View(oCliente);
        }


        [HttpPost]
        public IActionResult Eliminar(ModelCliente oCliente)
        {

            var rp = pedidoDatos.EliminarClientePedido(oCliente.id);

            var respusta = clienteDatos.EliminarCliente(oCliente.id);

            if (respusta)
            {
                 TempData["SuccesMessage"] = "Cliente eliminado correctamente";
                return RedirectToAction("Listar");
            }
            else
                TempData["ErrorMessage"] = "No se pudo eliminar el cliente correctamente";
                 return View();
        }
    }
}
