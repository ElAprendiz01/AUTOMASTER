
CREATE OR ALTER PROCEDURE SPEliminarFinanciamiento
(
    @Id_Financiamiento INT
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
            DELETE FROM Financiamiento WHERE Id_Financiamiento = @Id_Financiamiento
        COMMIT
        PRINT 'FINANCIAMIENTO ELIMINADO'
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'ERROR ELIMINAR FINANCIAMIENTO: ' + ERROR_MESSAGE()
    END CATCH
END
GO
