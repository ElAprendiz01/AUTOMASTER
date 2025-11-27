USE AUTOMASTER
GO

CREATE OR ALTER PROCEDURE SPeliminarProveedorContactos
(
   @Id_Proveedor INT,
   @Id_Contacto INT
)
AS 
BEGIN 
    BEGIN TRY 
        BEGIN TRAN 
            DELETE Proveedor_Contactos 
            WHERE Id_Proveedor = @Id_Proveedor 
              AND Id_Contacto = @Id_Contacto
        COMMIT 
        PRINT 'SE HA ELIMINADO LA RELACION'
    END TRY 
    BEGIN CATCH 
        ROLLBACK
        PRINT 'NO SE HA PODIDO ELIMINAR ' + ERROR_MESSAGE()
    END CATCH 
END 
GO


SELECT * FROM Proveedor_Contactos

EXEC SPeliminarProveedorContactos 
    @Id_Proveedor = 1, 
    @Id_Contacto = 1