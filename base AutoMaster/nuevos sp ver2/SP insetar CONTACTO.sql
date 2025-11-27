USE AUTOMASTER
GO 
CREATE OR ALTER PROCEDURE SPinsertarContacto
(
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
			 INSERT INTO Tbl_Contactos (Id_Persona, Id_Tipo_Contacto, Contacto, Principal, Id_Estado)
			 VALUES (@Id_Persona,@Id_Tipo_Contacto, @Contacto, @Principal, @Id_Estado)
	 COMMIT
		PRINT' SE INSERTO CORRECTAMENTE '
	 END TRY 
	 BEGIN CATCH 
		ROLLBACK
		PRINT' NO SE HA PODIDO INSERTAR ' + @@ERROR 
	END CATCH 
END 
GO	

EXEC SPinsertarContacto 1004, 2, '+50255255',0,1

SELECT * FROM Tbl_Contactos