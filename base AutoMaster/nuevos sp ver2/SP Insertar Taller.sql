USE AUTOMASTER
GO
CREATE OR ALTER PROCEDURE SPInsertarTaller
(
    @Id_Vehiculo INT,
    @Descripcion_Trabajo VARCHAR(500),
    @Fecha_Ingreso DATE,
    @Fecha_Salida DATE,
    @Costo DECIMAL(18,2),
    @Responsable INT
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
            INSERT INTO Taller
            (
                Id_Vehiculo,
                Descripcion_Trabajo,
                Fecha_Ingreso,
                Fecha_Salida,
                Costo,
                Responsable
            )
            VALUES
            (
                @Id_Vehiculo,
                @Descripcion_Trabajo,
                @Fecha_Ingreso,
                @Fecha_Salida,
                @Costo,
                @Responsable
            )
        COMMIT
        PRINT 'REGISTRO INSERTADO CORRECTAMENTE'
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'ERROR AL INSERTAR ' + ERROR_MESSAGE()
    END CATCH
END
GO

SELECT * FROM Vehiculos
SELECT * FROM Empleados

EXEC SPInsertarTaller 
    @Id_Vehiculo = 1, 
    @Descripcion_Trabajo = 'Mantenimiento General de Frenos',
    @Fecha_Ingreso = '2025-11-23',
    @Fecha_Salida = NULL, 
    @Costo = 0.00, 
    @Responsable = 1