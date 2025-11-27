USE AUTOMASTER
GO

CREATE OR ALTER PROCEDURE SPEliminarServiciosVehiculos
(
    @Id_Servicio INT
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
            DELETE FROM Servicios_Vehiculos
            WHERE Id_Servicio = @Id_Servicio
        COMMIT
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'ERROR AL ELIMINAR: ' + ERROR_MESSAGE()
    END CATCH
END
GO

SELECT * FROM Servicios_Vehiculos

EXEC SPEliminarServiciosVehiculos @Id_Servicio = 1