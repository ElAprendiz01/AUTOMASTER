USE AUTOMASTER
GO

CREATE OR ALTER PROCEDURE SPListarVehiculos
AS 
BEGIN 
  SET NOCOUNT ON;
    BEGIN TRY 
        SELECT 
            V.Id_Vehiculo,
            V.Id_Proveedor,
            P.Nombre_Empresa AS Proveedor, -- Alias para lectura
            V.Marca,
            V.Modelo,
            V.Anio,
            V.Serie_Chasis,
            V.Serie_Motor,
            V.Precio,
            V.Id_Estado,
            E.Estado AS Nombre_Estado,    -- Alias para lectura
            V.Fecha_Ingreso_Pais,
            V.Fecha_Registro
        FROM Vehiculos AS V
        LEFT JOIN Tbl_Proveedores P ON V.Id_Proveedor = P.Id_Proveedor
        INNER JOIN Cls_Estados E ON V.Id_Estado = E.Id_Estado
    END TRY
    BEGIN CATCH 
        PRINT 'NO SE HA PODIDO LISTAR ' + ERROR_MESSAGE()
    END CATCH 
END 
GO

EXEC SPListarVehiculos