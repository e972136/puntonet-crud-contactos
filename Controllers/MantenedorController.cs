using Microsoft.AspNetCore.Mvc;

using puntoNet.Datos;
using puntoNet.Models;

namespace puntoNet.Controllers
{
    public class MantenedorController : Controller
    {

        ContactoDatos _contactoDatos = new ContactoDatos();

        public IActionResult Listar()
        {
            var oLista = _contactoDatos.listar();
            return View(oLista);
        }

        public IActionResult Guardar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(ContactoModel oContacto)
        {

            var respuesta = _contactoDatos.Guardar(oContacto);

            if (respuesta)
                return RedirectToAction("Listar");
            return View();
        }
    }
}
