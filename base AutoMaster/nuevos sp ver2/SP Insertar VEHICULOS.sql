USE AUTOMASTER
GO

CREATE OR ALTER PROCEDURE SPinsertarVehiculos
(
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
            INSERT INTO Vehiculos (
                Id_Proveedor,
                Marca,
                Modelo,
                Anio,
                Serie_Chasis,
                Serie_Motor,
                Precio,
                Id_Estado,
                Fecha_Ingreso_Pais
            )
            VALUES (
                @Id_Proveedor,
                @Marca,
                @Modelo,
                @Anio,
                @Serie_Chasis,
                @Serie_Motor,
                @Precio,
                @Id_Estado,
                @Fecha_Ingreso_Pais
            )
        COMMIT
        PRINT 'SE HA INSERTADO EL VEHÍCULO CORRECTAMENTE'
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'NO SE HA INSERTADO ' + ERROR_MESSAGE()
    END CATCH
END
GO

