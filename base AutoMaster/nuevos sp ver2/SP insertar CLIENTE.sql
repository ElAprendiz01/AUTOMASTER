USE AUTOMASTER
GO

CREATE OR ALTER PROCEDURE SPInsertarClientes
(
   @Id_Persona INT
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
            INSERT INTO Clientes (
                Id_Persona,
                Fecha_Registro,
                Activo
            )
            VALUES (
                @Id_Persona,
                SYSUTCDATETIME(),
                1 -- Por defecto Activo al crear
            )
        COMMIT
        PRINT 'SE HA INSERTADO EL CLIENTE CORRECTAMENTE'
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'ERROR CRITICO AL INSERTAR: ' + ERROR_MESSAGE()
    END CATCH
END
GO

EXEC SPInsertarClientes 1002