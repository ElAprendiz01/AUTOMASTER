CREATE OR ALTER PROCEDURE SP_Cls_Catalogos_Eliminar
(
    @Id_Catalogo INT
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
            DELETE Cls_Catalogos WHERE Id_Catalogo = @Id_Catalogo
        COMMIT
        PRINT 'El Catálogo se eliminó correctamente'
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'El Catálogo no se pudo eliminar ' + @@ERROR
    END CATCH
END
GO