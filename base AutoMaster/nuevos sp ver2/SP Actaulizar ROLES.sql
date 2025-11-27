USE AUTOMASTER
GO

CREATE OR ALTER PROCEDURE SPActualizarRol
(
   @Id_Rol INT,
   @Nombre_Rol VARCHAR(100)
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
            UPDATE Roles
            SET Nombre_Rol = @Nombre_Rol
            WHERE Id_Rol = @Id_Rol
        COMMIT
        PRINT 'SE HA ACTUALIZADO EL ROL'
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'ERROR: ' + ERROR_MESSAGE()
    END CATCH
END
GO

SELECT * FROM Roles