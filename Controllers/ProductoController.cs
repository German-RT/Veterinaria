using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Veterinaria.Models;

namespace Veterinaria.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Lista()
        {
            var productos = new List<Producto>
            {
                new Producto { Id = 1, Nombre = "Collar", Precio = 15.50m },
                new Producto { Id = 2, Nombre = "Comida para Perro", Precio = 45.00m }
            };
            return View(productos);
        }
    }
}