USE AUTOMASTER
GO
CREATE OR ALTER PROCEDURE SPActualizarTaller
(   @Id_Taller INT,
    @Id_Vehiculo INT,
    @Descripcion_Trabajo VARCHAR(500),
    @Fecha_Ingreso DATE,
    @Fecha_Salida DATE,
    @Costo DECIMAL(18,2),
    @Responsable INT
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
             UPDATE  Taller
            
               SET Id_Vehiculo= @Id_Taller,
                Descripcion_Trabajo = @Descripcion_Trabajo,
                Fecha_Ingreso = @Fecha_Ingreso,
                Fecha_Salida = @Fecha_Salida,
                Costo = @Costo,
                Responsable= @Responsable
				WHERE Id_Taller = @Id_Taller
            
        COMMIT
        PRINT 'REGISTRO ACTUALIZADO CORRECTAMENTE'
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'ERROR AL ACTUALIZAR ' + ERROR_MESSAGE()
    END CATCH
END
GO

SELECT * FROM Vehiculos
SELECT * FROM Taller

EXEC SPActualizarTaller  1,1 , 'SJSJ', '2025/10/15', NULL, 10.25, 1
