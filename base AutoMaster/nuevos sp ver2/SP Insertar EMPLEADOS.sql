USE AUTOMASTER
GO

CREATE OR ALTER PROCEDURE SPinsertarEmpleados
(
   @Id_Persona INT,
   @Id_Cargo INT,
   @Id_Area INT,
   @Activo BIT
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
            INSERT INTO Empleados(
                                    Id_Persona,
                                    Id_Cargo,
                                    Id_Area,
                                    Activo,
                                    Fecha_Registro
                                 )
            VALUES (
                    @Id_Persona,
                    @Id_Cargo,
                    @Id_Area,
                    @Activo,
                    SYSUTCDATETIME()
                   )
        COMMIT
        PRINT 'SE HA INSERTADO EL EMPLEADO CORRECTAMENTE'
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'NO SE HA INSERTADO: ' + ERROR_MESSAGE()
    END CATCH
END
GO

EXEC SPinsertarEmpleados 
    @Id_Persona = 1005, 
    @Id_Cargo   = 1,    
    @Id_Area    = 1,    
    @Activo     = 1
GO