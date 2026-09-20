-- Índices para mejorar la velocidad de los filtros
CREATE INDEX IX_Productos_Precio ON Productos(Precio);
CREATE INDEX IX_Productos_Stock ON Productos(Stock);
CREATE INDEX IX_Productos_Categoria ON Productos(IdCategoria);

-- Índice para mejorar búsquedas parciales o por orden alfabético
CREATE INDEX IX_Productos_Nombre ON Productos(Nombre);

-- Para cargar rápido el carrito de un usuario específico
CREATE INDEX IX_Carrito_Usuario ON Carrito(IdUsuario);

-- Para ver el historial de órdenes de un cliente
CREATE INDEX IX_Ordenes_Usuario ON Ordenes(IdUsuario);

-- Para listar los productos de una orden específica (Detalle de compra)
CREATE INDEX IX_DetalleCompra_Orden ON DetalleCompra(IdOrden);

-- Optimiza listados donde se muestra Nombre, Precio y Categoría juntos
CREATE INDEX IX_Productos_Listado ON Productos(IdCategoria, Precio, Nombre);