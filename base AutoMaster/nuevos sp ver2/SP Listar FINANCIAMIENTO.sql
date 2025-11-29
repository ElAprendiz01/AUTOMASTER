use AUTOMASTER
go 
CREATE OR ALTER PROCEDURE SPListarFinanciamientos
AS
BEGIN
    SET NOCOUNT ON;
    SELECT 
        F.Id_Financiamiento,
        F.Id_Venta,
        F.Id_Cliente,
        DP.Primer_Nombre + ' ' + DP.Primer_Apellido AS Cliente,
        F.Monto,
        F.Plazo_Meses,
        F.Tasa_Interes,
        F.Fecha_Inicio,
        F.Fecha_Cancelacion,
        F.Fecha_Registro
    FROM Financiamiento F
    INNER JOIN Clientes C ON F.Id_Cliente = C.Id_Cliente
    INNER JOIN Tbl_Datos_Personales DP ON C.Id_Persona = DP.Id_Persona
END
GO
exec SPListarFinanciamientos