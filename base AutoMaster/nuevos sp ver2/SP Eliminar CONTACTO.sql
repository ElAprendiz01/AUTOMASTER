USE AUTOMASTER
GO 
create or alter procedure spELiminarContacto
(
	@Id_Contacto INT 
)
as 
BEGIN 
	SET NOCOUNT ON ;
	BEGIN TRY 
		BEGIN TRAN
			DELETE Tbl_Contactos WHERE Id_Contacto = @Id_Contacto 
			COMMIT 
			PRINT ' SE HA ELIMANADO CORRECTAMRNTE  '
		END TRY 
		BEGIN CATCH 
			PRINT ' NO SE HA PODIDO ELIMINAR'+ @@ERROR 
		ROLLBACK
		END CATCH
END 
GO 

SELECT * FROM Tbl_Contactos


