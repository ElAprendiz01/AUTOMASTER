USE AUTOMASTER
GO

CREATE OR ALTER PROCEDURE SPListarFacturas
AS 
BEGIN 
  SET NOCOUNT ON;
    BEGIN TRY 
        SELECT 
        F.Id_Factura,
        F.Id_Venta,
        V.Fecha_Venta,
        C.Id_Cliente,
        DP.Primer_Nombre + ' ' + DP.Primer_Apellido AS Nombre_Cliente,
        DP.DNI AS DNI_Cliente,

        F.Id_Pago,
        Pg.Metodo_Pago,
        Pg.Fecha_Pago,
        F.Id_Financiamiento,
        Fin.Plazo_Meses,
        F.Numero_Factura,
        F.Fecha_Emision,
        F.Subtotal,
        F.IVA,
        F.Total

        FROM Facturas AS F
        INNER JOIN Ventas V ON F.Id_Venta = V.Id_Venta
        INNER JOIN Clientes C ON V.Id_Cliente = C.Id_Cliente
        INNER JOIN Tbl_Datos_Personales DP ON C.Id_Persona = DP.Id_Persona
        LEFT JOIN Pagos Pg ON F.Id_Pago = Pg.Id_Pago
        LEFT JOIN Financiamiento Fin ON F.Id_Financiamiento = Fin.Id_Financiamiento
    END TRY
    BEGIN CATCH 
        PRINT 'NO SE HA PODIDO LISTAR FACTURAS ' + @@ERROR
    END CATCH 
END 
GO 

EXEC SPListarFacturas