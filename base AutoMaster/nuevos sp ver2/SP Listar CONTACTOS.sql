USE AUTOMASTER
GO
CREATE OR ALTER PROCEDURE SPlistarContacto
as 
BEGIN 
	SET NOCOUNT ON;
	BEGIN TRY 
	SELECT 
	DTP.Id_Persona,
	DTP.Primer_Nombre,
	dtp.Primer_Apellido, 
	CTO.Id_Contacto,
	CTO.Contacto,
	cto.Id_Tipo_Contacto,
	CAT.Catalogo as TIPO_CONTACTO,
	CTO.Principal,
	CTO.Fecha_Creacion,
	CTO.Fecha_Modificacion,
	EST.Id_Estado,
	EST.Estado
	FROM Tbl_Contactos AS CTO
	INNER JOIN Tbl_Datos_Personales DTP ON CTO.Id_Persona = DTP.Id_Persona
	INNER JOIN Cls_Catalogos CAT ON CTO.Id_Tipo_Contacto = CAT.Id_Catalogo
	INNER JOIN Cls_Estados EST ON CTO.Id_Estado =  EST.Id_Estado
	ORDER BY DTP.Id_Persona ASC
	

	END TRY 
	BEGIN CATCH
		PRINT' NO SE HA PODIDO LISTAR'
	END CATCH 
END 
GO 

EXEC SPlistarContacto

SELECT * FROM Tbl_Contactos