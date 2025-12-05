use AUTOMASTER
go


CREATE OR ALTER PROCEDURE SPInsertarPago
(
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
            INSERT INTO Pagos (Id_Venta, Id_Financiamiento, Fecha_Pago, Monto, Metodo_Pago, Observaciones)
            VALUES (@Id_Venta, @Id_Financiamiento, @Fecha_Pago, @Monto, @Metodo_Pago, @Observaciones)
        COMMIT
        PRINT 'PAGO REGISTRADO'
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'ERROR INSERTAR PAGO: ' + ERROR_MESSAGE()
    END CATCH
END
GO
exec SPInsertarPago 1,1,'2023/10/10',20.36,'financiado','no tenia riales '
exec SPListarPagos
