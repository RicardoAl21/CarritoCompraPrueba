-- Creación de tablas mínimas para E-commerce
-- Usuarios: Almacena tanto administradores como clientes
CREATE TABLE Usuarios (
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Email VARCHAR(150) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL, -- Nunca almacenar contraseñas en texto plano
    EsAdmin BIT NOT NULL DEFAULT 0,    -- 0 = Cliente, 1 = Administrador
    FechaRegistro DATETIME NOT NULL DEFAULT GETDATE()
);

-- Productos: Catálogo de útiles escolares
CREATE TABLE Categorias (
    IdCategoria INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL UNIQUE
);

-- Tabla de Productos actualizada con atributos para filtrado
CREATE TABLE Productos (
    IdProducto INT IDENTITY(1,1) PRIMARY KEY,
    IdCategoria INT NOT NULL,
    Nombre VARCHAR(150) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL CHECK (Precio >= 0),
    Stock INT NOT NULL DEFAULT 0 CHECK (Stock >= 0),
    Activo BIT NOT NULL DEFAULT 1, -- Para ocultar productos sin eliminarlos
    CONSTRAINT FK_Producto_Categoria FOREIGN KEY (IdCategoria) REFERENCES Categorias(IdCategoria)
);

-- Carrito: Relación temporal entre usuario y productos antes de comprar
CREATE TABLE Carrito (
    IdCarrito INT IDENTITY(1,1) PRIMARY KEY,
    IdUsuario INT NOT NULL,
    IdProducto INT NOT NULL,
    Cantidad INT NOT NULL CHECK (Cantidad > 0),
    CONSTRAINT FK_Carrito_Usuario FOREIGN KEY (IdUsuario) REFERENCES Usuarios(IdUsuario),
    CONSTRAINT FK_Carrito_Producto FOREIGN KEY (IdProducto) REFERENCES Productos(IdProducto)
);

-- Ordenes: Registro formal de una compra
CREATE TABLE Ordenes (
    IdOrden INT IDENTITY(1,1) PRIMARY KEY,
    IdUsuario INT NOT NULL,
    FechaOrden DATETIME NOT NULL DEFAULT GETDATE(),
    Total DECIMAL(10,2) NOT NULL CHECK (Total >= 0),
    CONSTRAINT FK_Ordenes_Usuario FOREIGN KEY (IdUsuario) REFERENCES Usuarios(IdUsuario)
);

-- DetalleCompra: Líneas específicas de cada orden
CREATE TABLE DetalleCompra (
    IdDetalle INT IDENTITY(1,1) PRIMARY KEY,
    IdOrden INT NOT NULL,
    IdProducto INT NOT NULL,
    Cantidad INT NOT NULL CHECK (Cantidad > 0),
    PrecioUnitario DECIMAL(10,2) NOT NULL, -- Se congela el precio al momento de la compra
    CONSTRAINT FK_Detalle_Orden FOREIGN KEY (IdOrden) REFERENCES Ordenes(IdOrden),
    CONSTRAINT FK_Detalle_Producto FOREIGN KEY (IdProducto) REFERENCES Productos(IdProducto)
);  