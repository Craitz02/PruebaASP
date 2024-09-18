using System;
using System.Collections.Generic;

namespace PruebaASP.Models;

public partial class Producto
{
    public int NoProducto { get; set; }

    public int NoCategoria { get; set; }

    public string NombreProducto { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int? Stock { get; set; }

    public decimal? PrecioVenta { get; set; }

    public bool Estado { get; set; }

    public virtual Categoria NoCategoriaNavigation { get; set; } = null!;
}
