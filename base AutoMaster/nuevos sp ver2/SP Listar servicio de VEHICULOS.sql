USE AUTOMASTER
GO

CREATE OR ALTER PROCEDURE SPListarServiciosVehiculos
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        SELECT 
            SV.Id_Servicio,
            SV.Id_Vehiculo,
            V.Marca + ' ' + V.Modelo + ' (' + V.Serie_Chasis + ')' AS Vehiculo_Info,
            SV.Id_Tipo_Servicio,
            CAT.Catalogo AS Tipo_Servicio,
            SV.Fecha_Servicio,
            SV.Costo,
            SV.Realizado_por AS Id_Empleado,
            ISNULL(P.Primer_Nombre + ' ' + P.Primer_Apellido, 'NO ASIGNADO') AS Nombre_Mecanico,
            SV.Observaciones,
            SV.Fecha_Registro
        FROM Servicios_Vehiculos SV
        INNER JOIN Vehiculos V ON SV.Id_Vehiculo = V.Id_Vehiculo
        LEFT JOIN Cls_Catalogos CAT ON SV.Id_Tipo_Servicio = CAT.Id_Catalogo
        LEFT JOIN Empleados E ON SV.Realizado_por = E.Id_Empleado
        LEFT JOIN Tbl_Datos_Personales P ON E.Id_Persona = P.Id_Persona
    END TRY
    BEGIN CATCH
        PRINT 'ERROR AL LISTAR: ' + ERROR_MESSAGE()
    END CATCH
END
GO

EXEC SPListarServiciosVehiculos