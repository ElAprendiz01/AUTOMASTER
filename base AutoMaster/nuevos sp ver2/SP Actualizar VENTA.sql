
CREATE OR ALTER PROCEDURE SPActualizarVenta
(
    @Id_Venta INT,
    @Id_Vehiculo INT,
    @Id_Cliente INT,
    @Id_Empleado INT,
    @Fecha_Venta DATE,
    @Precio_Venta DECIMAL(18,2),
    @Observaciones VARCHAR(500)
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
            UPDATE Ventas
            SET Id_Vehiculo = @Id_Vehiculo,
                Id_Cliente = @Id_Cliente,
                Id_Empleado = @Id_Empleado,
                Fecha_Venta = @Fecha_Venta,
                Precio_Venta = @Precio_Venta,
                Observaciones = @Observaciones
            WHERE Id_Venta = @Id_Venta
        COMMIT
        PRINT 'VENTA ACTUALIZADA CORRECTAMENTE'
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'ERROR AL ACTUALIZAR VENTA: ' + ERROR_MESSAGE()
    END CATCH
END
GO
