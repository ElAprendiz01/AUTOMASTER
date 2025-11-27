USE AUTOMASTER
GO

CREATE OR ALTER PROCEDURE SPinsertarProveedorContactos
(
   @Id_Proveedor INT,
   @Id_Contacto INT,
   @Principal BIT
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
            INSERT INTO Proveedor_Contactos(
                Id_Proveedor,
                Id_Contacto,
                Principal,
                Fecha_Registro
            )
            VALUES (
                @Id_Proveedor,
                @Id_Contacto,
                @Principal,
                SYSDATETIME()
            )
        COMMIT
        PRINT 'SE HA INSERTADO LA RELACION PROVEEDOR-CONTACTO'
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'NO SE HA INSERTADO ' + ERROR_MESSAGE()
    END CATCH
END
GO


SELECT Id_Proveedor, Nombre_Empresa, RUC_Empresa FROM Tbl_Proveedores
SELECT Id_Contacto, Contacto FROM Tbl_Contactos


EXEC SPinsertarProveedorContactos
    @Id_Proveedor = 1,  
    @Id_Contacto = 2004,   
    @Principal = 1