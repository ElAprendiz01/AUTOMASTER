
CREATE OR ALTER PROCEDURE SPActualizarFactura
(
    @Id_Factura INT,
    @Id_Venta INT,
    @Id_Pago INT = NULL,
    @Id_Financiamiento INT = NULL,
    @Numero_Factura VARCHAR(100),
    @Subtotal DECIMAL(18,2),
    @IVA DECIMAL(18,2),
    @Total DECIMAL(18,2)
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
            UPDATE Facturas
            SET Id_Venta = @Id_Venta,
                Id_Pago = @Id_Pago,
                Id_Financiamiento = @Id_Financiamiento,
                Numero_Factura = @Numero_Factura,
                Subtotal = @Subtotal,
                IVA = @IVA,
                Total = @Total
            WHERE Id_Factura = @Id_Factura
        COMMIT
        PRINT 'FACTURA ACTUALIZADA'
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'ERROR ACTUALIZAR FACTURA: ' + ERROR_MESSAGE()
    END CATCH
END
GO

