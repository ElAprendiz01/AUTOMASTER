USE AUTOMASTER
GO

CREATE OR ALTER PROCEDURE SPInsertarServiciosVehiculos
(
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
            INSERT INTO Servicios_Vehiculos
            (
                Id_Vehiculo,
                Id_Tipo_Servicio,
                Fecha_Servicio,
                Costo,
                Realizado_por,
                Observaciones
            )
            VALUES
            (
                @Id_Vehiculo,
                @Id_Tipo_Servicio,
                @Fecha_Servicio,
                @Costo,
                @Realizado_por,
                @Observaciones
            )
        COMMIT
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'ERROR AL INSERTAR: ' + ERROR_MESSAGE()
    END CATCH
END
GO

SELECT * FROM Vehiculos
SELECT * FROM Cls_Catalogos
SELECT * FROM Empleados

EXEC SPInsertarServiciosVehiculos
    @Id_Vehiculo = 1,
    @Id_Tipo_Servicio = 1,
    @Fecha_Servicio = '2023-10-31',
    @Costo = 150.00,
    @Realizado_por = 1,
    @Observaciones = 'MANTENIMIENTO PREVENTIVO'