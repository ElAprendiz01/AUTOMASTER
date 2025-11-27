CREATE OR ALTER PROCEDURE SPListarVentas
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        SELECT 
            V.Id_Venta,
            V.Id_Vehiculo,
            VEH.Marca + ' ' + VEH.Modelo AS Vehiculo,
            V.Id_Cliente,
            PC.Primer_Nombre + ' ' + PC.Primer_Apellido AS Nombre_Cliente,
            V.Id_Empleado,
            PE.Primer_Nombre + ' ' + PE.Primer_Apellido AS Nombre_Empleado,
            V.Fecha_Venta,
            V.Precio_Venta,
            V.Observaciones,
            V.Fecha_Registro
        FROM Ventas V
        INNER JOIN Vehiculos VEH ON V.Id_Vehiculo = VEH.Id_Vehiculo
        INNER JOIN Clientes C ON V.Id_Cliente = C.Id_Cliente
        INNER JOIN Tbl_Datos_Personales PC ON C.Id_Persona = PC.Id_Persona
        INNER JOIN Empleados E ON V.Id_Empleado = E.Id_Empleado
        INNER JOIN Tbl_Datos_Personales PE ON E.Id_Persona = PE.Id_Persona
    END TRY
    BEGIN CATCH
        PRINT 'ERROR AL LISTAR VENTAS: ' + ERROR_MESSAGE()
    END CATCH
END
GO