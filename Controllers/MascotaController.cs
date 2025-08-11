using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Veterinaria.Models;

namespace Veterinaria.Controllers
{
    public class MascotaController : Controller
    {
        // lista en memoria para demo (no persistente)
        private static readonly List<Mascota> _mascotas = new();

        [HttpGet]
        public IActionResult Registrar()
        {
            return View(new Mascota());
        }

        [HttpPost]
        public IActionResult Registrar(Mascota mascota)
        {
            if (ModelState.IsValid)
            {
                mascota.Id = _mascotas.Count + 1;
                _mascotas.Add(mascota);
                TempData["Mensaje"] = $"Mascota '{mascota.Nombre}' registrada con éxito.";
                return RedirectToAction("Lista");
            }
            return View(mascota);
        }

        public IActionResult Lista()
        {
            return View(_mascotas);
        }
    }
}