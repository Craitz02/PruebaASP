using Microsoft.AspNetCore.Mvc;
using PruebaASP.Models;
using System.Diagnostics;

namespace PruebaASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProductoController _producto;
        private readonly CategoriaController _categoria;
        private readonly BdempresaContext _bdempresa;

        public HomeController(ILogger<HomeController> logger, ProductoController producto, CategoriaController categoria, BdempresaContext context)
        {
            _logger = logger;
            _producto = producto;
            _categoria = categoria;
            _bdempresa = context;
        }

        public IActionResult Index()
        {
            var model = new ViewModel
            {
                Productos = _producto.GetProductos(),
                Categorias = _categoria.GetCategorias()
            };

            // Generar un nuevo número de producto
            var lastProduct = _producto.GetProductos().OrderByDescending(p => p.NoProducto).FirstOrDefault();
            var newProductNumber = lastProduct != null
                ? (lastProduct.NoProducto + 1) : 1;

            model.NoProducto = newProductNumber;

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult SaveProduct(ViewModel model, string actionType)
        {
            var selectedProductIds = Request.Form["SelectedProductIds"].ToString().Split(',');

            if (actionType == "Guardar")
            {
                if (model.NoProducto > 0)  // Producto existente
                {
                    var produ = _bdempresa.Productos.FirstOrDefault(p => p.NoProducto == model.NoProducto);
                    if (produ != null)
                    {
                        // Actualizar producto existente
                        produ.NoCategoria = model.Categoria;
                        produ.NombreProducto = model.NombreProducto;
                        produ.Descripcion = model.Descripcion;
                        produ.Stock = model.Stock;
                        produ.PrecioVenta = model.PrecioVenta;
                    }
                }
                else  // Crear nuevo producto
                {
                    var producto = new Producto
                    {
                        NoCategoria = model.Categoria,
                        NombreProducto = model.NombreProducto,
                        Descripcion = model.Descripcion,
                        Stock = model.Stock,
                        PrecioVenta = model.PrecioVenta
                    };
                    _bdempresa.Productos.Add(producto);
                }

                _bdempresa.SaveChanges();
            }
            else if (actionType == "Deshabilitar")
            {
                foreach (var id in selectedProductIds)
                {
                    if (int.TryParse(id, out int productId))
                    {
                        var producto = _bdempresa.Productos.FirstOrDefault(p => p.NoProducto == productId);
                        if (producto != null)
                        {
                            producto.Estado = false;  // Deshabilitar
                        }
                    }
                }
                _bdempresa.SaveChanges();
            }

            return RedirectToAction("Index");
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
