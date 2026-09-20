INSERT INTO Categorias (Nombre) VALUES
('Papelería Básica'),
('Arte y Dibujo'),
('Mochilas y Estuches'),
('Tecnología Escolar');

-- Insertamos productos asociados a sus categorías
INSERT INTO Productos (IdCategoria, Nombre, Precio, Stock, Activo) VALUES
(1, 'Cuaderno Profesional 100 Hojas', 45.00, 150, 1),
(2, 'Lápices de Colores 24 Piezas', 89.50, 75, 1),
(3, 'Mochila Escolar Ergonómica', 450.00, 30, 1),
(1, 'Juego de Geometría 4 Piezas', 35.00, 100, 1),
(2, 'Resaltadores Pastel x3', 42.00, 200, 1),
(1, 'Pegamento en Barra 20g', 18.50, 300, 1),
(1, 'Tijeras Punta Roma Escolar', 25.00, 120, 1),
(4, 'Calculadora Científica Básica', 180.00, 45, 1);

INSERT INTO Usuarios (Nombre, Email, PasswordHash, EsAdmin) VALUES
('Admin Sistema', 'admin@utiles.com', 'HASH_SIMULADO_ADMIN_123', 1),
('María González', 'maria.gonzalez@email.com', 'HASH_SIMULADO_CLIENTE_A', 0),
('Carlos Ruiz', 'carlos.ruiz@email.com', 'HASH_SIMULADO_CLIENTE_B', 0),
('Ana López', 'ana.lopez@email.com', 'HASH_SIMULADO_CLIENTE_C', 0);