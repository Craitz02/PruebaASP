using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PruebaASP.Models;

public partial class BdempresaContext : DbContext
{
    public BdempresaContext()
    {
    }

    public BdempresaContext(DbContextOptions<BdempresaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categoria> Categoria { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=RODRIGO\\DESARROLLO;Initial Catalog=BDEmpresa;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.NoCategoria);

            entity.Property(e => e.Descripcion)
                .HasMaxLength(40)
                .HasColumnName("descripcion");
            entity.Property(e => e.NombreCategoria)
                .HasMaxLength(40)
                .HasColumnName("nombreCategoria");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.NoProducto);

            entity.ToTable("Producto");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(40)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasDefaultValue(true)
                .HasColumnName("estado");
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(40)
                .HasColumnName("nombreProducto");
            entity.Property(e => e.PrecioVenta)
                .HasColumnType("money")
                .HasColumnName("precioVenta");
            entity.Property(e => e.Stock).HasColumnName("stock");

            entity.HasOne(d => d.NoCategoriaNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.NoCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Producto_Categoria");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
