USE AUTOMASTER
GO
CREATE OR ALTER PROCEDURE SPListarTaller
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        SELECT 
            T.Id_Taller,
            T.Id_Vehiculo,
            V.Marca + ' ' + V.Modelo AS Vehiculo_Descripcion,
            V.Serie_Chasis,
            T.Descripcion_Trabajo,
            T.Fecha_Ingreso,
            T.Fecha_Salida,
            T.Costo,
            T.Responsable AS Id_Responsable,
            DP.Primer_Nombre + ' ' + DP.Primer_Apellido AS Nombre_Responsable,
            T.Fecha_Registro
        FROM Taller AS T
        INNER JOIN Vehiculos AS V ON T.Id_Vehiculo = V.Id_Vehiculo
        LEFT JOIN Empleados AS E ON T.Responsable = E.Id_Empleado
        LEFT JOIN Tbl_Datos_Personales AS DP ON E.Id_Persona = DP.Id_Persona
    END TRY
    BEGIN CATCH
        PRINT 'ERROR AL LISTAR ' + ERROR_MESSAGE()
    END CATCH
END
GO

EXEC SPListarTaller