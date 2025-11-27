CREATE OR ALTER PROCEDURE SPActualizarPago
(
    @Id_Pago INT,
    @Id_Venta INT = NULL,
    @Id_Financiamiento INT = NULL,
    @Fecha_Pago DATETIME2,
    @Monto DECIMAL(18,2),
    @Metodo_Pago VARCHAR(20),
    @Observaciones VARCHAR(500)
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
            UPDATE Pagos
            SET Id_Venta = @Id_Venta,
                Id_Financiamiento = @Id_Financiamiento,
                Fecha_Pago = @Fecha_Pago,
                Monto = @Monto,
                Metodo_Pago = @Metodo_Pago,
                Observaciones = @Observaciones
            WHERE Id_Pago = @Id_Pago
        COMMIT
        PRINT 'PAGO ACTUALIZADO'
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'ERROR ACTUALIZAR PAGO: ' + ERROR_MESSAGE()
    END CATCH
END
GO