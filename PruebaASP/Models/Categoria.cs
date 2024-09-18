using System;
using System.Collections.Generic;

namespace PruebaASP.Models;

public partial class Categoria
{
    public int NoCategoria { get; set; }

    public string NombreCategoria { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
