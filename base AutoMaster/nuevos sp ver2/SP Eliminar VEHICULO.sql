USE AUTOMASTER
GO

CREATE OR ALTER PROCEDURE SPeliminarVehiculos
(
   @Id_Vehiculo INT
)
AS 
BEGIN 
    BEGIN TRY 
        BEGIN TRAN 
            DELETE Vehiculos WHERE Id_Vehiculo = @Id_Vehiculo
        COMMIT 
        PRINT 'SE HA ELIMINADO'
    END TRY 
    BEGIN CATCH 
        ROLLBACK
        PRINT 'NO SE HA PODIDO ELIMINAR ' + ERROR_MESSAGE()
    END CATCH 
END 
GO