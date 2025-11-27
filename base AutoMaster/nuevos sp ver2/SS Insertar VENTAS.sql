USE AUTOMASTER
GO

CREATE OR ALTER PROCEDURE SPInsertarVentas
(
   @Id_Vehiculo   INT,
   @Id_Cliente    INT,
   @Id_Empleado   INT, 
   @Precio_Venta  DECIMAL(18,2),
   @Observaciones VARCHAR(500) = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    -- DEFINICIÓN DE ESTADOS  IDs según su tabla Cls_Estados
    DECLARE @Id_Estado_Disponible INT = 1; 
    DECLARE @Id_Estado_Vendido    INT = 2; 


    BEGIN TRY
        BEGIN TRANSACTION;

        -- 1. VALIDACIÓN BLINDADA
        -- Verificamos si el vehiculo existe Y si está en estado 'Disponible'
        IF NOT EXISTS (
            SELECT 1 
            FROM Vehiculos 
            WHERE Id_Vehiculo = @Id_Vehiculo 
              AND Id_Estado = @Id_Estado_Disponible
        )
        BEGIN
            -- Si falla, disparamos error y matamos la transacción
            RAISERROR('OPERACIÓN DENEGADA: El vehículo no existe o ya ha sido vendido.', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- 2. INSERTAR LA VENTA
        INSERT INTO Ventas (
            Id_Vehiculo, 
            Id_Cliente, 
            Id_Empleado,
            Fecha_Venta, 
            Precio_Venta,  
            Observaciones
        )
        VALUES (
            @Id_Vehiculo, 
            @Id_Cliente, 
            @Id_Empleado, 
           SYSUTCDATETIME(),
            @Precio_Venta, 
            @Observaciones
        );

        -- 3. ACTUALIZAR ESTADO DEL VEHÍCULO (Lógica de Negocio)
        -- El vehículo pasa a estado "VENDIDO" automáticamente
        UPDATE Vehiculos 
        SET Id_Estado = @Id_Estado_Vendido 
        WHERE Id_Vehiculo = @Id_Vehiculo;

        COMMIT TRANSACTION;
        PRINT 'VENTA REGISTRADA Y VEHÍCULO BLOQUEADO CORRECTAMENTE.'
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        PRINT 'ERROR CRÍTICO: ' + ERROR_MESSAGE();
    END CATCH
END;
GO


SELECT  * FROM Vehiculos


EXEC SPInsertarVentas
    @Id_Vehiculo  = 1,      
    @Id_Cliente   = 1,      
    @Id_Empleado  = 1,      
    @Precio_Venta = 25000.00,
    @Observaciones= 'Venta con cambio de estado automático';


SELECT Id_Vehiculo, Id_Estado FROM Vehiculos WHERE Id_Vehiculo = 1; 

SELECT * FROM Ventas 
