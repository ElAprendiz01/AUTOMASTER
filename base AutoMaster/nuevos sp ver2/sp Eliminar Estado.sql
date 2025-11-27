USE AUTOMASTER;
GO

CREATE OR ALTER PROCEDURE SP_Cls_Estados_Eliminar
(
    @Id_Estado INT
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
            DELETE Cls_Estados WHERE Id_Estado = @Id_Estado
        COMMIT
        PRINT 'El estado se eliminó correctamente'
    END TRY
    BEGIN CATCH
        ROLLBACK
       
        PRINT 'El estado no se pudo eliminar ' + @@ERROR
    END CATCH
END
GO
