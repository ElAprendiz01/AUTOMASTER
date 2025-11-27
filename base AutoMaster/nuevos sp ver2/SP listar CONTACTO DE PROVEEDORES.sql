USE AUTOMASTER;
GO

CREATE OR ALTER PROCEDURE SPlistarContactoProveedor
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        SELECT 
            prov.Id_Proveedor,
            prov.Nombre_Empresa,
            prov.RUC_Empresa,
			cont.Id_Contacto,
			cont.Contacto,
            conProv.Principal AS ContactoPrincipal,
            dp.Id_Persona  AS ID_Representante,
            dp.Primer_Nombre,
            dp.Segundo_Nombre,
            dp.Primer_Apellido,
            dp.Segundo_Apellido
        FROM Proveedor_Contactos AS conProv
        INNER JOIN Tbl_Proveedores prov 
            ON conProv.Id_Proveedor = prov.Id_Proveedor
        INNER JOIN Tbl_Contactos cont 
            ON conProv.Id_Contacto = cont.Id_Contacto
        LEFT JOIN Tbl_Datos_Personales dp 
            ON cont.Id_Persona = dp.Id_Persona
        LEFT JOIN Tbl_Direcciones dir 
            ON dp.Id_Persona = dir.Id_Persona
        LEFT JOIN Cls_Estados est 
            ON dir.Id_Estado = est.Id_Estado
        ORDER BY prov.Id_Proveedor, dp.Id_Persona;
    END TRY
    BEGIN CATCH
        PRINT 'NO SE HA PODIDO LISTAR. ERROR: ' + ERROR_MESSAGE();
    END CATCH
END;
GO

-- Ejecución
EXEC SPlistarContactoProveedor;

select * from Proveedor_Contactos