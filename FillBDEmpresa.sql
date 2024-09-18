USE [BDEmpresa]
GO

INSERT INTO [dbo].[Categoria] 
           ([nombreCategoria], [descripcion]) 
     VALUES
           ('Alimentos', 'Comestibles perecederos'),
           ('Electrónica', 'Dispositivos tecnológicos'),
           ('Juguetes', 'Artículos para niños'),
           ('Ropa', 'Prendas de vestir'),
           ('Hogar', 'Accesorios para el hogar');
GO
-- Productos para la categoría "Alimentos"
INSERT INTO [dbo].[Producto] 
           ([NoCategoria], [nombreProducto], [descripcion], [stock], [precioVenta]) 
     VALUES
           (1, 'Manzanas', 'Frutas frescas', 100, 1.50),
           (1, 'Pan integral', 'Panadería artesanal', 50, 2.75),
           (1, 'Leche', 'Lácteos frescos', 200, 1.20);
GO
-- Productos para la categoría "Electrónica"
INSERT INTO [dbo].[Producto] 
           ([NoCategoria], [nombreProducto], [descripcion], [stock], [precioVenta]) 
     VALUES
           (2, 'Teléfono móvil', 'Smartphone 5G', 30, 299.99),
           (2, 'Portátil', 'Laptop de alta gama', 15, 999.99),
           (2, 'Auriculares', 'Auriculares Bluetooth', 100, 49.99);
GO
-- Productos para la categoría "Juguetes"
INSERT INTO [dbo].[Producto] 
           ([NoCategoria], [nombreProducto], [descripcion], [stock], [precioVenta]) 
     VALUES
           (3, 'Muñeca', 'Muñeca de tela', 40, 19.99),
           (3, 'Auto de juguete', 'Coche de control remoto', 25, 29.99),
           (3, 'Bloques de construcción', 'Set de 100 piezas', 60, 24.99);
GO
-- Productos para la categoría "Ropa"
INSERT INTO [dbo].[Producto] 
           ([NoCategoria], [nombreProducto], [descripcion], [stock], [precioVenta]) 
     VALUES
           (4, 'Camiseta', 'Camiseta de algodón', 80, 14.99),
           (4, 'Pantalones', 'Jeans para hombre', 60, 39.99),
           (4, 'Chaqueta', 'Chaqueta impermeable', 30, 69.99);
GO
-- Productos para la categoría "Hogar"
INSERT INTO [dbo].[Producto] 
           ([NoCategoria], [nombreProducto], [descripcion], [stock], [precioVenta]) 
     VALUES
           (5, 'Silla de oficina', 'Silla ergonómica', 20, 129.99),
           (5, 'Mesa de comedor', 'Mesa para 6 personas', 10, 299.99),
           (5, 'Lámpara de mesa', 'Lámpara de LED', 50, 19.99);
GO

SELECT * FROM Categoria
GO
SELECT * FROM Producto
