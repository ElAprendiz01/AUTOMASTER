USE AUTOMASTER
GO

CREATE OR ALTER PROCEDURE SPActualizarClientes
(
   @Id_Cliente INT,
   @Id_Persona INT,
   @Activo BIT
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
            UPDATE Clientes
            SET Id_Persona = @Id_Persona,
                Activo = @Activo
            WHERE Id_Cliente = @Id_Cliente
        COMMIT
        PRINT 'SE HA ACTUALIZADO EL CLIENTE CORRECTAMENTE'
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'ERROR CRITICO AL ACTUALIZAR: ' + ERROR_MESSAGE()
    END CATCH
END
GO


EXEC SPActualizarClientes 1,1002,0