using CRUDNETBBDD.Datos;
using CRUDNETBBDD.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDNETBBDD.Controllers
{
    public class ProductoController : Controller
    {

        ProductoDatos productoDatos = new ProductoDatos();
        public IActionResult Listar()
        {
            var oLista = productoDatos.ListarArticulo();

            return View(oLista);
        }
        
        public IActionResult GuardarForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GuardarForm(ModelArticulo oArticulo)
        {
            bool IsInserted = false;

            try
            {
                if (ModelState.IsValid)
                {
                    oArticulo.fecha = DateTime.Now;
                    IsInserted = productoDatos.CrearArticulo(oArticulo);

                    if (IsInserted)
                        TempData["SuccesMessage"] = "Producto creado correctamente";
                    else
                        TempData["ErrorMessage"] = "No se pudo crear el producto";

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
            var oProducto = productoDatos.ObtenerArticulo(id);

            return View(oProducto);
        }

        [HttpPost]

        public IActionResult Editar(ModelArticulo oArticulo)
        {
            oArticulo.fecha = DateTime.Now;
            bool IsInserted = false;

            if (ModelState.IsValid)
            {
                IsInserted = productoDatos.EditarArticulo(oArticulo);

                if (IsInserted)
                {
                    TempData["SuccesMessage"] = "Producto editado correctamente";
                }
                else
                {
                    TempData["ErrorMessage"] = "No se pudo editar el producto correctamente";
                }
                return RedirectToAction("Listar");
            }else
                return View();
        }

        public IActionResult Eliminar(int id)
        {
            var oArticulo = productoDatos.ObtenerArticulo(id);

            return View(oArticulo);
        }

        [HttpPost]
        public IActionResult Eliminar(ModelArticulo oArticulo)
        {
            var respuesta = productoDatos.EliminarArticulo(oArticulo.id);

            if (respuesta)
            {
                TempData["SuccesMessage"] = "Producto eliminado correctamente";

                return RedirectToAction("Listar");
            }
            else
                TempData["ErrorMessage"] = "No se pudo eliminar el producto correctamente";
            return RedirectToAction("Listar");
        }



    }
}
