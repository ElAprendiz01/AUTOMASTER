USE AUTOMASTER
GO

CREATE OR ALTER PROCEDURE SPActualizarServiciosVehiculos
(
    @Id_Servicio INT,
    @Id_Vehiculo INT,
    @Id_Tipo_Servicio INT,
    @Fecha_Servicio DATE,
    @Costo DECIMAL(18,2),
    @Realizado_por INT,
    @Observaciones VARCHAR(500)
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
            UPDATE Servicios_Vehiculos
            SET 
                Id_Vehiculo = @Id_Vehiculo,
                Id_Tipo_Servicio = @Id_Tipo_Servicio,
                Fecha_Servicio = @Fecha_Servicio,
                Costo = @Costo,
                Realizado_por = @Realizado_por,
                Observaciones = @Observaciones
            WHERE Id_Servicio = @Id_Servicio
        COMMIT
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'ERROR AL ACTUALIZAR: ' + ERROR_MESSAGE()
    END CATCH
END
GO

SELECT * FROM Servicios_Vehiculos
SELECT * FROM Vehiculos
SELECT * FROM Cls_Catalogos
SELECT * FROM Empleados

EXEC SPActualizarServiciosVehiculos
    @Id_Servicio = 1,
    @Id_Vehiculo = 1,
    @Id_Tipo_Servicio = 2,
    @Fecha_Servicio = '2023-11-01',
    @Costo = 200.00,
    @Realizado_por = 1,
    @Observaciones = 'CORRECCION DE MANTENIMIENTO'