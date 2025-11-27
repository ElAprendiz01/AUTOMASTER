USE AUTOMASTER
GO

CREATE OR ALTER PROCEDURE SPActualizarVehiculos
(
    @Id_Vehiculo INT,
    @Id_Proveedor INT,
    @Marca VARCHAR(80),
    @Modelo VARCHAR(80),
    @Anio INT,
    @Serie_Chasis VARCHAR(100),
    @Serie_Motor VARCHAR(100),
    @Precio DECIMAL(18,2),
    @Id_Estado INT,
    @Fecha_Ingreso_Pais DATE
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
            UPDATE Vehiculos
            SET 
                Id_Proveedor = @Id_Proveedor,
                Marca = @Marca,
                Modelo = @Modelo,
                Anio = @Anio,
                Serie_Chasis = @Serie_Chasis,
                Serie_Motor = @Serie_Motor,
                Precio = @Precio,
                Id_Estado = @Id_Estado,
                Fecha_Ingreso_Pais = @Fecha_Ingreso_Pais
            WHERE Id_Vehiculo = @Id_Vehiculo
        COMMIT
        PRINT 'SE HA ACTUALIZADO EL VEHÍCULO CORRECTAMENTE'
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'NO SE HA ACTUALIZADO ' + ERROR_MESSAGE()
    END CATCH
END
GO