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
                new Producto { Id = 1, Nombre = "Collar Antipulgas", Precio = 25.50m },
                new Producto { Id = 2, Nombre = "Comida Premium para Perro (15kg)", Precio = 145.00m },
                new Producto { Id = 3, Nombre = "Juguete Mordedor de Goma", Precio = 18.90m },
                new Producto { Id = 4, Nombre = "Shampoo para Gato", Precio = 22.00m },
                new Producto { Id = 5, Nombre = "Cama Acolchada para Mascota", Precio = 85.00m }
            };
            return View(productos);
        }
    }
}
