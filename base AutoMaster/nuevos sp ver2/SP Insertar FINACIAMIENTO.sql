
CREATE OR ALTER PROCEDURE SPInsertarFinanciamiento
(
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
            INSERT INTO Financiamiento (Id_Venta, Id_Cliente, Monto, Plazo_Meses, Tasa_Interes, Fecha_Inicio, Fecha_Cancelacion)
            VALUES (@Id_Venta, @Id_Cliente, @Monto, @Plazo_Meses, @Tasa_Interes, @Fecha_Inicio, @Fecha_Cancelacion)
        COMMIT
        PRINT 'FINANCIAMIENTO REGISTRADO'
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'ERROR INSERTAR FINANCIAMIENTO: ' + ERROR_MESSAGE()
    END CATCH
END
GO