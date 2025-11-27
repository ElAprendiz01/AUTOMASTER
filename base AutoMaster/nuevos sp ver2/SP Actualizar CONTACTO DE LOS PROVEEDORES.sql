USE AUTOMASTER
GO

CREATE OR ALTER PROCEDURE SPActualizarProveedorContactos
(
   @Id_Proveedor INT,
   @Id_Contacto INT,
   @Principal BIT
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
            UPDATE Proveedor_Contactos
            SET Principal = @Principal,
                Fecha_Registro = SYSDATETIME()
            WHERE Id_Proveedor = @Id_Proveedor 
              AND Id_Contacto = @Id_Contacto

        COMMIT
        PRINT 'SE HA ACTUALIZADO LA RELACION PROVEEDOR-CONTACTO'
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'NO SE HA ACTUALIZADO ' + ERROR_MESSAGE()
    END CATCH
END
GO


-- Ver relaciones existentes:
SELECT * FROM Proveedor_Contactos


EXEC SPActualizarProveedorContactos
    @Id_Proveedor = 1,  
    @Id_Contacto = 1,   
    @Principal = 0      