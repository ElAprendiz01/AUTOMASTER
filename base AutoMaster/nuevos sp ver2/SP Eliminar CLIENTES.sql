USE AUTOMASTER
GO

CREATE OR ALTER PROCEDURE SPEliminarClientes
(
   @Id_Cliente INT
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
            DELETE FROM Clientes 
            WHERE Id_Cliente = @Id_Cliente
        COMMIT
        PRINT 'SE HA ELIMINADO EL CLIENTE'
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'NO SE HA PODIDO ELIMINAR: ' + ERROR_MESSAGE()
    END CATCH
END
GO

EXEC SPEliminarClientes 1