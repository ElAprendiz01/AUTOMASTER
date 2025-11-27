USE AUTOMASTER;
GO

IF OBJECT_ID('vw_Inventario_Completo','V') IS NOT NULL DROP VIEW vw_Inventario_Completo;
GO
CREATE VIEW vw_Inventario_Completo AS
SELECT
  v.Id_Vehiculo,
  v.Marca,
  v.Modelo,
  v.Anio,
  v.Serie_Chasis,
  v.Serie_Motor,
  v.Precio,
  p.Id_Proveedor,
  p.Nombre_Empresa AS Proveedor,
  pc.Id_Contacto AS Proveedor_Contacto_Id,
  pc.Valor_Contacto AS Proveedor_Contacto,
  e.Estado AS Estado_Vehiculo,
  v.Fecha_Ingreso_Pais,
  v.Fecha_Registro
FROM Vehiculos v
LEFT JOIN Tbl_Proveedores p ON v.Id_Proveedor = p.Id_Proveedor
LEFT JOIN Proveedor_Contactos rpc ON p.Id_Proveedor = rpc.Id_Proveedor AND rpc.Principal = 1
LEFT JOIN Tbl_Contactos pc ON rpc.Id_Contacto = pc.Id_Contacto
LEFT JOIN Cls_Estados e ON v.Id_Estado = e.Id_Estado;
GO

IF OBJECT_ID('vw_Ventas_Detalle','V') IS NOT NULL DROP VIEW vw_Ventas_Detalle;
GO
CREATE VIEW vw_Ventas_Detalle AS
SELECT
  ven.Id_Venta,
  ven.Fecha_Venta,
  ven.Precio_Venta,
  ven.Forma_Pago,
  ven.Observaciones,
  v.Id_Vehiculo,
  v.Marca,
  v.Modelo,
  v.Anio,
  c.Id_Cliente,
  tp.Primer_Nombre + ' ' + ISNULL(tp.Segundo_Nombre,'') + ' ' + tp.Primer_Apellido + ' ' + ISNULL(tp.Segundo_Apellido,'') AS Cliente_Nombre,
  f.Id_Factura,
  f.Numero_Factura,
  f.Total AS Factura_Total,
  ISNULL(pagos.Total_Pagado,0) AS Total_Pagado,
  (ven.Precio_Venta - ISNULL(pagos.Total_Pagado,0)) AS Saldo_Pendiente
FROM Ventas ven
JOIN Vehiculos v ON ven.Id_Vehiculo = v.Id_Vehiculo
JOIN Clientes c ON ven.Id_Cliente = c.Id_Cliente
JOIN Tbl_Datos_Personales tp ON c.Id_Persona = tp.Id_Persona
LEFT JOIN Facturas f ON f.Id_Venta = ven.Id_Venta
LEFT JOIN (
   SELECT Id_Venta, SUM(Monto) AS Total_Pagado
   FROM Pagos
   GROUP BY Id_Venta
) pagos ON pagos.Id_Venta = ven.Id_Venta;
GO

IF OBJECT_ID('vw_Financiamiento_Saldos','V') IS NOT NULL DROP VIEW vw_Financiamiento_Saldos;
GO
CREATE VIEW vw_Financiamiento_Saldos AS
SELECT
  fin.Id_Financiamiento,
  fin.Id_Venta,
  ven.Id_Vehiculo,
  v.Marca,
  v.Modelo,
  c.Id_Cliente,
  tp.Primer_Nombre + ' ' + ISNULL(tp.Segundo_Nombre,'') + ' ' + tp.Primer_Apellido + ' ' + ISNULL(tp.Segundo_Apellido,'') AS Cliente_Nombre,
  fin.Monto AS Monto_Financiado,
  fin.Plazo_Meses,
  fin.Tasa_Interes,
  ISNULL(pagos.Total_Pagado,0) AS Total_Pagado,
  (fin.Monto - ISNULL(pagos.Total_Pagado,0)) AS Saldo_Pendiente,
  fin.Fecha_Inicio,
  fin.Fecha_Cancelacion
FROM Financiamiento fin
JOIN Ventas ven ON fin.Id_Venta = ven.Id_Venta
JOIN Vehiculos v ON ven.Id_Vehiculo = v.Id_Vehiculo
JOIN Clientes c ON fin.Id_Cliente = c.Id_Cliente
JOIN Tbl_Datos_Personales tp ON c.Id_Persona = tp.Id_Persona
LEFT JOIN (
   SELECT Id_Financiamiento, SUM(Monto) AS Total_Pagado
   FROM Pagos
   GROUP BY Id_Financiamiento
) pagos ON pagos.Id_Financiamiento = fin.Id_Financiamiento;
GO

IF OBJECT_ID('vw_Clientes_Completo','V') IS NOT NULL DROP VIEW vw_Clientes_Completo;
GO
CREATE VIEW vw_Clientes_Completo AS
SELECT
  c.Id_Cliente,
  tp.Id_Persona,
  tp.Primer_Nombre,
  tp.Segundo_Nombre,
  tp.Primer_Apellido,
  tp.Segundo_Apellido,
  tp.DNI,
  tel.Valor_Contacto AS Telefono_Principal,
  mail.Valor_Contacto AS Correo_Principal,
  dir.Direccion AS Direccion_Principal,
  c.Fecha_Registro,
  c.Activo
FROM Clientes c
JOIN Tbl_Datos_Personales tp ON c.Id_Persona = tp.Id_Persona
LEFT JOIN (
   SELECT Id_Persona, Valor_Contacto
   FROM Tbl_Contactos
   WHERE Id_Tipo_Contacto = (SELECT TOP 1 Id_Catalogo FROM Cls_Catalogos cc JOIN Cls_Tipo_Catalogos tt ON cc.Id_Tipo_Catalogo=tt.Id_Tipo_Catalogo WHERE tt.Codigo='CONTACTO' AND cc.Codigo='TEL')
     AND Principal = 1
) tel ON tel.Id_Persona = tp.Id_Persona
LEFT JOIN (
   SELECT Id_Persona, Valor_Contacto
   FROM Tbl_Contactos
   WHERE Id_Tipo_Contacto = (SELECT TOP 1 Id_Catalogo FROM Cls_Catalogos cc JOIN Cls_Tipo_Catalogos tt ON cc.Id_Tipo_Catalogo=tt.Id_Tipo_Catalogo WHERE tt.Codigo='CONTACTO' AND cc.Codigo='EMAIL')
     AND Principal = 1
) mail ON mail.Id_Persona = tp.Id_Persona
LEFT JOIN (
   SELECT Id_Persona, Direccion
   FROM Tbl_Direcciones
   WHERE Principal = 1
) dir ON dir.Id_Persona = tp.Id_Persona;
GO

IF OBJECT_ID('vw_Empleados_Completo','V') IS NOT NULL DROP VIEW vw_Empleados_Completo;
GO
CREATE VIEW vw_Empleados_Completo AS
SELECT
  emp.Id_Empleado,
  tp.Id_Persona,
  tp.Primer_Nombre + ' ' + ISNULL(tp.Segundo_Nombre,'') + ' ' + tp.Primer_Apellido + ' ' + ISNULL(tp.Segundo_Apellido,'') AS Empleado_Nombre,
  cgo.Catalogo AS Cargo,
  ar.Catalogo AS Area,
  tel.Valor_Contacto AS Telefono_Principal,
  emp.Fecha_Registro,
  emp.Activo
FROM Empleados emp
JOIN Tbl_Datos_Personales tp ON emp.Id_Persona = tp.Id_Persona
LEFT JOIN Cls_Catalogos cgo ON emp.Id_Cargo = cgo.Id_Catalogo
LEFT JOIN Cls_Catalogos ar ON emp.Id_Area = ar.Id_Catalogo
LEFT JOIN (
   SELECT Id_Persona, Valor_Contacto
   FROM Tbl_Contactos
   WHERE Id_Tipo_Contacto = (SELECT TOP 1 Id_Catalogo FROM Cls_Catalogos cc JOIN Cls_Tipo_Catalogos tt ON cc.Id_Tipo_Catalogo=tt.Id_Tipo_Catalogo WHERE tt.Codigo='CONTACTO' AND cc.Codigo='TEL')
     AND Principal = 1
) tel ON tel.Id_Persona = tp.Id_Persona;
GO




-- ver las vistas : 

-- 1) Listar todas las vistas en la base
SELECT 
    s.name AS SchemaName,
    v.name AS ViewName,
    v.create_date,
    v.modify_date
FROM sys.views v
JOIN sys.schemas s ON v.schema_id = s.schema_id
ORDER BY s.name, v.name;
GO

-- 2) Ver la definición (DDL) de una vista específica
-- Reemplace 'vw_Ventas_Detalle' por la vista que quiera inspeccionar
SELECT OBJECT_DEFINITION(OBJECT_ID('dbo.vw_Ventas_Detalle')) AS ViewDefinition;
GO

-- Alternativa: mostrar el texto con sp_helptext
EXEC sp_helptext 'dbo.vw_Ventas_Detalle';
GO

-- 3) Consultar todas las filas de cada vista (uso básico)
SELECT * FROM dbo.vw_Inventario_Completo;
SELECT * FROM dbo.vw_Ventas_Detalle;
SELECT * FROM dbo.vw_Financiamiento_Saldos;
SELECT * FROM dbo.vw_Clientes_Completo;
SELECT * FROM dbo.vw_Empleados_Completo;
GO

-- 4) Consultas útiles sobre las vistas (resúmenes)
-- Conteo de registros por vista
SELECT 'vw_Inventario_Completo' AS Vista, COUNT(*) AS Filas FROM dbo.vw_Inventario_Completo
UNION ALL
SELECT 'vw_Ventas_Detalle', COUNT(*) FROM dbo.vw_Ventas_Detalle
UNION ALL
SELECT 'vw_Financiamiento_Saldos', COUNT(*) FROM dbo.vw_Financiamiento_Saldos
UNION ALL
SELECT 'vw_Clientes_Completo', COUNT(*) FROM dbo.vw_Clientes_Completo
UNION ALL
SELECT 'vw_Empleados_Completo', COUNT(*) FROM dbo.vw_Empleados_Completo;
GO

-- 5) Ejemplos de consultas con filtros y orden
-- Vehículos disponibles ordenados por marca/modelo
SELECT * FROM dbo.vw_Inventario_Completo
WHERE Estado_Vehiculo = 'Disponible'
ORDER BY Marca, Modelo;
GO

-- Ventas con saldo pendiente mayor que cero
SELECT * FROM dbo.vw_Ventas_Detalle
WHERE Saldo_Pendiente > 0
ORDER BY Saldo_Pendiente DESC;
GO

-- Clientes con saldo pendiente (usando la vista de financiamiento)
SELECT DISTINCT c.Id_Cliente, c.Cliente_Nombre, f.Saldo_Pendiente
FROM dbo.vw_Financiamiento_Saldos f
JOIN dbo.vw_Clientes_Completo c ON f.Id_Cliente = c.Id_Cliente
WHERE f.Saldo_Pendiente > 0
ORDER BY f.Saldo_Pendiente DESC;
GO

-- 6) Ver columnas de una vista (metadatos)
SELECT 
    c.COLUMN_NAME,
    c.DATA_TYPE,
    c.CHARACTER_MAXIMUM_LENGTH
FROM INFORMATION_SCHEMA.VIEW_COLUMN_USAGE vcu
JOIN INFORMATION_SCHEMA.COLUMNS c ON c.TABLE_SCHEMA = 'dbo' AND c.TABLE_NAME = 'vw_Ventas_Detalle' AND c.COLUMN_NAME = vcu.COLUMN_NAME
WHERE vcu.VIEW_NAME = 'vw_Ventas_Detalle';
-- Si devuelve vacío, use INFORMATION_SCHEMA.COLUMNS directamente:
SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'vw_Ventas_Detalle';
GO



SELECT * FROM dbo.vw_Inventario_Completo;
SELECT * FROM dbo.vw_Ventas_Detalle;
SELECT * FROM dbo.vw_Financiamiento_Saldos;
SELECT * FROM dbo.vw_Clientes_Completo;
SELECT * FROM dbo.vw_Empleados_Completo;
GO



SELECT TOP (100) * FROM dbo.vw_Inventario_Completo;
SELECT TOP (100) * FROM dbo.vw_Ventas_Detalle;
SELECT TOP (100) * FROM dbo.vw_Financiamiento_Saldos;
SELECT TOP (100) * FROM dbo.vw_Clientes_Completo;
SELECT TOP (100) * FROM dbo.vw_Empleados_Completo;
GO
