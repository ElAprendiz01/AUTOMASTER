USE AUTOMASTER;
GO

CREATE OR ALTER PROCEDURE SP_Cls_Estados_Editar
(
    @Id_Estado INT,
    @Estado VARCHAR(80),
    @Activo BIT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRAN
            
            UPDATE Cls_Estados
            SET Estado = @Estado,
                Activo = @Activo,
                Fecha_Modificacion = SYSDATETIME() -- Actualizamos la auditoría automáticamente
            WHERE Id_Estado = @Id_Estado;

        COMMIT TRAN;
        PRINT 'Estado modificado correctamente';
    END TRY
    BEGIN CATCH
        ROLLBACK TRAN;
        
        PRINT 'NO SE HA MODIFICADO POR EL ERROR: ' + @@ERROR;
    END CATCH
END;
GO


SELECT * FROM Cls_Estados WHERE Id_Estado = 1;

--  Ejecutar la edición (Cambiamos nombre y fecha)
EXEC SP_Cls_Estados_Editar 
    @Id_Estado = 1, 
    @Estado = 'Disponible ', 
    @Activo = 1;


SELECT * FROM Cls_Estados WHERE Id_Estado = 1;