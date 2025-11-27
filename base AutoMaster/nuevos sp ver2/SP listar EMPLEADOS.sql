USE AUTOMASTER
GO

CREATE OR ALTER PROCEDURE SPListarEmpleados
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        SELECT 
            E.Id_Empleado,
            E.Id_Persona,
            DP.Primer_Nombre + ' ' + DP.Primer_Apellido AS Nombre_Completo,
            DP.DNI,
            E.Id_Cargo,
            CatCargo.Catalogo AS Cargo,
            E.Id_Area,
            CatArea.Catalogo AS Area,
            E.Activo,
            E.Fecha_Registro
        FROM Empleados AS E
        INNER JOIN Tbl_Datos_Personales DP ON E.Id_Persona = DP.Id_Persona
        LEFT JOIN Cls_Catalogos CatCargo ON E.Id_Cargo = CatCargo.Id_Catalogo
        LEFT JOIN Cls_Catalogos CatArea ON E.Id_Area = CatArea.Id_Catalogo
    END TRY
    BEGIN CATCH
        PRINT 'NO SE HA PODIDO LISTAR: ' + ERROR_MESSAGE()
    END CATCH
END
GO

EXEC SPListarEmpleados
GO