USE AUTOMASTER
GO

CREATE OR ALTER PROCEDURE SPListarRoles
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        SELECT 
            Id_Rol,
            Nombre_Rol
        FROM Roles
    END TRY
    BEGIN CATCH
        PRINT 'ERROR: ' + ERROR_MESSAGE()
    END CATCH
END
GO

EXEC SPListarRoles