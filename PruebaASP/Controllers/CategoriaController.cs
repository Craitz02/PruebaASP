using Microsoft.AspNetCore.Mvc;
using PruebaASP.Models;

namespace PruebaASP.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly BdempresaContext _bdempresa;

        public CategoriaController(BdempresaContext bdempresa)
        {
            _bdempresa = bdempresa;
        }

        public List<Categoria> GetCategorias()
        {
            return _bdempresa.Categoria.ToList();
        }
    }
}
