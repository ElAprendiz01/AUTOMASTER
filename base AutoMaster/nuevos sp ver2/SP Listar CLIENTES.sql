USE AUTOMASTER
GO

CREATE OR ALTER PROCEDURE SPListarClientes
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        SELECT 
            C.Id_Cliente,
            C.Id_Persona,
            P.Primer_Nombre,
            P.Segundo_Nombre,
            P.Primer_Apellido,
            P.Segundo_Apellido,
            P.DNI,
            C.Fecha_Registro,
            C.Activo
        FROM Clientes AS C
        INNER JOIN Tbl_Datos_Personales AS P ON C.Id_Persona = P.Id_Persona
    END TRY
    BEGIN CATCH
        PRINT 'NO SE HA PODIDO LISTAR: ' + ERROR_MESSAGE()
    END CATCH
END
GO


EXEC SPListarClientes