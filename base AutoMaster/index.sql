-- indix : 

-- base programacion con base de datos 
USE AUTOMASTER;
GO 
CREATE INDEX IX_Vehiculos_Id_Proveedor ON Vehiculos(Id_Proveedor);
CREATE INDEX IX_Ventas_Id_Vehiculo ON Ventas(Id_Vehiculo);
CREATE INDEX IX_Ventas_Id_Cliente ON Ventas(Id_Cliente);
CREATE INDEX IX_Pagos_Id_Venta ON Pagos(Id_Venta);
CREATE INDEX IX_Financiamiento_Id_Cliente ON Financiamiento(Id_Cliente);
GO