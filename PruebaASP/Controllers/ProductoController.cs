using Microsoft.AspNetCore.Mvc;
using PruebaASP.Models;
using System.Linq;

namespace PruebaASP.Controllers
{
    public class ProductoController : Controller
    {
        private readonly BdempresaContext _bdempresa;

        public ProductoController(BdempresaContext bdempresa)
        {
            _bdempresa = bdempresa;
        }
              

        public List<Producto> GetProductos()
        {
            return _bdempresa.Productos.Where(x => x.Estado == true).ToList();
        }

        [HttpGet]
        public IActionResult GetProductById(int id)
        {
            var product = _bdempresa.Productos.FirstOrDefault(p => p.NoProducto == id);

            if (product == null)
            {
                return NotFound();
            }

            return Json(product); // Devuelve los datos del producto como JSON
        }

    }




}
