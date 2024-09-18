using System.ComponentModel.DataAnnotations;

namespace PruebaASP.Models
{
    public class ViewModel
    {
        public List<Producto> Productos { get; set; }
        public List<Categoria> Categorias { get; set; }

        public int? SelectedProductId { get; set; }

        public int NoProducto { get; set; }
        [Required(ErrorMessage = "La categoría del producto es obligatoria.")]
        public int Categoria { get; set; }
        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        public string NombreProducto { get; set; }
        [Required(ErrorMessage = "La descripción es obligatoria.")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "El stock es obligatorio.")]
        public int Stock { get; set; }
        [Required(ErrorMessage = "El precio de venta es obligatorio.")]
        public decimal PrecioVenta { get; set; }
    }
}
