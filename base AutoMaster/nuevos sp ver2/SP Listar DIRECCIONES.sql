USE AUTOMASTER
GO

CREATE OR ALTER  procedure SPlistarDireccioens
as
BEGIN 
	SET NOCOUNT ON;
	BEGIN TRY 
		SELECT 
		DTP.Id_Persona,
		DTP.Primer_Nombre,
		DTP.Primer_Apellido,
		DIREC.Id_Direccion,
		DIREC.Direccion,
		DIREC.Ciudad,
		DIREC.Departamento,
		DIREC.Principal,
		DIREC.Id_Estado,
		EST.Estado
		FROM Tbl_Direcciones AS DIREC
		INNER JOIN Tbl_Datos_Personales DTP ON DIREC.Id_Persona= DTP.Id_Persona
		INNER JOIN Cls_Estados EST ON DIREC.Id_Estado = EST.Id_Estado
		ORDER BY DTP.Id_Persona ASC
		END TRY 
	BEGIN CATCH 
		PRINT ' NO SE HA PODIDO INSERTAR'+ @@ERROR 
	END CATCH 
END
GO 
EXEC SPlistarDireccioens

SELECT * FROM Tbl_Direcciones