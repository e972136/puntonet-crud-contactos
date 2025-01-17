﻿using Microsoft.AspNetCore.Mvc;

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
            if (!ModelState.IsValid)
            {
                return View();
            }


            var respuesta = _contactoDatos.Guardar(oContacto);

            if (respuesta)
                return RedirectToAction("Listar");
            return View();
        }

        public IActionResult Editar(int idContacto)
        {

            var oContacto = _contactoDatos.obtener(idContacto);

            return View(oContacto);
        }

        [HttpPost]
        public IActionResult Editar(ContactoModel oContacto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }


            var respuesta = _contactoDatos.Editar(oContacto);

            if (respuesta)
                return RedirectToAction("Listar");
            return View();
        }

        public IActionResult Eliminar(int idContacto)
        {

            var oContacto = _contactoDatos.obtener(idContacto);

            return View(oContacto);
        }

        [HttpPost]
        public IActionResult Eliminar(ContactoModel oContacto)
        {
            var respuesta = _contactoDatos.Borrar(oContacto.IdContacto);

            if (respuesta)
                return RedirectToAction("Listar");
            return View();
        }
    }
}
