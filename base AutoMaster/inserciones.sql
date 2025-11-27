USE AUTOMASTER;
GO

-- Estados comunes
INSERT INTO Cls_Estados (Estado, Fecha_Creacion, Activo) VALUES
('Disponible', SYSUTCDATETIME(), 1),
('Vendido', SYSUTCDATETIME(), 1),
('Reservado', SYSUTCDATETIME(), 1),
('En Taller', SYSUTCDATETIME(), 1),
('En Transito', SYSUTCDATETIME(), 1),
('Inactivo', SYSUTCDATETIME(), 0);
GO

-- Tipos de catálogo (grupos)
INSERT INTO Cls_Tipo_Catalogos (Codigo, Tipo_Catalogo, Fecha_Creacion, Activo) VALUES
('GENERO', 'Genero', SYSUTCDATETIME(), 1),
('DOCUMENTO', 'Tipo Documento', SYSUTCDATETIME(), 1),
('CONTACTO', 'Tipo Contacto', SYSUTCDATETIME(), 1),
('CARGO', 'Cargo', SYSUTCDATETIME(), 1),
('AREA', 'Area', SYSUTCDATETIME(), 1),
('USUARIO_TIPO', 'Tipo Usuario', SYSUTCDATETIME(), 1),
('TIPO_SERVICIO', 'Tipo Servicio', SYSUTCDATETIME(), 1),
('ESTADO_DEVOLUCION', 'Estado Devolucion', SYSUTCDATETIME(), 1);
GO

-- Catálogos para GENERO
INSERT INTO Cls_Catalogos (Id_Tipo_Catalogo, Codigo, Catalogo, Fecha_Creacion, Activo) VALUES
((SELECT Id_Tipo_Catalogo FROM Cls_Tipo_Catalogos WHERE Codigo='GENERO'), 'M', 'Masculino', SYSUTCDATETIME(), 1),
((SELECT Id_Tipo_Catalogo FROM Cls_Tipo_Catalogos WHERE Codigo='GENERO'), 'F', 'Femenino', SYSUTCDATETIME(), 1),
((SELECT Id_Tipo_Catalogo FROM Cls_Tipo_Catalogos WHERE Codigo='GENERO'), 'O', 'Otro', SYSUTCDATETIME(), 1);
GO

-- Catálogos para DOCUMENTO
INSERT INTO Cls_Catalogos (Id_Tipo_Catalogo, Codigo, Catalogo, Fecha_Creacion, Activo) VALUES
((SELECT Id_Tipo_Catalogo FROM Cls_Tipo_Catalogos WHERE Codigo='DOCUMENTO'), 'CED', 'Cedula', SYSUTCDATETIME(), 1),
((SELECT Id_Tipo_Catalogo FROM Cls_Tipo_Catalogos WHERE Codigo='DOCUMENTO'), 'RUC', 'RUC', SYSUTCDATETIME(), 1),
((SELECT Id_Tipo_Catalogo FROM Cls_Tipo_Catalogos WHERE Codigo='DOCUMENTO'), 'PAS', 'Pasaporte', SYSUTCDATETIME(), 1);
GO

-- Catálogos para CONTACTO
INSERT INTO Cls_Catalogos (Id_Tipo_Catalogo, Codigo, Catalogo, Fecha_Creacion, Activo) VALUES
((SELECT Id_Tipo_Catalogo FROM Cls_Tipo_Catalogos WHERE Codigo='CONTACTO'), 'TEL', 'Telefono', SYSUTCDATETIME(), 1),
((SELECT Id_Tipo_Catalogo FROM Cls_Tipo_Catalogos WHERE Codigo='CONTACTO'), 'EMAIL', 'Correo Electronico', SYSUTCDATETIME(), 1),
((SELECT Id_Tipo_Catalogo FROM Cls_Tipo_Catalogos WHERE Codigo='CONTACTO'), 'WHATS', 'WhatsApp', SYSUTCDATETIME(), 1);
GO

-- Catálogos para CARGO
INSERT INTO Cls_Catalogos (Id_Tipo_Catalogo, Codigo, Catalogo, Fecha_Creacion, Activo) VALUES
((SELECT Id_Tipo_Catalogo FROM Cls_Tipo_Catalogos WHERE Codigo='CARGO'), 'GER', 'Gerente', SYSUTCDATETIME(), 1),
((SELECT Id_Tipo_Catalogo FROM Cls_Tipo_Catalogos WHERE Codigo='CARGO'), 'VEN', 'Vendedor', SYSUTCDATETIME(), 1),
((SELECT Id_Tipo_Catalogo FROM Cls_Tipo_Catalogos WHERE Codigo='CARGO'), 'MEC', 'Mecanico', SYSUTCDATETIME(), 1),
((SELECT Id_Tipo_Catalogo FROM Cls_Tipo_Catalogos WHERE Codigo='CARGO'), 'ADM', 'Administrativo', SYSUTCDATETIME(), 1);
GO

-- Catálogos para AREA
INSERT INTO Cls_Catalogos (Id_Tipo_Catalogo, Codigo, Catalogo, Fecha_Creacion, Activo) VALUES
((SELECT Id_Tipo_Catalogo FROM Cls_Tipo_Catalogos WHERE Codigo='AREA'), 'VENTAS', 'Ventas', SYSUTCDATETIME(), 1),
((SELECT Id_Tipo_Catalogo FROM Cls_Tipo_Catalogos WHERE Codigo='AREA'), 'TALLER', 'Taller', SYSUTCDATETIME(), 1),
((SELECT Id_Tipo_Catalogo FROM Cls_Tipo_Catalogos WHERE Codigo='AREA'), 'ADMIN', 'Administracion', SYSUTCDATETIME(), 1);
GO

-- Catálogos para USUARIO_TIPO
INSERT INTO Cls_Catalogos (Id_Tipo_Catalogo, Codigo, Catalogo, Fecha_Creacion, Activo) VALUES
((SELECT Id_Tipo_Catalogo FROM Cls_Tipo_Catalogos WHERE Codigo='USUARIO_TIPO'), 'ADMIN', 'Administrador', SYSUTCDATETIME(), 1),
((SELECT Id_Tipo_Catalogo FROM Cls_Tipo_Catalogos WHERE Codigo='USUARIO_TIPO'), 'VEN', 'Usuario Ventas', SYSUTCDATETIME(), 1),
((SELECT Id_Tipo_Catalogo FROM Cls_Tipo_Catalogos WHERE Codigo='USUARIO_TIPO'), 'TAL', 'Usuario Taller', SYSUTCDATETIME(), 1);
GO

-- Catálogos para TIPO_SERVICIO
INSERT INTO Cls_Catalogos (Id_Tipo_Catalogo, Codigo, Catalogo, Fecha_Creacion, Activo) VALUES
((SELECT Id_Tipo_Catalogo FROM Cls_Tipo_Catalogos WHERE Codigo='TIPO_SERVICIO'), 'MANT', 'Mantenimiento', SYSUTCDATETIME(), 1),
((SELECT Id_Tipo_Catalogo FROM Cls_Tipo_Catalogos WHERE Codigo='TIPO_SERVICIO'), 'REPAR', 'Reparacion', SYSUTCDATETIME(), 1),
((SELECT Id_Tipo_Catalogo FROM Cls_Tipo_Catalogos WHERE Codigo='TIPO_SERVICIO'), 'INSPE', 'Inspeccion', SYSUTCDATETIME(), 1);
GO

-- Catálogos para ESTADO_DEVOLUCION
INSERT INTO Cls_Catalogos (Id_Tipo_Catalogo, Codigo, Catalogo, Fecha_Creacion, Activo) VALUES
((SELECT Id_Tipo_Catalogo FROM Cls_Tipo_Catalogos WHERE Codigo='ESTADO_DEVOLUCION'), 'PEN', 'Pendiente', SYSUTCDATETIME(), 1),
((SELECT Id_Tipo_Catalogo FROM Cls_Tipo_Catalogos WHERE Codigo='ESTADO_DEVOLUCION'), 'APR', 'Aprobada', SYSUTCDATETIME(), 1),
((SELECT Id_Tipo_Catalogo FROM Cls_Tipo_Catalogos WHERE Codigo='ESTADO_DEVOLUCION'), 'REJ', 'Rechazada', SYSUTCDATETIME(), 1);
GO

select * from Cls_Estados
select * from Cls_Tipo_Catalogos
select * from Cls_Catalogos



-- 4 personas
SET IDENTITY_INSERT Tbl_Datos_Personales ON;

INSERT INTO Tbl_Datos_Personales
    (Id_Persona, Primer_Nombre, Segundo_Nombre, Primer_Apellido, Segundo_Apellido,
     Id_Genero, Id_Tipo_DNI, DNI, Fecha_Creacion, Fecha_Modificacion, Id_Estado)
VALUES
    (1001, 'Maycol', 'Salatiel', 'Gutierrez', 'Solano',
     1, 7, '0801-0000-0001', SYSUTCDATETIME(), NULL, 1),
    (1002, 'Rebecha', 'de los Ángeles', 'Artola', 'Corea',
     2, 7, '0801-0000-0002', SYSUTCDATETIME(), NULL, 1),
    (1003, 'Luis', 'Rodolfo', 'Blandon', NULL,
     1, 7, '0801-0000-0003', SYSUTCDATETIME(), NULL, 1),
    (1004, 'Geral', NULL, 'Espinoza', NULL,
     1, 7, '0801-0000-0004', SYSUTCDATETIME(), NULL, 1);

SET IDENTITY_INSERT Tbl_Datos_Personales OFF;
GO

-- Insertar contactos asociados a cada persona con Id_Contacto explícitos
SET IDENTITY_INSERT Tbl_Contactos ON;

INSERT INTO Tbl_Contactos
    (Id_Contacto, Id_Persona, Id_Tipo_Contacto, Contacto, Principal, Fecha_Creacion, Fecha_Modificacion, Id_Estado)
VALUES
    -- Maycol Gutierrez (1001)
    (2001, 1001, 10, '+50587440001', 1, SYSUTCDATETIME(), NULL, 1),
    (2002, 1001, 11, 'maycol.gutierrez@example.com', 0, SYSUTCDATETIME(), NULL, 1),

    -- Rebecha Artola (1002)
    (2003, 1002, 10, '+50587440002', 1, SYSUTCDATETIME(), NULL, 1),
    (2004, 1002, 11, 'rebecha.artola@example.com', 0, SYSUTCDATETIME(), NULL, 1),

    -- Luis Blandon (1003)
    (2005, 1003, 10, '+50587440003', 1, SYSUTCDATETIME(), NULL, 1),
    (2006, 1003, 11, 'luis.blandon@example.com', 0, SYSUTCDATETIME(), NULL, 1),

    -- Geral Espinoza (1004)
    (2007, 1004, 10, '+50587440004', 1, SYSUTCDATETIME(), NULL, 1),
    (2008, 1004, 11, 'geral.espinoza@example.com', 0, SYSUTCDATETIME(), NULL, 1);

SET IDENTITY_INSERT Tbl_Contactos OFF;
GO

-- Verificar inserciones (consultas rápidas)
SELECT Id_Persona, Primer_Nombre, Segundo_Nombre, Primer_Apellido, Segundo_Apellido, DNI, Id_Genero, Id_Tipo_DNI, Id_Estado
FROM Tbl_Datos_Personales
WHERE Id_Persona IN (1001,1002,1003,1004);

SELECT Id_Contacto, Id_Persona, Id_Tipo_Contacto, Contacto, Principal
FROM Tbl_Contactos
WHERE Id_Contacto BETWEEN 2001 AND 2008;
GO

-- Ajustar semilla de identidad si desea seguir insertando con identidad normal
DBCC CHECKIDENT ('Tbl_Datos_Personales', RESEED, 1004);
DBCC CHECKIDENT ('Tbl_Contactos', RESEED, 2008);
GO


USE AUTOMASTER;
GO

-- ============================
-- PROVEEDORES
-- ============================
INSERT INTO Tbl_Proveedores (Representante, Nombre_Empresa, RUC_Empresa, Fecha_Registro, Id_Estado)
VALUES 
(1001, 'AutoImport S.A.', 'J03100001', SYSUTCDATETIME(), 1),
(1002, 'Motores del Sur', 'J03100002', SYSUTCDATETIME(), 1);

-- ============================
-- EMPLEADOS
-- ============================
INSERT INTO Empleados (Id_Persona, Id_Cargo, Id_Area, Fecha_Registro, Activo)
VALUES
(1002, 10, 16, SYSUTCDATETIME(), 1),
(1003, 14, 18, SYSUTCDATETIME(), 1)

SELECT * FROM Empleados
SELECT * FROM Cls_Catalogos
-- ============================
-- CLIENTES
-- ============================
INSERT INTO Clientes (Id_Persona, Fecha_Registro, Activo)
VALUES
(1004, SYSUTCDATETIME(), 1),
(1001, SYSUTCDATETIME(), 1);

SELECT * FROM Clientes
SELECT * FROM Tbl_Datos_Personales
-- ============================
-- VEHICULOS
-- ============================
INSERT INTO Vehiculos (Id_Proveedor, Marca, Modelo, Anio, Serie_Chasis, Serie_Motor, Precio, Id_Estado, Fecha_Registro)
VALUES
(1, 'Toyota', 'Hilux', 2022, 'CHS123456789', 'MTR987654321', 35000, 1, SYSUTCDATETIME()),
(1, 'Nissan', 'Frontier', 2023, 'CHS987654321', 'MTR123456789', 32000, 1, SYSUTCDATETIME()),
(2, 'Honda', 'Civic', 2021, 'CHS555555555', 'MTR555555555', 28000, 1, SYSUTCDATETIME());
SELECT * FROM Vehiculos
-- ============================
-- VENTAS
-- ============================
INSERT INTO Ventas (Id_Vehiculo, Id_Cliente, Id_Empleado, Fecha_Venta, Precio_Venta, Forma_Pago, Fecha_Registro)
VALUES
(1, 1, 2, GETDATE(), 35000, 'CONTADO', SYSUTCDATETIME()),
(2, 2, 2, GETDATE(), 32000, 'FINANCIAMIENTO', SYSUTCDATETIME());
SELECT * FROM Ventas
SELECT * FROM Empleados

-- ============================
-- FINANCIAMIENTO
-- ============================
INSERT INTO Financiamiento (Id_Venta, Id_Cliente, Monto, Plazo_Meses, Tasa_Interes, Fecha_Inicio, Fecha_Registro)
VALUES
(2, 2, 32000, 24, 0.085, GETDATE(), SYSUTCDATETIME());

-- ============================
-- PAGOS
-- ============================
INSERT INTO Pagos (Id_Venta, Id_Financiamiento, Fecha_Pago, Monto, Metodo_Pago, Observaciones, Fecha_Registro)
VALUES
(1, NULL, GETDATE(), 35000, 'CONTADO', 'Pago contado de Hilux', SYSUTCDATETIME()),
(NULL, 1, GETDATE(), 5000, 'TRANSFERENCIA', 'Primer pago de financiamiento Frontier', SYSUTCDATETIME()),
(NULL, 1, DATEADD(MONTH,1,GETDATE()), 5000, 'TARJETA', 'Segundo pago de financiamiento Frontier', SYSUTCDATETIME());

-- ============================
-- FACTURAS
-- ============================
INSERT INTO Facturas (Id_Venta, Id_Pago, Id_Financiamiento, Numero_Factura, Subtotal, IVA, Total)
VALUES
(1, 1, NULL, 'FAC-0001', 30000, 5000, 35000),
(2, 2, 1, 'FAC-0002', 28000, 4000, 32000);

-- ============================
-- DEVOLUCIONES
-- ============================

-- ============================
-- SERVICIOS VEHICULOS
-- ============================
INSERT INTO Servicios_Vehiculos (Id_Vehiculo, Id_Tipo_Servicio, Fecha_Servicio, Costo, Realizado_por, Observaciones, Fecha_Registro)
VALUES
(1, (SELECT Id_Catalogo FROM Cls_Catalogos WHERE Codigo='MANT'), GETDATE(), 150, 2, 'Cambio de aceite', SYSUTCDATETIME()),
(2, (SELECT Id_Catalogo FROM Cls_Catalogos WHERE Codigo='REPAR'), GETDATE(), 500, 2, 'Reparación de frenos', SYSUTCDATETIME());

-- ============================
-- TALLER
-- ============================
INSERT INTO Taller (Id_Vehiculo, Descripcion_Trabajo, Fecha_Ingreso, Fecha_Salida, Costo, Responsable, Fecha_Registro)
VALUES
(3, 'Revisión general', GETDATE(), DATEADD(DAY,3,GETDATE()), 200, 2, SYSUTCDATETIME());

-- ============================
-- ROLES
-- ============================
INSERT INTO Roles (Nombre_Rol)
VALUES ('Administrador'), ('Ventas'), ('Taller');

