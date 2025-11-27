USE AUTOMASTER
GO

CREATE OR ALTER PROCEDURE SPActualizarEmpleados
(
   @Id_Empleado INT,
   @Id_Persona INT,
   @Id_Cargo INT,
   @Id_Area INT,
   @Activo BIT
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
            UPDATE Empleados
            SET Id_Persona = @Id_Persona,
                Id_Cargo = @Id_Cargo,
                Id_Area = @Id_Area,
                Activo = @Activo
            WHERE Id_Empleado = @Id_Empleado

        COMMIT
        PRINT 'SE HA ACTUALIZADO EL EMPLEADO CORRECTAMENTE'
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'NO SE HA ACTUALIZADO: ' + ERROR_MESSAGE()
    END CATCH
END
GO


EXEC SPActualizarEmpleados
    @Id_Empleado = 1,    
    @Id_Persona  = 1005, 
    @Id_Cargo    = 1,
    @Id_Area     = 2,    
    @Activo      = 0     
GO