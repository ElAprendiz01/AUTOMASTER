USE AUTOMASTER
GO

CREATE OR ALTER PROCEDURE SPListarPagos
AS 
BEGIN 
  SET NOCOUNT ON;
    BEGIN TRY 
        SELECT 
        P.Id_Pago,
        P.Id_Venta,
        V.Fecha_Venta,
        P.Id_Financiamiento,
        F.Fecha_Inicio AS Fecha_Inicio_Financiamiento,
        P.Fecha_Pago,
        P.Monto,
        P.Metodo_Pago,
        P.Observaciones,
        P.Fecha_Registro

        FROM Pagos AS P
        LEFT JOIN Ventas V ON P.Id_Venta = V.Id_Venta
        LEFT JOIN Financiamiento F ON P.Id_Financiamiento = F.Id_Financiamiento
    END TRY
    BEGIN CATCH 
        PRINT 'NO SE HA PODIDO LISTAR '+ @@ERROR
    END CATCH 
END 
GO 

EXEC SPListarPagos