
CREATE OR ALTER PROCEDURE SPInsertarFactura
(
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
            INSERT INTO Facturas (Id_Venta, Id_Pago, Id_Financiamiento, Numero_Factura, Subtotal, IVA, Total)
            VALUES (@Id_Venta, @Id_Pago, @Id_Financiamiento, @Numero_Factura, @Subtotal, @IVA, @Total)
        COMMIT
        PRINT 'FACTURA GENERADA'
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'ERROR INSERTAR FACTURA: ' + ERROR_MESSAGE()
    END CATCH
END
GO