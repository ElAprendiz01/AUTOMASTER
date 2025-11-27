USE AUTOMASTER
GO 
CREATE OR ALTER PROCEDURE SPactualizarContacto
(   @Id_Contacto INT,
	@Id_Persona INT,
	@Id_Tipo_Contacto INT,
	@Contacto NVARCHAR(150),
	@Principal BIT, 
	@Id_Estado INT 

)
AS 
BEGIN 
	SET NOCOUNT ON;
		BEGIN TRY 
		  BEGIN TRAN 
			 UPDATE Tbl_Contactos
				 SET
				  Id_Persona = @Id_Persona,
				  Id_Tipo_Contacto=@Id_Tipo_Contacto,
				  Contacto=@Contacto,
				  Principal=@Principal,
				  Id_Estado = @Id_Estado,
				  Fecha_Modificacion = SYSDATETIME()
				  WHERE  Id_Contacto = @Id_Contacto
			
	 COMMIT
		PRINT' SE ACTUALIZO CORRECTAMENTE '
	 END TRY 
	 BEGIN CATCH 
		ROLLBACK
		PRINT' NO SE HA PODIDO ACTUALIZAR ' + @@ERROR 
	END CATCH 
END 
GO	

EXEC  SPactualizarContacto 2010,1004,11, 'ELcorreo', 1, 1

SELECT * FROM Tbl_Contactos 


