CREATE OR ALTER PROCEDURE SP_Cls_Tipo_Catalogos_Eliminar
(
    @Id_Tipo_Catalogo INT
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
            DELETE Cls_Tipo_Catalogos WHERE Id_Tipo_Catalogo = @Id_Tipo_Catalogo
        COMMIT
        PRINT 'El Tipo de Catálogo se eliminó correctamente'
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'El Tipo de Catálogo no se pudo eliminar ' + @@ERROR
    END CATCH
END
GO