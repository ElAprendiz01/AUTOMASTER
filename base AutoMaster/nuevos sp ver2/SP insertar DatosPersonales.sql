CREATE OR ALTER PROCEDURE SPinsertarDatosPersonales
(
  
   @Primer_Nombre VARCHAR(80),
   @Segundo_Nombre VARCHAR(80),
   @Primer_Apellido VARCHAR(80),
   @Segundo_Apellido VARCHAR(80),
   @Id_Genero INT,
   @Id_Tipo_DNI INT,
   @DNI VARCHAR(50),
   @Id_Estado INT

)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
            INSERT INTO Tbl_Datos_Personales(
                                    Primer_Nombre,
                                    Segundo_Nombre,
                                    Primer_Apellido,
                                    Segundo_Apellido,
									Id_Genero,
									Id_Tipo_DNI,
									DNI,
									Id_Estado
                                    )
            VALUES (
                    
					@Primer_Nombre,
					@Segundo_Nombre,
					@Primer_Apellido,
					@Segundo_Apellido,
					@Id_Genero,
					@Id_Tipo_DNI,
					@DNI,
					@Id_Estado

                    )
        COMMIT
        PRINT 'SE HA INSERTADO LOS DATOS PERSOANLES '
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'no se ha insertado ' + @@error
    END CATCH
END
GO