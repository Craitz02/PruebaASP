USE [BDEmpresa]
GO

INSERT INTO [dbo].[Categoria] 
           ([nombreCategoria], [descripcion]) 
     VALUES
           ('Alimentos', 'Comestibles perecederos'),
           ('Electr�nica', 'Dispositivos tecnol�gicos'),
           ('Juguetes', 'Art�culos para ni�os'),
           ('Ropa', 'Prendas de vestir'),
           ('Hogar', 'Accesorios para el hogar');
GO
-- Productos para la categor�a "Alimentos"
INSERT INTO [dbo].[Producto] 
           ([NoCategoria], [nombreProducto], [descripcion], [stock], [precioVenta]) 
     VALUES
           (1, 'Manzanas', 'Frutas frescas', 100, 1.50),
           (1, 'Pan integral', 'Panader�a artesanal', 50, 2.75),
           (1, 'Leche', 'L�cteos frescos', 200, 1.20);
GO
-- Productos para la categor�a "Electr�nica"
INSERT INTO [dbo].[Producto] 
           ([NoCategoria], [nombreProducto], [descripcion], [stock], [precioVenta]) 
     VALUES
           (2, 'Tel�fono m�vil', 'Smartphone 5G', 30, 299.99),
           (2, 'Port�til', 'Laptop de alta gama', 15, 999.99),
           (2, 'Auriculares', 'Auriculares Bluetooth', 100, 49.99);
GO
-- Productos para la categor�a "Juguetes"
INSERT INTO [dbo].[Producto] 
           ([NoCategoria], [nombreProducto], [descripcion], [stock], [precioVenta]) 
     VALUES
           (3, 'Mu�eca', 'Mu�eca de tela', 40, 19.99),
           (3, 'Auto de juguete', 'Coche de control remoto', 25, 29.99),
           (3, 'Bloques de construcci�n', 'Set de 100 piezas', 60, 24.99);
GO
-- Productos para la categor�a "Ropa"
INSERT INTO [dbo].[Producto] 
           ([NoCategoria], [nombreProducto], [descripcion], [stock], [precioVenta]) 
     VALUES
           (4, 'Camiseta', 'Camiseta de algod�n', 80, 14.99),
           (4, 'Pantalones', 'Jeans para hombre', 60, 39.99),
           (4, 'Chaqueta', 'Chaqueta impermeable', 30, 69.99);
GO
-- Productos para la categor�a "Hogar"
INSERT INTO [dbo].[Producto] 
           ([NoCategoria], [nombreProducto], [descripcion], [stock], [precioVenta]) 
     VALUES
           (5, 'Silla de oficina', 'Silla ergon�mica', 20, 129.99),
           (5, 'Mesa de comedor', 'Mesa para 6 personas', 10, 299.99),
           (5, 'L�mpara de mesa', 'L�mpara de LED', 50, 19.99);
GO

SELECT * FROM Categoria
GO
SELECT * FROM Producto
