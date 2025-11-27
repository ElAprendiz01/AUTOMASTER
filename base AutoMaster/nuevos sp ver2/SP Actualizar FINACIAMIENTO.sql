CREATE OR ALTER PROCEDURE SPActualizarFinanciamiento
(
    @Id_Financiamiento INT,
    @Id_Venta INT,
    @Id_Cliente INT,
    @Monto DECIMAL(18,2),
    @Plazo_Meses INT,
    @Tasa_Interes DECIMAL(9,4),
    @Fecha_Inicio DATE,
    @Fecha_Cancelacion DATE
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
            UPDATE Financiamiento
            SET Id_Venta = @Id_Venta,
                Id_Cliente = @Id_Cliente,
                Monto = @Monto,
                Plazo_Meses = @Plazo_Meses,
                Tasa_Interes = @Tasa_Interes,
                Fecha_Inicio = @Fecha_Inicio,
                Fecha_Cancelacion = @Fecha_Cancelacion
            WHERE Id_Financiamiento = @Id_Financiamiento
        COMMIT
        PRINT 'FINANCIAMIENTO ACTUALIZADO'
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'ERROR ACTUALIZAR FINANCIAMIENTO: ' + ERROR_MESSAGE()
    END CATCH
END
GO
