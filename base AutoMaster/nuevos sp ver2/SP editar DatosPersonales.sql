
USE AUTOMASTER
GO

CREATE OR ALTER PROCEDURE SPActualizarDatosPersonales
(
   @Id_Persona INT,
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
            UPDATE  Tbl_Datos_Personales
                                   SET Primer_Nombre= @Primer_Nombre,
                                    Segundo_Nombre	= @Segundo_Nombre,
                                    Primer_Apellido	=  @Primer_Apellido,
                                    Segundo_Apellido= @Segundo_Apellido,
									Id_Genero		= @Id_Genero,
									Id_Tipo_DNI		= @Id_Tipo_DNI,
									DNI				= @DNI,
									Fecha_Modificacion = SYSDATETIME(),
									Id_Estado= @Id_Estado
									WHERE Id_Persona = @Id_Persona

        COMMIT
        PRINT 'SE HA ACTUALIZADO LOS DATOS PERSOANLES '
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'no se ha insertado ' + @@error
    END CATCH
END
GO

SELECT * FROM Tbl_Datos_Personales
EXEC SPActualizarDatosPersonales
 @Id_Persona =1005,
   @Primer_Nombre = 'ACTUALIZACIO01',
   @Segundo_Nombre = 'ACTUALIZACIO01',
   @Primer_Apellido= 'ACTUALIZACIO01',
   @Segundo_Apellido = 'ACTUALIZACIO01',
   @Id_Genero = 2,
   @Id_Tipo_DNI =3,
   @DNI = 'ACTUALIZACIO01',
   @Id_Estado = 2
